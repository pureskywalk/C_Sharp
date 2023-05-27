using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("笔记本型号");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();

            Console.ReadKey();

            
        }
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo": nb = new Lenovo();
                    break;
                case "IBM": nb = new IBM();
                    break;
                case "Acer": nb = new Acer();
                    break;
                case "Dell": nb = new Dell();
                    break;
                default:
                    break;
            }

            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("联想笔记本");
        }
    }

    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("鸿基笔记本");
        }
    }

    public class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("戴尔笔记本");
        }
    }

    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("IBM笔记本");
        }
    }

}
