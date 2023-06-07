using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //抽象定义了两个类层次结构的“控件”部分的接口。
    //它维护对实现层次结构的对象的引用，并将所有实际
    //工作委托给该对象。
    class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }
}
