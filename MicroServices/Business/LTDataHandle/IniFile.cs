﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mqttclientForm
{
    class Ini
    {
        // 声明INI文件的写操作函数 WritePrivateProfileString()

        [System.Runtime.InteropServices.DllImport("kernel32")]

        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()

        [System.Runtime.InteropServices.DllImport("kernel32")]

        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);


        private string sPath = null;
        public Ini(string path)
        {
            string str = "";// System.Environment.CurrentDirectory;
            str += "C:\\";
            str += path;
            this.sPath = str;
        }
        public bool CreatFile()
        {
            if (sPath != null && sPath.Length > 0)
            {
                FileStream fs = new FileStream(sPath, FileMode.Create);
                fs.Close();
                return true;
            }
            return false;
        }
        public void Write(string section, string key, string value)
        {

            // section=配置节,key=键名,value=键值,path=路径

            WritePrivateProfileString(section, key, value, sPath);

        }
        public string ReadValue(string section, string key)
        {

            // 每次从ini中读取多少字节

            System.Text.StringBuilder temp = new System.Text.StringBuilder(2048);

            // section=配置节,key=键名,temp=上面,path=路径

            GetPrivateProfileString(section, key, "", temp, 2048, sPath);

            return temp.ToString();

        }


    }
}
