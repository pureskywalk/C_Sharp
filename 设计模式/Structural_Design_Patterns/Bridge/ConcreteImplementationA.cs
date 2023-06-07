using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //每个具体实现对应于一个特定的平台，
    //并使用该平台的 API 实现 "实现接口"。
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
