using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    //抽象工厂接口声明一组返回不同抽象产品的方法。
    //这些产品称为一个系列，并通过高级主题或概念相关联。
    //一个系列的产品通常能够相互协作。一个产品系列可能
    //有多个变型，但一个变型的产品与另一个变型的产品不兼容。
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
