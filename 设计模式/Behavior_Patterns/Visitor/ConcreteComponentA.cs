using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //每个具体组件都必须以这样一种方式实现“Accept”方法，
    //即它调用与组件的类相对应的访问者方法。
    public class ConcreteComponentA : IComponent
    {
        //请注意，我们调用的是“VisitConcreteComponentA”，
        //它与当前类名匹配。通过这种方式，我们让访问者知道它使用的组件的类。
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        //具体组件可能具有其基类或接口中不存在的特殊方法。
        //访问者仍然可以使用这些方法，因为它知道组件的具体类。
        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}
