using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("3");
            c = int.Parse(Console.ReadLine());
            int[] mass = new int[3];
            mass[0] = a;
            mass[1] = b;
            mass[2] = c;
            int max = mass.Max();
            Console.WriteLine("наибольшее " + max);

            switch (max%2)
            {
                case 0:
                    Console.WriteLine("чётное" + max); 
                        break;
                case 1:
                    Console.WriteLine("нечётное" + max);
                    break;
                default:
                    break;
            }
            var s = max < 100 ? "menshe" : "bolshe";
            Console.WriteLine(s);
            Console.ReadKey();
        }  
    }
}
