using System;
using System.Linq;

namespace cs201805RefVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            int[] a1 = { 10000, 20000, 15000, 20000, 30000, 15000 };
            // skriv værdier i konsol
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("Value " + i.ToString() + ":  " + a1[i]);
            }

            Console.WriteLine("Average:  " + a1.Average());
            Console.WriteLine("Minimum:  " + a1.Min());

            a1[1] *= 277;

            // Sorter og skriv i konsol
            Array.Sort(a1);
            for (int i = 0; i < a1.Length; i++)
            {
                Console.WriteLine("Value " + i.ToString() + ":  " + a1[i]);
            }

            int i1=0;
            foreach (var i in a1)
            {
                i1 = i1+1;
                Console.WriteLine("Value " + i1.ToString() + ":  " + i.ToString());
            }



            Console.Read();
        }
    }
}
