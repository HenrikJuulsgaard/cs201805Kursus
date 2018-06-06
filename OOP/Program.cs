using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Mikkel", "Hansen", 8);
            Console.WriteLine(p1.Fornavn + " " + p1.Efternavn);

            Person p2 = new Person();
            p2.Fødselsår = 1969;
            p2.Fornavn = "Karsten";
            p2.Efternavn = "Jensen";
            Console.WriteLine(p2.Fornavn);
            Console.WriteLine(p2.Efternavn);
            Console.WriteLine(p2.Fødselsår.ToString());
            Console.WriteLine(p2.Alder().ToString());
            Console.WriteLine(p1.FuldtNavn());

            Console.Read();
        }
        public class Person {
            // Variabler
            public String Fornavn;
            public String Efternavn;
            public int Fødselsår;
            // Metode
            public string FuldtNavn()
            {
                return (this.Fornavn + " " + this.Efternavn);
            }
            // Metode
            public int Alder()
            {
               return (System.DateTime.Now.Year - this.Fødselsår);
            }
            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";
            }
            public Person(string Fornavn, string Efternavn, int Fødselsår)
            {
                this.Fornavn = Fornavn.ToUpper();
                this.Efternavn = Efternavn.ToUpper();
                if (this.Fødselsår == 0)
                {
                    this.Fødselsår = 1970;
                }
            }
        }
        public class Bil { }
    }
}
