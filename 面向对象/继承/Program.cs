using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{

    //这个项目仅供展示，不能把多个类写在同一个地方，必须新建一个类
    class Program
    {
        static void Main(string[] args)
        {
            Teacher th = new Teacher("张三", 18, '男', 101, 7000);
            th.CHLSS();
            Console.ReadKey();
        }
    }

    public class Person
    {
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("我可以吃喝拉撒睡");
        }

    }

    public class Student : Person
    {
        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
             
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void Study()
        {
            Console.WriteLine("我会学习");
        }
    }

    public class Teacher : Student
    {
        public Teacher(string name, int age, char gender, int id, double salary)
            : base(name, age, gender, id)
        {
            this.Salary = salary;
        }

        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void Teach()
        {
            Console.WriteLine("我会教书");
        }
    }
}
