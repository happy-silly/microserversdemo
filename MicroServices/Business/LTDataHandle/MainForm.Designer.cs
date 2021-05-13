namespace mqttclientForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源,为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxMsg = new System.Windows.Forms.ListBox();
            this.lbxSubscribed = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnUnsub = new System.Windows.Forms.Button();
            this.tbxTopic = new System.Windows.Forms.TextBox();
            this.gbxSend = new System.Windows.Forms.GroupBox();
            this.tbxSendTopic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSend.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxMsg
            // 
            this.lbxMsg.FormattingEnabled = true;
            this.lbxMsg.ItemHeight = 15;
            this.lbxMsg.Location = new System.Drawing.Point(13, 478);
            this.lbxMsg.Margin = new System.Windows.Forms.Padding(4);
            this.lbxMsg.Name = "lbxMsg";
            this.lbxMsg.Size = new System.Drawing.Size(517, 274);
            this.lbxMsg.TabIndex = 0;
            this.lbxMsg.SelectedIndexChanged += new System.EventHandler(this.lbxMsg_SelectedIndexChanged);
            // 
            // lbxSubscribed
            // 
            this.lbxSubscribed.FormattingEnabled = true;
            this.lbxSubscribed.ItemHeight = 15;
            this.lbxSubscribed.Location = new System.Drawing.Point(8, 61);
            this.lbxSubscribed.Margin = new System.Windows.Forms.Padding(4);
            this.lbxSubscribed.Name = "lbxSubscribed";
            this.lbxSubscribed.Size = new System.Drawing.Size(215, 214);
            this.lbxSubscribed.TabIndex = 1;
            this.lbxSubscribed.SelectedIndexChanged += new System.EventHandler(this.lbxSubscribed_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(391, 58);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 48);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMsg
            // 
            this.tbxMsg.Location = new System.Drawing.Point(95, 79);
            this.tbxMsg.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.Size = new System.Drawing.Size(212, 25);
            this.tbxMsg.TabIndex = 5;
            this.tbxMsg.Text = "to send msg";
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(403, 148);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(84, 48);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "订阅";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnUnsub
            // 
            this.btnUnsub.Location = new System.Drawing.Point(236, 148);
            this.btnUnsub.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnsub.Name = "btnUnsub";
            this.btnUnsub.Size = new System.Drawing.Size(84, 48);
            this.btnUnsub.TabIndex = 8;
            this.btnUnsub.Text = "取消订阅";
            this.btnUnsub.UseVisualStyleBackColor = true;
            this.btnUnsub.Click += new System.EventHandler(this.btnUnsub_Click);
            // 
            // tbxTopic
            // 
            this.tbxTopic.Location = new System.Drawing.Point(312, 92);
            this.tbxTopic.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTopic.Name = "tbxTopic";
            this.tbxTopic.Size = new System.Drawing.Size(173, 25);
            this.tbxTopic.TabIndex = 9;
            // 
            // gbxSend
            // 
            this.gbxSend.Controls.Add(this.tbxSendTopic);
            this.gbxSend.Controls.Add(this.label3);
            this.gbxSend.Controls.Add(this.label2);
            this.gbxSend.Controls.Add(this.tbxMsg);
            this.gbxSend.Controls.Add(this.btnSend);
            this.gbxSend.Location = new System.Drawing.Point(13, 308);
            this.gbxSend.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSend.Name = "gbxSend";
            this.gbxSend.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSend.Size = new System.Drawing.Size(519, 149);
            this.gbxSend.TabIndex = 10;
            this.gbxSend.TabStop = false;
            this.gbxSend.Text = "发送区";
            // 
            // tbxSendTopic
            // 
            this.tbxSendTopic.Location = new System.Drawing.Point(95, 42);
            this.tbxSendTopic.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSendTopic.Name = "tbxSendTopic";
            this.tbxSendTopic.Size = new System.Drawing.Size(132, 25);
            this.tbxSendTopic.TabIndex = 8;
            this.tbxSendTopic.Text = "to send topic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "消息:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "主题:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbxSubscribed);
            this.groupBox1.Controls.Add(this.tbxTopic);
            this.groupBox1.Controls.Add(this.btnSub);
            this.groupBox1.Controls.Add(this.btnUnsub);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 284);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主题区";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "主题:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "已订阅列表";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxSend);
            this.Controls.Add(this.lbxMsg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxSend.ResumeLayout(false);
            this.gbxSend.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMsg;
        private System.Windows.Forms.ListBox lbxSubscribed;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxMsg;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnUnsub;
        private System.Windows.Forms.TextBox tbxTopic;
        private System.Windows.Forms.GroupBox gbxSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSendTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

