using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗狗会叫，猫猫也会叫

            //Animal a = new Animal();//不能创建抽象类或接口的对象
            Animal d = new Dog();
            d.Bark(); //这里调用的是父类的方法，但是被子类重写了

            Animal c = new Cat();
            c.Bark();
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract void Bark();//抽象函数没有方法体
        //public void Bark()//有方法体，没有实现方式
        //{
 
        //}
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Animal(int age)
        {
            this.Age = age;
        }

        public abstract string Name
        {
            get;
            set;
        }

        public abstract string TestString(string name);

        public Animal()
        {

        }
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗汪汪的叫");
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫猫喵喵的叫");
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }
}
