using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口的语法特征
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IFlyable //接口中可以有方法、自动属性、事件和索引器，但本质上都是方法
    {
        //接口中的成员不允许有访问修饰符，默认就是Public

        void Fly();

        string Test();

        //不允许写具有方法体的函数，抽象类中的普通函数可以有方法体，抽象函数不能有函数体

        //接口中不能有字段、
        string Name //自动属性，没有方法体
        {
            get;
            set;
        }

    }
}
