using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteComponentB : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}
