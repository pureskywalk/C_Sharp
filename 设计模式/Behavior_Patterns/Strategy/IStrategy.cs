using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //策略接口声明某些算法的所有受支持版本通用的操作。
    //
    //上下文使用此接口调用 ConcreteStrategy 定义的算法。
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
