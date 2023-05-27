using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //让一个对象表现出多种的状态(类型)
            //实现多态的手段：1、虚方法 2、抽象类 3、接口
            //虚方法，virtual，override
            Chinese cn1 = new Chinese("张三");
            Chinese cn2 = new Chinese("李四");
            Japanese j1 = new Japanese("小林");
            Japanese j2 = new Japanese("香菜");
            American a1 = new American("乔治");
            American a2 = new American("迈克");


            Person[] pers = { cn1, cn2, j1, j2, a1, a2 };

            for (int i = 0; i < pers.Length; i++)
            {
                pers[i].SayHello();
            }
            Console.ReadKey();
        }
    }

    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Chinese:Person
    {
        public Chinese(string name)
            : base(name)
        {
 
        }

        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我是{0}",this.Name);
        }
    }

    public class Japanese : Person
    {
        public Japanese(string name)
            : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是日本人，我是{0}", this.Name);
        }
    }

    public class American : Person
    {
        public American(string name)
            : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是美国人，我是{0}", this.Name);
        }
    }

    
}
