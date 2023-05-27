using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zsStudent = new Student("张三",18,'男',100,100,100);
            zsStudent.SayHello();
            zsStudent.ShowScore();



        }
    }
}
