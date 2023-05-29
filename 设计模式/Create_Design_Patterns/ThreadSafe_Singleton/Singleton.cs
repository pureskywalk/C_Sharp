using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafe_Singleton
{
    //此单例实现称为“双重检查锁定”。它在多线程环境中是安全的，
    //并为 Singleton 对象提供延迟初始化。
    class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        //我们现在有一个锁定对象，它将用于在首次访问单一实例期间同步线程。
        private static readonly object _lock = new object();

        public static Singleton GetInstance(string value)
        {
            //需要此条件来防止线程在实例准备就绪后乱作一团。
            if (_instance == null)
            {
                //现在，假设该程序刚刚启动。由于尚无单一实例，因此多个线程可以
                //同时传递前一个条件并几乎同时到达此点。他们中的第一个将获得锁定
                //并继续前进，而其余的将在这里等待。
                lock (_lock)
                {
                    //获取锁的第一个线程到达此条件，进入内部并创建单一实例。一旦
                    //它离开锁定块，可能一直在等待锁定释放的线程可能会进入此部分。
                    //但由于 Singleton 字段已初始化，因此线程不会创建新对象。
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        //我们将使用此属性来证明我们的单例确实有效。
        public string Value { get; set; }
    }

}
