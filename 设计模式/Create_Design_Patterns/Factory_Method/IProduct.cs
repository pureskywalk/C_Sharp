using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    //Product接口声明所有ConcreteProduct必须实现的操作。
    public interface IProduct
    {
        string Operation();
    }
}
