using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;

namespace WcfServiceLibrary
{
    public class AttractionsService : IAttractionsService
    {
        [WebInvoke(Method = "GET", UriTemplate = "GetData/{value}/", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
