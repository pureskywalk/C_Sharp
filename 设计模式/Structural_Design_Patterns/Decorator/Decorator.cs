using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //基装饰器类遵循与其他组件相同的接口。此类的主要用途
    //是定义所有具体装饰器的包装接口。包装代码的默认实现
    //可能包括用于存储包装组件的字段以及初始化它的方法。
    abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        //装饰器将所有工作委托给包装的组件。
        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
