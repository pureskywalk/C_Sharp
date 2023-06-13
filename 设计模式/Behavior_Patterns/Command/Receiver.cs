using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //接收器类包含一些重要的业务逻辑。他们知道如何
    //执行与执行请求相关的各种操作。事实上，任何类都可以充当接收者。
    class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Also working on ({b}.)");
        }
    }
}
