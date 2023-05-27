using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.Fly();
            Bird bird = new Bird();
            bird.Fly();

            Console.ReadKey();
        }
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }

        void IFlyable.Fly()//显示实现接口，解决方法重名问题,不能加上访问修饰符，在这里默认为private
        {
            Console.WriteLine("鸟在接口中飞");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
