using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace WcfServiceLibrary
{
    public interface ILocationService
    {
        [OperationContract]
        string GetData(string value);
        [OperationContract]
        int uploadLocation(string phoneNumber, float x, float y);
        [OperationContract]
        string GetData(string value);
        [OperationContract]
        string GetData(string value);
        // TODO: 在此添加您的服务操作
    }
}
