using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    //Creator 类声明应返回 Product 类对象的工厂方法。Creator的子类通常提供此方法的实现。
    abstract class Creator
    {
        //请注意，Creator还可能提供工厂方法的一些默认实现。
        public abstract IProduct FactoryMethod();

        //还要注意，尽管它的名字叫Creator，但它主要责任不是创造产品。
        //通常，它包含一些依赖于工厂方法返回的 Product 对象的核心业务逻辑。
        //子类可以通过重写工厂方法并从中返回不同类型的产品来间接更改该业务逻辑。
        public string SomeOperation()
        {
            //调用工厂方法以创建 Product 对象。
            var product = FactoryMethod();

            //现在，使用该产品。
            var result = $"Creator: The same creator's code has just worked with{product.Operation()}";

            return result;
        }
    }
}
