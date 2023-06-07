using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //一些外观可以同时与多个子系统一起工作。
    public class Subsystem2
    {
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}
