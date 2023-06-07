using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //子系统可以直接接受来自外观或客户端的请求。无论如何，
    //对于子系统来说，外观是另一个客户端，它不是子系统的一部分。
    public class Subsystem1
    {
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}
