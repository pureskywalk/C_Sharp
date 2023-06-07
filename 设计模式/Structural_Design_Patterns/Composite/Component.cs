using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //基组件类声明组合的简单和复杂对象的常见操作。
    abstract class Component
    {
        public Component() { }

        //基组件可以实现一些默认行为或将其留给具体类
        //（通过将包含该行为的方法声明为“抽象”）。
        public abstract string Operation();

        //在某些情况下，在基组件类中定义子管理操作会很有帮助。
        //这样，就无需向客户端代码公开任何具体的组件类，即使
        //在对象树程序集期间也是如此。缺点是这些方法对于叶级组件将是空的。
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        //您可以提供一种方法，让客户端代码确定组件是否可以拥有子组件。
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
