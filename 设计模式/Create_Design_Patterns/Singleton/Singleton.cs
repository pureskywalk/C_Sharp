using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Singleton 类定义了“GetInstance”方法，该方法用作构造函数的替代方法，
    //并允许客户端一遍又一遍地访问此类的同一实例。

    //单例应始终是“密封”类，以防止通过外部类和嵌套类进行类继承。
    public sealed class Singleton
    {
        private Singleton() { }

        //单一实例的实例存储在静态字段中。有多种方法可以初始化此字段，
        //它们都有各种优点和缺点。在这个例子中，我们将展示最简单的方法，
        //但是，这些方法在多线程程序中效果不佳。
        private static Singleton _instance;

        //这是控制对单一实例的访问的静态方法。在第一次运行时，它会创建
        //一个单一实例对象并将其放入静态字段中。在后续运行时，它将返回
        //存储在静态字段中的现有对象。
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        //最后，任何单例都应该定义一些业务逻辑，这些逻辑可以在其实例上执行。
        public void someBusinessLogic()
        {
            // ...
        }
    }
}
