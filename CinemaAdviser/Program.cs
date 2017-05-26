using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Помощник по выбору фильма");
            Console.WriteLine("Enter your name, pls");
            String name = Console.ReadLine();
            int name1 = int.Parse(name);
            if (name1 < 18)
            {
                Console.WriteLine(name1);
            }

            Console.WriteLine("Hi, " + name);
        }
    }
}
