using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Variabler_Och_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resetidtimmar = 7;
            int resetidminut = 25;
            int tidszonskillnad = 6;

            int stockholmavgångstidtimme = 14;
            int stockholmavgångstidminut = 03;
            int newyorkavgångstidtimme = 10;
            int newyorkavgångstidminut = 10;

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


            if (val == "1")
            {
                Console.WriteLine("\nDu har valt flyg från Stockholm till New York.\n");

                // Beräkna ankomsttid
                int ankomststimme = stockholmavgångstidtimme + resetidtimmar - tidszonskillnad;
                int ankomstsminut = stockholmavgångstidminut + resetidminut;

                // Justera för minuter som överstiger 60
                if (ankomstsminut >= 60)
                {
                    ankomstsminut -= 60;
                    ankomststimme += 1;
                }

                // Justera för timmar som överstiger 24
                if (ankomststimme >= 24)
                {
                    ankomststimme -= 24;
                }

                // Skriv ut resultat
                Console.WriteLine($"Avgångstid från Stockholm: {stockholmavgångstidtimme.ToString("00")}:{stockholmavgångstidminut.ToString("00")}");
                Console.WriteLine($"Ankomsttid till New York: {ankomststimme.ToString("00")}:{ankomstsminut.ToString("00")}");
               
            }

           
            else if (val == "2")
            {
               Console.WriteLine("\nDu har valt flyg från New York till Stockholm\n");

                int ankomststimme = newyorkavgångstidtimme + resetidtimmar + tidszonskillnad;
                int ankomstsminut = newyorkavgångstidminut + resetidminut;

                // Justera för minuter som överstiger 60
                if (ankomstsminut >= 60)
                {
                    ankomstsminut -= 60;
                    ankomststimme += 1;
                }

                // Justera för timmar som överstiger 24
                if (ankomststimme >= 24)
                {
                    ankomststimme -= 24;
                }

                Console.WriteLine($"Avgångstid från New York: {newyorkavgångstidtimme.ToString("00")}:{stockholmavgångstidminut.ToString("00")}");
                Console.WriteLine($"Ankomsttid till Stockholm: {ankomststimme.ToString("00")}:{ankomstsminut.ToString("00")}");
            }


            else if (val == "3")
            {
                Console.WriteLine("Du har valt att avsluta programmet.");
            }
            else {
                Console.WriteLine("Det valet finns inte.");
                    }
            Console.WriteLine("Nu kommer programmet att stängas ner. Tack för att du använde programmet.(Tryck Enter)");
            Console.ReadLine();
            
        }
    }
}
