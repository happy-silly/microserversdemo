using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public abstract class AbsHttpHelper
    {
        //请求的主机
        public string baseAddr = string.Empty;
        //是否启用验证
        public bool isAuth = false;
        //验证字符串
        public string auth = string.Empty;//"Bearer "+token
        //请求路径
        public string path = string.Empty;

        public abstract string GetResult();
    }
}
