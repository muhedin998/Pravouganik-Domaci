using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravougaonik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite duzinu pravougaonika: ");
            int duzina = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite visina pravougaonika: ");
            int visina = int.Parse(Console.ReadLine());
            for (int i = 1; i <= duzina; i++)//Gornja stranica
            {
                    Console.Write("+");
            }
            for(int k=0;k<=visina-2;k++)//Sredina
            {
                Console.Write("+");
                for (int j = 0; j <= duzina - 2; j++)
                    Console.Write(" ");
                Console.Write("+");
                Console.Write("\n");
            }
            for (int i = 1; i <= duzina; i++)//Donja stranica
            {
                Console.Write("+");
            }

            Console.ReadKey();
        }
    }
}
