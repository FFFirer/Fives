﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fives.Client.GobangServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Fives.Server.IGobangService", ConfigurationName="GobangServiceReference.IGobangService", CallbackContract=typeof(Fives.Client.GobangServiceReference.IGobangServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IGobangService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Login")]
        void Login(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Login")]
        System.Threading.Tasks.Task LoginAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Logout")]
        void Logout(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Logout")]
        System.Threading.Tasks.Task LogoutAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/SitDown")]
        void SitDown(string userName, int index, int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/SitDown")]
        System.Threading.Tasks.Task SitDownAsync(string userName, int index, int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/GetUp")]
        void GetUp(int index, int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/GetUp")]
        System.Threading.Tasks.Task GetUpAsync(int index, int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Start")]
        void Start(string userName, int index, int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Start")]
        System.Threading.Tasks.Task StartAsync(string userName, int index, int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/SetDot")]
        void SetDot(int index, int i, int j);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/SetDot")]
        System.Threading.Tasks.Task SetDotAsync(int index, int i, int j);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Talk")]
        void Talk(int index, string userName, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/Talk")]
        System.Threading.Tasks.Task TalkAsync(int index, string userName, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGobangServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/ShowLogin")]
        void ShowLogin(string loginUserName, int maxTables);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/ShowLogout")]
        void ShowLogout(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/ShowSitDown")]
        void ShowSitDown(string userName, int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/ShowGetUp")]
        void ShowGetUp(int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/ShowStart")]
        void ShowStart(int side);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/ShowTalk")]
        void ShowTalk(string userName, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/ShowSetDot")]
        void ShowSetDot(int i, int j, int color);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/GameStart")]
        void GameStart();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/GameWin")]
        void GameWin(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="Fives.Server.IGobangService/IGobangService/UpdateTablesInfo")]
        void UpdateTablesInfo(string tablesInfo, int userCount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGobangServiceChannel : Fives.Client.GobangServiceReference.IGobangService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GobangServiceClient : System.ServiceModel.DuplexClientBase<Fives.Client.GobangServiceReference.IGobangService>, Fives.Client.GobangServiceReference.IGobangService {
        
        public GobangServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public GobangServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public GobangServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GobangServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GobangServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Login(string userName) {
            base.Channel.Login(userName);
        }
        
        public System.Threading.Tasks.Task LoginAsync(string userName) {
            return base.Channel.LoginAsync(userName);
        }
        
        public void Logout(string userName) {
            base.Channel.Logout(userName);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(string userName) {
            return base.Channel.LogoutAsync(userName);
        }
        
        public void SitDown(string userName, int index, int side) {
            base.Channel.SitDown(userName, index, side);
        }
        
        public System.Threading.Tasks.Task SitDownAsync(string userName, int index, int side) {
            return base.Channel.SitDownAsync(userName, index, side);
        }
        
        public void GetUp(int index, int side) {
            base.Channel.GetUp(index, side);
        }
        
        public System.Threading.Tasks.Task GetUpAsync(int index, int side) {
            return base.Channel.GetUpAsync(index, side);
        }
        
        public void Start(string userName, int index, int side) {
            base.Channel.Start(userName, index, side);
        }
        
        public System.Threading.Tasks.Task StartAsync(string userName, int index, int side) {
            return base.Channel.StartAsync(userName, index, side);
        }
        
        public void SetDot(int index, int i, int j) {
            base.Channel.SetDot(index, i, j);
        }
        
        public System.Threading.Tasks.Task SetDotAsync(int index, int i, int j) {
            return base.Channel.SetDotAsync(index, i, j);
        }
        
        public void Talk(int index, string userName, string message) {
            base.Channel.Talk(index, userName, message);
        }
        
        public System.Threading.Tasks.Task TalkAsync(int index, string userName, string message) {
            return base.Channel.TalkAsync(index, userName, message);
        }
    }
}
