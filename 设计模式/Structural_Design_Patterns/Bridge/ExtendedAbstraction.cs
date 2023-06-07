using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //您可以在不更改实现类的情况下扩展抽象。
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}
