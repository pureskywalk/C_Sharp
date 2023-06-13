using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //具体策略在遵循基本策略接口的同时实现算法。该接口使它们在上下文中可互换。
    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
