using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201805DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {   // Opgave 1
            DateTime d1;
            d1 = DateTime.Now;

            Console.WriteLine(d1.ToString());

            // Opgave 2
            d1 = d1.AddDays(10);
            Console.WriteLine(d1.ToString());

            // Opgave 3
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1.ToString());

            // Opgave 4
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1.ToString());

            // Opgave 5
            DateTime d2 = DateTime.Now;
            DateTime d3 = DateTime.Now;
            TimeSpan t1 = new TimeSpan(0, 0, 0);
            TimeSpan t2 = new TimeSpan(16, 0, 0);
            TimeSpan t3 = new TimeSpan(0, 30, 0);
            TimeSpan t4 = new TimeSpan(0, 0, 0);
            TimeSpan t5 = new TimeSpan(0, 0, 0);

            d3 = d3.AddHours(1);
            t1 = d2.Subtract(d3);
            t4 = t2.Subtract(t3);
            t5 = t2.Add(t3);

            Console.WriteLine("t1:  " + t1.ToString());
            Console.WriteLine("t2:  " + t2.ToString());
            Console.WriteLine("t3:  " + t3.ToString());
            Console.WriteLine("t4:  " + t4.ToString());
            Console.WriteLine("t5:  " + t5.ToString());






            Console.Read();
        }
    }
}
