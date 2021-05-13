using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class GetHelper : AbsHttpHelper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseAddr">访问的主机</param>
        /// <param name="auth">验证字符串</param>
        /// <param name="path">请求的路径</param>
        public GetHelper(string baseAddr, string auth, string path)
        {
            this.baseAddr = baseAddr;
            this.auth = auth;
            this.path = path;
        }

        public override string GetResult()
        {
            string resultContent = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddr);
                var t = client.GetAsync(path);
                t.Wait();
                var result = t.Result;
                resultContent = result.Content.ReadAsStringAsync().Result;
            }
            return resultContent;
        }
    }
}
