using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建类的对象
            Person suQuan = new Person("孙权",18,'男');
            suQuan.CHLSS();
            Ticket ticket = new Ticket(600);
            ticket.ShowTicket();
            Console.ReadKey();
        }
    }
}
