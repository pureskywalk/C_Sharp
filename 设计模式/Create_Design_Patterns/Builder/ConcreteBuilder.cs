using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //具体生成器类遵循生成器接口，并提供构建步骤的特定实现。
    //您的程序可能有多种生成器变体，以实现不同的方式。
    internal class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        //新的生成器实例应包含一个空白产品对象，该对象用于进一步的组装。
        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new Product();
        }

        //所有生产步骤都使用相同的产品实例。
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }

        //具体生成器应该提供自己的方法来检索结果。这是因为各种类型
        //的生成器可能会创建不遵循相同接口的完全不同的产品。因此，
        //此类方法不能在基本生成器接口中声明（至少在静态类型编程语言中）。

        //通常，在将最终结果返回给客户端后，生成器实例应准备好开始生产
        //另一个产品。这就是为什么在“GetProduct”方法主体的末尾调用重
        //置方法是一种通常的做法。但是，此行为不是必需的，您可以让生成器
        //在释放上一个结果之前等待来自客户端代码的显式重置调用。
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
