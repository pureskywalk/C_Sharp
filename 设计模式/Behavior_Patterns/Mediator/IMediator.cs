using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    //中介器接口声明组件用来通知中介程序有关各种事件的方法。
    //中介程序可能会对这些事件做出反应，并将执行传递给其他组件。
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
