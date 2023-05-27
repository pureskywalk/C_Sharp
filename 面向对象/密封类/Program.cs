using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 密封类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public sealed class Person:Student//密封类不能被继承，但可以继承别人的类
    {
    }

    public class Student
    {
 
    }
}
