using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable fly = new IFlyable();//不能创建接口的实例
            IFlyable fly = new Person();
            fly.Fly();
            IFlyable fly1 = new Bird();
            fly1.Fly();

            IFlyable fly2 = new Student();
            fly2.Fly();

            Console.ReadKey();
        }
    }

    public class Person : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人在飞");
        }
    }
    public class Student : Person, IFlyable //类需要写在接口前面，这里不需要再继承IFlyable，因为Person已经有了，这里只是方便演示
    {

    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }


    public interface M1
    {
        void Test1();
    }

    public interface M2
    {
        void Test2();
    }

    public interface M3
    {
        void Test3();
    }

    public interface SuperInterface : M1, M2, M3//接口只可以继承接口
    {

    }

    public class Car : SuperInterface
    {

        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }
}
