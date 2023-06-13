using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //客户端代码
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
