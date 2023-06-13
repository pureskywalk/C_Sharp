using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //上下文定义了客户感兴趣的接口。
    class Context
    {
        //上下文维护对其中一个策略对象的引用。上下文不知道策略的具体类别。
        //它应该通过策略接口与所有策略一起使用。
        private IStrategy _strategy;

        public Context()
        { }

        //通常，上下文通过构造函数接受策略，但也提供一个设置器来在运行时更改它。
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        //通常，上下文允许在运行时替换策略对象。
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        //上下文将一些工作委托给 Strategy 对象，而不是自行实现算法的多个版本。
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
