using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUserService”。
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        int GetData(string value);
        [OperationContract]
        int Register(string phoneNumber, string password, string name, string nickName, string sex);
        [OperationContract]
        int Login(string phoneNumber, string password);
        [OperationContract]
        int ChangePassword(string phoneNumber, string oldPassword, string newPassword);
        [OperationContract]
        int GetPassword(string phoneNumber);
        [OperationContract]
        int ResetPassword(string phoneNumber, string newPassword);
        [OperationContract]
        int ChangePersonalInfo(string phoneNumber, string name, string nickName, string sex, byte[] avatar);
        [OperationContract]
        int FindUserByPhoneNum(string phoneNumber, string targetUserNumber);
        [OperationContract]
        int FindUserByShake(string phoneNumber);
        [OperationContract]
        int AddFriend(string phoneNumber, string targetUserNumber);
        [OperationContract]
        int GetFriendInfo(string phoneNumber, string targetUserNumber);
        [OperationContract]
        int SetFriendPrivilege(string phoneNumber, string targetUserNumber, int pirvilege);
        [OperationContract]
        int GetOfflineMessage(string phoneNumber);
        [OperationContract]
        int GetUserTrack(string phoneNumber, string targetUserNumber);
        [OperationContract]
        int GetUserHistoricalLocation(string phoneNumber, string targetUserNumber, string startTime, string endTime);
        [OperationContract]
        int ApplyForAid(string phoneNumber, float x, float y);
        // TODO: 在此添加您的服务操作
    }
}
