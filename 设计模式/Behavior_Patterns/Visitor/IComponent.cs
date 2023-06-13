using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //组件接口声明一个“accept”方法，该方法应将基本访问者接口作为参数。
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
