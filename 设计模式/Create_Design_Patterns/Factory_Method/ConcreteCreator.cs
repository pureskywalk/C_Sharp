using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    //ConcreteCreator重写工厂方法以更改生成的Product类型。
    class ConcreteCreator1 : Creator
    {
        //请注意，该方法的签名仍使用抽象Product类型，
        //即使ConcreteCreator实际上是从该方法返回的。
        //这样，Creator就可以独立于具体的Product类别。
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
