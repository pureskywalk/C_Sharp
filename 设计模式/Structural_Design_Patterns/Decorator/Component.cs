using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //基本组件接口定义可由装饰器更改的操作。
    public abstract class Component
    {
        public abstract string Operation();
    }
}
