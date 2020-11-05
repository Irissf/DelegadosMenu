using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosMenu
{
    delegate void MyDelegate();
    class DelegaAll
    {
        public void MenuGenerator(string[] nameOptions, MyDelegate[] menuFunctions)
        {
            int option = 0;
            int final = nameOptions.Length + 1;//si array tiene 3, es 4 por salida
            string exitName = "Exit";
            if (nameOptions.Length == menuFunctions.Length)
            {
                do
                {
                    Console.WriteLine("Choose an option, please:");

                    for (int i = 0; i < nameOptions.Length; i++)
                    {
                        Console.WriteLine("{0}{1,5}", i + 1, nameOptions[i]);
                    }

                    Console.WriteLine("{0}{1,5}", final, exitName);
                    try
                    {
                        option = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Must be a number!");
                    }

                    try
                    {
                        if (option != final)
                        {
                            menuFunctions[option - 1].Invoke();
                        }
                        else
                        {
                            Console.WriteLine("Goodbye!");
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid option");
                    }
                    

                } while (option != final);
            }
            else
            {
                Console.WriteLine("Invalid menu");
            }

        }
    }
}
