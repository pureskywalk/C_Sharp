using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    //默认链接行为可以在基处理程序类中实现。
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            //从这里返回一个处理程序将让我们以一种方便
            //的方式链接处理程序，如下所示：
            //monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
