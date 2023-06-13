using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //调用程序与一个或多个命令相关联。它向命令发送请求。
    class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // 初始化命令
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        //调用程序不依赖于具体的命令或接收器类。
        //调用程序通过执行命令将请求间接传递给接收方。
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}
