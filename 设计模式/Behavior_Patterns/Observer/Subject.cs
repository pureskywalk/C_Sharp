using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    //发布者拥有一些重要的状态并且可以在状态变化时通知订阅者
    public class Subject : ISubject
    {
        //为简单起见，发布者的状态（对所有订阅者都是必不可少的）存储在此变量中。
        public int State { get; set; } = -0;

        //订阅者列表。在现实生活中，订阅者列表可以更全面地存储（按事件类型等分类）。
        private List<IObserver> _observers = new List<IObserver>();

        //订阅管理方法。
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        //在每个订阅者中触发更新。
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        //通常，订阅逻辑只是发布者真正可以执行的操作的一小部分。
        //发布者通常持有一些重要的业务逻辑，每当重要的事情即将发生
        //（或之后）时，都会触发通知方法。
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
