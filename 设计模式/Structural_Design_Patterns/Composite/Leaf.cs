using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Leaf 类表示合成的最终对象。一片叶子不能有子类。
    //通常，执行实际工作的是 Leaf 对象，而组合对象仅委托给其子组件。
    class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
