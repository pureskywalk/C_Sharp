using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //组合类表示可能具有子项的复杂组件。
    //通常，组合对象将实际工作委托给其子对象，然后“汇总”结果。
    class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        //组合以特定方式执行其主逻辑。它以递归方式遍历其所有子项，
        //收集和汇总其结果。由于组合体的子项将这些调用传递给其子项等，
        //因此将遍历整个对象树。
        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
