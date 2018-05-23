using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGroundApp
{
    struct Person
    {
        public string Navn;
        public int Alder;
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            // Write text to file
            string text = "Min første tekst";
            File.WriteAllText("C:\\Temp\\data.txt", text);

            Console.WriteLine(text);

            // **Hint** Standard heltal er INT
            Console.WriteLine(int.MaxValue);
            // **Hint** Standard komma tal er double
            Console.WriteLine(double.MaxValue);
            // **Hint** Standard tid og dato  ( Git csharp-format codes )
            DateTime da;
            da = DateTime.Now;
            Console.WriteLine(da.ToString("yyyy-MM"));

            // Iso norm 
            Console.WriteLine(da.ToString("s"));

            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2018, 12, 24);

            TimeSpan ts = d2.Subtract(d1);

            Console.WriteLine(ts.TotalDays.ToString());
            Console.ReadLine();

        }
    }
}
