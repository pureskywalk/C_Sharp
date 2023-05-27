using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 部分类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public partial class Person//部分类
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public partial class Person
    {
        public void Test()
        {
            _name = "张三";
        }
    }
}
