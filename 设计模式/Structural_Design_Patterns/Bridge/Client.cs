using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Client
    {
        //除了初始化阶段（其中抽象对象与特定实现对象链接）之外，
        //客户端代码应仅依赖于抽象类。这样，客户端代码可以支持
        //任何抽象-实现组合。
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}
