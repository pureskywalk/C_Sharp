using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //通常，具体类仅覆盖基类操作的一小部分。
    class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
        }
    }
}
