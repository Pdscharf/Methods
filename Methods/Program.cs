using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + " " + name + "!");
            Console.WriteLine("Press enter to exit the program...");
            Console.ReadKey(true);
            Console.ReadLine();
        }
    }
}
