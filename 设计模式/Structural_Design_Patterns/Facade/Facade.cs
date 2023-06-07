using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //外观 类为一个或多个子系统的复杂逻辑提供了一个简单的接口。
    //外观将客户端请求委托给子系统中的相应对象。外观还负责管理
    //其生命周期。所有这些都保护客户端免受子系统不希望出现的复杂性。
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        //外观的方法方便快捷，可以满足子系统的复杂功能。但是，
        //客户端只能获得子系统功能的一小部分。
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationZ();
            return result;
        }
    }
}
