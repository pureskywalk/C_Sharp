using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //但是，有些命令可以将更复杂的操作委托给其他命令对象，称为“接收器”
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        //上下文数据，用于启动接收方的方法。
        private string _a;

        private string _b;

        //复杂命令可以接受一个或多个接收方对象通过构造函数使用任何上下文数据。
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        //命令可以委托给接收方的任何方法。
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}
