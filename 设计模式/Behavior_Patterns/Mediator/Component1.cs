using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    //具体组件实现各种功能。它们不依赖于其他组件。它们也不依赖于任何具体的中介器类。
    class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");

            this._mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");

            this._mediator.Notify(this, "B");
        }
    }
}
