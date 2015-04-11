using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLibrary
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“AppService”。
    public class DataUpdateService : IDataUpdateService
    {
        [WebInvoke(Method = "GET", UriTemplate = "GetData/{value}/", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
