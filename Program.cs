using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hussein
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 120; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n\n");
            Console.WriteLine("Välkommen till flygtidsberäknaren");
            Console.Write("\n\n");
            Console.WriteLine("Vilket flyg vill du se detaljerad information om? (svara med siffra)");
            Console.WriteLine("1.Stockholm - New York");
            Console.WriteLine("2.New York - Stockholm");
            Console.WriteLine("3.Avsluta programmet:");
            Console.Write("Skriv ditt val här:");
            string val = Console.ReadLine();

           switch (val) 
           { 
            
                case "1":
                    Console.WriteLine("\nDu har valt stockholm - New york");
                    break;                    
                case "2":                 
                    Console.WriteLine("\nDu har valt New yourk - Stockholm");
                    break;
                case "3":
                    Console.WriteLine("\nProgrammet avslutas. Tack för att du använde flygtidsberäknaren!");
                    break;
                default:
                    Console.WriteLine("\nOgiltigt val. Vänligen försök igen.");
                    break;

           }

        }
    }
}
