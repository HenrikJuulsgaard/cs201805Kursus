using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs201805stackHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opret variabel
            Person K1 = new Person();
            Person K2 = new Person();

            // Sæt værdi
            K1.navn = "a";
            K2.navn = "b";

            Console.WriteLine(" opgave 1: " + K1.navn);
            Console.WriteLine(" opgave 1: " + K2.navn);

            K1 = K2;

            Console.WriteLine(" opgave 2: " + K1.navn);
            Console.WriteLine(" opgave 2: " + K2.navn);

            K1.navn = "c";  // Hvorfor er det lige meget om det er K1 eller K2 der refereres til?

            Console.WriteLine(" opgave 3: " + K1.navn);
            Console.WriteLine(" opgave 3: " + K2.navn);

            Console.Read();
        }
    }
    class Person
    {
        public string navn;
    }
}
