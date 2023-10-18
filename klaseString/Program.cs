using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Danaska delamo z klason string.";

            Console.WriteLine(tekst);

            Console.WriteLine("Broj znakova u rečenici je " + tekst.Length);

            Console.WriteLine("Velikim slovima: " + tekst.ToUpper());

            Console.WriteLine("Malim slovima: " + tekst.ToLower());

            Console.WriteLine("\n-- Metoda substring --");

            Console.WriteLine(tekst.Substring(0, 7));

            Console.WriteLine(tekst.Substring(14, tekst.Length - 14));

            Console.WriteLine("\n-- Zamjena znakova --");

            Console.WriteLine(tekst.Replace("Danaska", "Sutra"));

            Console.WriteLine("\n-- Razdvajanje --");

            string[] rijeci = tekst.Split(' ');

            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }

            foreach (string rijec in rijeci)
            {
                Console.WriteLine("rijec");
            }

            Console.WriteLine("\n-- Umetanje znakova --");

            Console.WriteLine(tekst.IndexOf("delamo"));

            Console.WriteLine(tekst.Insert(tekst.IndexOf("delamo"), "intenzivno "));

            Console.ReadKey();
        }
    }
}
