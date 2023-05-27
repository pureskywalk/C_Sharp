using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace protect访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Person
    {
        protected string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class Student : Person
    {
        public void Test()
        {
            this._name = "张三";//可以调用父类中被Protected修饰的对象
        }
    }

}
