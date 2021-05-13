using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class PostHelper : AbsHttpHelper
    {
        //发送的数据
        private FormUrlEncodedContent content = null;

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="baseAddr">请求的主机</param>
        /// <param name="auth">验证字符串</param>
        /// <param name="path">请求路径</param>
        /// <param name="isAuth">是否启用验证</param>
        /// <param name="content">发送的数据</param>
        public PostHelper(string baseAddr, string auth, string path, bool isAuth, FormUrlEncodedContent content)
        {
            this.baseAddr = baseAddr;
            this.auth = auth;
            this.content = content;
            this.path = path;
            this.isAuth = isAuth;
        }

        public override string GetResult()
        {
            string resultContent = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddr);
                if (isAuth)
                {
                    client.DefaultRequestHeaders.Add("Authorization", auth);
                }
                
                string data = "test";
                HttpContent content = new StringContent(data);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var t = client.PostAsync(path, content);
                //var t = client.GetAsync(path);
                t.Wait();
                var result = t.Result;
                resultContent = result.Content.ReadAsStringAsync().Result;
            }
            return resultContent;
        }
    }
}
