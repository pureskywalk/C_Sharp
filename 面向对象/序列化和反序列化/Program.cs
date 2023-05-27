using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //将p这个对象传输给对方电脑
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 30;
            //p.Gender = '男';

            //using(FileStream fsWrite = new FileStream(@"C:\Users\CONNTEK32\Desktop\new.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);//这一步包含了fsWrite.Write();
            //}

            //接受对方发送过来的二进制，反序列化对象
            Person p = new Person();
            using (FileStream fsRead = new FileStream(@"C:\Users\CONNTEK32\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }


    [Serializable]//标记为可序列化
    public class Person
    {
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
    }
}
