using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Memento
{
    //发起方持有一些可能随时间变化的重要状态。它还定义了
    //在备忘录中保存状态的方法和从中恢复状态的另一种方法。
    class Originator
    {
        //为简单起见，发起方的状态存储在单个变量中。
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        //发起方的业务逻辑可能会影响其内部状态。因此，客户端
        //应在通过 save（） 方法启动业务逻辑方法之前备份状态。
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // 将当前状态保存在备忘录中。
        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        //从备忘录对象还原发起方的状态。
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }
}
