using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //访客接口声明一组与组件类对应的访问方法。
    //访问方法的签名允许访问者识别它正在处理的组件的确切类别。
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);

        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
