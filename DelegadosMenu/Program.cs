using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosMenu
{
    class Program
    {
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }
        static void Main(string[] args)
        {
            DelegaAll delegaAll = new DelegaAll();
            delegaAll.MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
            new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();
        }

    }
}
