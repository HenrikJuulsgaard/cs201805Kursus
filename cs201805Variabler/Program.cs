using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201805Variabler
{
    enum FilTyper
    {
     csv, pdf, txt
    }

    struct Person
    {
        public int Id;
        public string Navn;
    }

class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            int n = 10;
            ++n;
            --n;
            n += 20;
            Console.WriteLine(n.ToString());

            // Opgave 2
            double n1 = 12.5;
            ++n1;
            --n1;
            n1 *=2;
            Console.WriteLine(n1.ToString());

            // Opgave 3
            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft.ToString());
            Console.WriteLine((int)ft);

            // Opgave 4
            DateTime dt;
            dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));

            // Opgave 5
            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn.ToString());






            Console.ReadLine();
        }
    }
}
