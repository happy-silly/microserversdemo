using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    /// <summary>
    /// 创建http请求对象的工厂类
    /// </summary>
    public class HttpFactory
    {
        /// <summary>
        /// 创建http请求对象
        /// </summary>
        /// <param name="method">get/post</param>
        /// <param name="baseAddr">请求的主机</param>
        /// <param name="auth">验证字符串</param>
        /// <param name="path">请求路径</param>
        /// <param name="isAuth">是否启用验证，get请求时为false</param>
        /// <param name="content">发送的数据,get请求时为null</param>
        /// <returns></returns>
        public AbsHttpHelper CreateHttpHelper(string method, string baseAddr, string auth, string path, bool isAuth, FormUrlEncodedContent content)
        {
            AbsHttpHelper helper = null;
            method = method.ToLower();
            switch (method)
            {
                case "get":
                    helper = new GetHelper(baseAddr, auth, path);
                    break;
                case "post":
                    helper = new PostHelper(baseAddr, auth, path, isAuth, content);
                    break;
            }
            return helper;
        }
    }
}
