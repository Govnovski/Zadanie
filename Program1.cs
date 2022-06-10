using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10] { 2, 12, 18, 10, 17, 20, 0, 6, 15, 25};
            string[] group = new string[10] { "A", "B", "C","D","E","F","G","I","J","K" };
            int n  ;
            string b;
            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10 ; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        
                        
                            n = mass[i];
                            mass[i] = mass[j];
                            mass[j] = n;

                            b = group [i];
                            group[i] = group[j];
                            group[j] = b;

                    }
                   
                }
            }
            for(int m=0;m<10;m++)
            {
                if (mass[m]>0)
                {
                    Console.WriteLine(group[m]+ " = "+ mass[m]);
                }
            }
            Console.ReadKey();
        }
    }
}
