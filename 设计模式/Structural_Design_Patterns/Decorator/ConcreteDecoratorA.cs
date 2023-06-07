using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //具体装饰器调用包装的对象并以某种方式更改其结果。
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        //装饰器可以调用操作的父实现，而不是直接调用包装的对象。
        //此方法简化了装饰器类的扩展。
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
