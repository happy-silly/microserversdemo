using log4net;
using LTDealPeriod;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace mqttclientForm
{
    
    public partial class MainForm : Form
    {
        public static readonly ILog _log = LogManager.GetLogger("");

        MqttClient mqttClient = null;
        bool LastConnected = false;
        Thread tConnect = null;
        Thread tComCheck = null;
        public MainForm()
        {
            log4net.Config.XmlConfigurator.Configure();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        static InsertSqlServer isql = new InsertSqlServer();
        static SqlConnection con = null;
        private void MainForm_Load(object sender, EventArgs e)
        {
            _log.Info("mqtt采集程序已启动");
            iniMqttClient();
            tConnect = new Thread(new ParameterizedThreadStart(reConnect));
            tConnect.Start(10000);

            //创建sqlserver连接
            bool b = false;
            while (!b)//
            {
                b = isql.SqlConnect(ref con);

                //test
                string js = System.IO.File.ReadAllText(@"C:\Users\liuya\Desktop\temp.json");


                isql.ExecuteInsertPeriod("Period", js, 2001);


                if (!b)
                {
                    Thread.Sleep(5000);
                }

            }
            // tComCheck = new Thread(comCheck);
            // tComCheck.Start();

        }

        //void comCheck()
        //{
        //    while (true)
        //    {
        //        List<string> test = new List<string>(InsertSqlServer.IP_GUID.Keys);
        //        for (int i = 0; i < test.Count; i++)
        //        {
        //            if (DateTime.Compare(InsertSqlServer.IP_GUID[test[i]].AddMinutes(3), DateTime.Now) < 0)//超过3分钟不更实时数据认为是异常
        //            {
        //                string msg = ("{\"ip\": \"" + test[i] + "\",\"设备状态\": \"2003\"}");
        //                isql.ExecuteInsertPeriod(con, "Period", msg, 2003);
        //            }
        //        }
        //        Thread.Sleep(60 * 1000);//三分钟判断一次通信异常
        //    }
        //}
        private void iniMqttClient()
        {
            try
            {
                //string enpoint = "127.0.0.1";;
                string enpoint = "101.200.182.225";
                int port = 1883;
                mqttClient = new MqttClient(enpoint, port, false, MqttSslProtocols.None, null, null);
                //byte code = mqttClient.Connect("MQTT DataCollect test", "guest", "guest", false, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true, "DisConn", "MQTT DataCollect" + "计划外关闭", true, 30);
                byte code = mqttClient.Connect("MQTT DataCollect test", "admin", "password",false, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true, "DisConn", "MQTT DataCollect" + "计划外关闭", true, 30);
                mqttClient.ConnectionClosed += Client_ConnectionClosed;//连接断开了
                mqttClient.MqttMsgPublished += MqttClient_MqttMsgPublished;//发送完毕
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;//收到消息
                mqttClient.MqttMsgSubscribed += MqttClient_MqttMsgSubscribed;//订阅完成
                mqttClient.MqttMsgUnsubscribed += MqttClient_MqttMsgUnsubscribed;//取消订阅

             

                if (mqttClient.IsConnected && code == 0)
                {
                    LastConnected = true;
                    //连接成功了
                    log(lbxMsg, "初始化连接成功");

                    string[] topic = new string[1] { "Period" };
                    byte[] qos = new byte[1] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
                    mqttClient.Subscribe(topic, qos);

                    topic = new string[1] { "Machine" };
                    mqttClient.Subscribe(topic, qos);

                    topic = new string[1] { "Group" };
                    mqttClient.Subscribe(topic, qos);

                }
                else
                {
                    LastConnected = false;
                }
            }
            catch (Exception ex)
            {
                log(lbxMsg, "初始化连接失败" + ex.Message);
                _log.Error("初始化连接失败" + ex.Message);
            }
        }

        private void reConnect(object tick)
        {
            int p = (int)tick;
            while (true)
            {
                if (LastConnected == true && mqttClient.IsConnected == false)
                {
                    //断开连接了
                    _log.Error("断开连接了" + "reConnect");
                }
                if (mqttClient == null || !mqttClient.IsConnected)
                {
                    iniMqttClient();
                }
                Thread.Sleep(p);
            }
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            log(lbxMsg, e.Topic + "  " + Encoding.UTF8.GetString(e.Message));
            if (lbxMsg.Items.Count > 20)
                lbxMsg.Items.Clear();
            //收到消息
            Thread t = new Thread(new ParameterizedThreadStart(handler));
            t.Start(e);
        }

        private static void handler(object e1)
        {
            if ((DateTime.Now.Hour % 2 == 0) && (DateTime.Now.Minute == 0))
            {
                Process[] processes = Process.GetProcessesByName("mqttclientForm");
                foreach (Process p in processes)
                {
                    try
                    {
                        p.Kill();
                        p.Close();
                    }
                    catch (Exception ex)
                    {
                        _log.Error("进程停止失败" + ex.Message);
                    }
                }
            }
            MqttMsgPublishEventArgs e = (MqttMsgPublishEventArgs)e1;

            //插入数据库
            switch (e.Topic)
            {
                case "Period":
                    isql.ExecuteInsertPeriod( e.Topic, Encoding.UTF8.GetString(e.Message), 2001);
                    break;
                case "Machine":
                    isql.ExecuteInsertPeriod( e.Topic, Encoding.UTF8.GetString(e.Message), 2001);
                    break;
                case "Group":
                    isql.ExecuteInsertPeriod( e.Topic, Encoding.UTF8.GetString(e.Message), 2001);
                    break;
            }
            //isql.ExecuteInsert(con, e.Topic, Encoding.UTF8.GetString(e.Message), 2001);
        }

        private void MqttClient_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            //发送完毕消息
            log(lbxMsg, "消息发送完成");
        }
        private void Client_ConnectionClosed(object sender, EventArgs e)
        {
            //服务器连接断开了
            log(lbxMsg, "已经断开连接");
            _log.Error("已经断开连接" + "Client_ConnectionClosed");
        }
        private void MqttClient_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            //取消订阅
            log(lbxMsg, "已经取消订阅主题:\t" + tbxTopic.Text);
            lbxSubscribed.Items.Remove(tbxTopic.Text);
        }

        private void MqttClient_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            //订阅完成
            log(lbxMsg, "已经订阅主题:\t" + tbxTopic.Text);
            lbxSubscribed.Items.Add(tbxTopic.Text);
        }
        private void log(ListBox lbx, string msg)
        {
            lbx.Items.Insert(0, DateTime.Now.ToLongTimeString() + "\t" + msg);
        }

        private void lbxSubscribed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbxTopic.Text = lbxSubscribed.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                ;
            }
        }

        //点击发送消息按键
        private void btnSend_Click(object sender, EventArgs e)
        {
            mqttClient.Publish(tbxSendTopic.Text, Encoding.UTF8.GetBytes(tbxMsg.Text));
        }

        private void btnUnsub_Click(object sender, EventArgs e)
        {
            string[] topics = new string[1] { tbxTopic.Text };
            mqttClient.Unsubscribe(topics);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string[] topics = new string[1] { tbxTopic.Text };
            byte[] qoss = new byte[1] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
            mqttClient.Subscribe(topics, qoss);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mqttClient.Disconnect();
            tConnect.Abort();
        }
        private void lbxMsg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(lbxMsg.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                ;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

    }
}
