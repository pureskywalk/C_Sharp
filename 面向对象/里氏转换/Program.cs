using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //子类对象可以赋值给父类对象，如果有一个地方需要一个父类作为对象，我们可以给一个子类代替
            //Student s = new Student();
            Person p = new Student();

            //string str = string.Join("|",new string[]{"1","2","3","4","5"});
            //Console.WriteLine(str);
            //Console.ReadKey();

            //如果父类中装的是子类对象，我们可以将这个父类强转为子类对象
            //Student ss = (Student)p;
            //ss.StudentSayHello();

            //is的用法
            if (p is Student)
            {
                Student ss = (Student)p;
                ss.StudentSayHello();
            }
            else
            {
                Console.WriteLine("转换失败");
            }

            //as的用法
            Student t = p as Student;
            t.StudentSayHello();
            Console.ReadKey();


        }
    }

    public class Person
    {
        public void PersinSayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Teacher
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
