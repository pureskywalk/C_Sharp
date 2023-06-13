using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //具体类必须实现基类的所有抽象操作。它们还可以使用默认实现覆盖某些操作。
    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }
    }
}
