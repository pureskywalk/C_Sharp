using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口就是一个规范、能力。
        }
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类，我可以吃喝");
        }
    }

    public class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("我可以扣篮");
        }
    }

    public class student : Person,IKouLanable//既是人类又想扣篮,用到接口，并不是继承多个父类
    {

        public void KouLan()
        {
            Console.WriteLine("我也可以扣篮");
        }
    }

    public interface IKouLanable
    {
        void KouLan();
    }
}
 