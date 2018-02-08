using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Fives.Server
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“GobangService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 GobangService.svc 或 GobangService.svc.cs，然后开始调试。
    public class GobangService : IGobangService
    {
        public GobangService()
        {

        }

        public void GetUp(int index, int side)
        {
            throw new NotImplementedException();
        }

        public void Login(string userName)
        {
            throw new NotImplementedException();
        }

        public void Logout(string userName)
        {
            throw new NotImplementedException();
        }

        public void SetDot(int index, int i, int j)
        {
            throw new NotImplementedException();
        }

        public void SitDown(string userName, int index, int side)
        {
            throw new NotImplementedException();
        }

        public void Start(string userName, int index, int side)
        {
            throw new NotImplementedException();
        }

        public void Talk(int index, string userName, string message)
        {
            throw new NotImplementedException();
        }
    }
}
