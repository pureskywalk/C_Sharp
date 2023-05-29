using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //产品系列的每个不同产品都应具有基本接口。产品的所有变型都必须实现此接口。
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }

    //这是另一个产品的基本界面。所有产品都可以相互交互，
    //但只有在具有相同具体变型的产品之间才能进行适当的交互。
    public interface IAbstractProductB
    {
        // 产品B能够做自己的事情...
        string UsefulFunctionB();

        // ...但它也可以与产品A合作。抽象工厂确保它创建的所有产品都具有相同的变型，因此是兼容的。
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
