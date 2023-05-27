using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象
{
    public class Person
    {
        //字段 属性 方法 构造函数
        //字段：存储数据
        //属性：保护字段，对字段的取值和设值进行限定
        //方法：描述对象的行为
        //构造函数：初始化对象（给对象的每个属性进行赋值）

        //创建对象时首先执行的是构造函数
        public Person(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        //构造函数的调用与重载
        public Person(string name, int age) : this(name, age, 'a')//'a'没有用到，随意给定
        {
 
        }

        //析构函数
        //当程序结束时，析构函数才执行，用于帮助我们释放资源
        //GC garbage collection可以自动帮助我们释放资源，不一定能全部释放
        ~Person()
        {

        }

        string _name;
        public string Name
        {
            //当你输出属性的值的时候，会执行get方法
            get { return _name;}
            //当你给属性赋值时，首先执行set方法
            set { _name = value; }
        }

       

        int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                
                _age = value; }
        }

        char _gender;
        public char Gender
        {
            get {
                if (_gender != '男' &&  _gender != '女')
                {
                    return _gender = '男';
                }
                
                return _gender; }
            set { _gender = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁，我是{2}生，我可以吃喝拉撒睡",this.Name,this.Age,this.Gender);
        }
    }
}
