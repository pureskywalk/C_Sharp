using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    //处理程序接口声明用于生成处理程序链的方法。
    //它还声明了执行请求的方法。
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
