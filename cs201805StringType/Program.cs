using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201805StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn;

            samletNavn = fornavn +" " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            // Opgave 2 
            string[] Person = samletNavn.Split();

            for (int i = 0; i < Person.Length; i++)
            {
                Console.WriteLine(Person[i] + "\n" );
                File.AppendAllText(@"C:\temp\Navn.txt", Person[i] );
            }

            File.AppendAllText(@"C:\temp\Navn.txt", samletNavn + "\n" );


            Console.Read();
        }

    }
}
