using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //客户端代码通过外观提供的简单接口处理复杂的子系统。
    //当外观管理子系统的生命周期时，客户端甚至可能不知道子系统的存在。
    //此方法可让您控制复杂性。
    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}
