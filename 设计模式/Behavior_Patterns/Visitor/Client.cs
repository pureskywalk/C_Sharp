using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Client
    {
        //客户端代码可以对任何元素集运行访问者操作，而无需弄清楚它们的具体类。
        //接受操作将调用定向到 visitor 对象中的相应操作。
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
