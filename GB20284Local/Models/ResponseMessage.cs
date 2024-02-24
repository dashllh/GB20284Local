using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB20284Local.Models
{
    //控制器函数返回消息对象
    public class ResponseMessage
    {
        //操作命令
        public string Command { get; set; } = string.Empty;
        //返回结果(true:执行成功 | false:执行失败)
        public bool Result { get; set; } = true;
        public string Time { get; set; } = string.Empty;
        //返回消息内容
        public string Message { get; set; } = string.Empty;
        //返回的附加参数
        public Dictionary<string, object> Parameters { get; set; }

        public ResponseMessage()
        {
            Parameters = new Dictionary<string, object>();
        }
    }
}
