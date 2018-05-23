using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201805_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskriv();
            Udskriv("Dette er en test");

            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);



            Console.Read();
        }

        static int LægSammen(int x, int y)
        {
            int temp;
            temp = x + y;
            return temp;
        }

        static double BeregnAreal(int radius)
        {
            return (radius * radius * System.Math.PI);
        }

        static void Udskriv(string txt = "")
        {
            Console.WriteLine(txt);
        }

        static double BeregnMoms(double Beløb, double momsPct=0.25)
        {
            return Beløb * momsPct;
        }

        static double Gennemsnit(int[] månedsløn)
        {
            return månedsløn.Average();
        }

    }
}
