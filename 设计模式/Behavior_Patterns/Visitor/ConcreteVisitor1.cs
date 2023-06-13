using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //具体访客实现同一算法的多个版本，这些版本可以与所有具体组件类一起使用。
    //
    //当将访问者模式与复杂的对象结构（如复合树）一起使用时，您可以体验到它的最大好处。
    //在这种情况下，在对结构的各种对象执行访问者的方法时存储算法的一些中间状态可能
    //会有所帮助。
    class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
        }
    }
}
