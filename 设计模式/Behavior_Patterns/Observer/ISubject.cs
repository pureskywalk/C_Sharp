using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        //发布者将订阅者添加进入订阅列表
        void Attach(IObserver observer);

        //发布者将订阅者从订阅列表删除
        void Detach(IObserver observer);

        //通知所有订阅者关于新的事件
        void Notify();
    }
}
