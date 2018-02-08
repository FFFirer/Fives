using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Fives.Server
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IGobangService”。
    //需要服务端实现的协定
    [ServiceContract(Namespace = "Fives.Server.IGobangService", SessionMode = SessionMode.Required, CallbackContract = typeof(IGobangServiceCallback))]
    public interface IGobangService
    {
        [OperationContract(IsOneWay = true)] void Login(string userName);
        [OperationContract(IsOneWay = true)] void Logout(string userName);
        [OperationContract(IsOneWay = true)] void SitDown(string userName, int index, int side);
        [OperationContract(IsOneWay = true)] void GetUp(int index, int side);
        [OperationContract(IsOneWay = true)] void Start(string userName, int index, int side);
        [OperationContract(IsOneWay = true)] void SetDot(int index, int i, int j);
        [OperationContract(IsOneWay = true)] void Talk(int index, string userName, string message);
    }

    //需要客户端实现的协定
    public interface IGobangServiceCallback
    {
        [OperationContract(IsOneWay = true)] void ShowLogin(string loginUserName, int maxTables);
        [OperationContract(IsOneWay = true)] void ShowLogout(string userName);
        [OperationContract(IsOneWay = true)] void ShowSitDown(string userName, int side);
        [OperationContract(IsOneWay = true)] void ShowGetUp(int side);
        [OperationContract(IsOneWay = true)] void ShowStart(int side);
        [OperationContract(IsOneWay = true)] void ShowTalk(string userName, string message);
        [OperationContract(IsOneWay = true)] void ShowSetDot(int i, int j, int color);
        [OperationContract(IsOneWay = true)] void GameStart();
        [OperationContract(IsOneWay = true)] void GameWin(string message);
        [OperationContract(IsOneWay = true)] void UpdateTablesInfo(string tablesInfo, int userCount);
    }
}
