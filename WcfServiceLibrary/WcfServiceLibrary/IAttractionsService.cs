using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace WcfServiceLibrary
{
    public interface IAttractionsService
    {
        [OperationContract]
        string GetData(string value);
        // TODO: 在此添加您的服务操作
    }
}
