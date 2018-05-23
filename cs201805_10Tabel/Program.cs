using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201805_10Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string txt;
            for (int i = 1; i < 11; i++)
            {
                for (int i1 = 1; i1 < 11; i1++)
                {
                   num = i1 * i;
                    txt = num.ToString();
                    if (num > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(txt.PadLeft(4) );
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
