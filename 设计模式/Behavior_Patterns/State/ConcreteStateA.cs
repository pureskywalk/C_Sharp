using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //具体状态实现了与上下文状态关联的各种行为。
    class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request2.");
        }
    }
}
