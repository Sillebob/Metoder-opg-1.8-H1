using System;
using System.Collections.Generic;

namespace Metoder_opg_1._8_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lav liste bestående af de lige tal fra 1-20:

            List<int> listeB = new List<int>(); //oprettelse af liste med default værdi

            FyldListeLigeTal(listeB, 1, 20); //Metodekald til at fylde de lige tal ind i listen
            Udskrift(listeB);
            TomLinje();

            //Fjern alle tal som 3 går op i:

            DeleligtMedTre(listeB, 3); //Metodekald til at finde de tal der skal slettes
            TomLinje();
            
            listeB.Remove(6);
            listeB.Remove(12);
            listeB.Remove(18);
            
            Udskrift(listeB); //for at tjekke
            TomLinje();

            // Hvor mange elementer er der nu i listen?
            Console.WriteLine(listeB.Count);

            TomLinje();

            //Indsæt værdien 17 på plads nr. 3 (index 2)

            listeB[2] = 17; /* OBS kan ikke bruge listeB.Insert(2, 17); da der allerede er en værdi på 3. plads så
                             * den indsætter en ekstra værdi og skubber de andre */

            Udskrift(listeB); //for at tjekke
            TomLinje();

            //Lav en ny liste der består af listeB's elementer men i omvendt rækkefølge
            List<int> listeNy = new List<int>(listeB);

            listeNy.Reverse();
            Udskrift(listeNy);
                    
            Console.ReadKey();//fastholder programmet indtil brugeren trykker på en tast
        }
        //Opretter metoder til tom linje
        public static void TomLinje()
        {
            Console.WriteLine();
            
        }
        //Opretter metode til udskrift
        public static void Udskrift(List<int> listenavn)
        {
            foreach (int i in listenavn)
            {
                Console.WriteLine(i);
            }

        }
        //Opretter metode til at indsætte værdier
        public static void FyldListeLigeTal(List<int> listenavn, int min, int max)
        {
            for (int i = min; i <= max; i++)//Indsætter værdier
            {
                if (i % 2 == 0) //Tjekker om et tal er lige
                {
                    listenavn.Add(i); //tilføjer det til listen hvis det er lige
                }
            }

        }
        //Opretter metode der finder værdierne som 3 går op i
        public static void DeleligtMedTre(List<int> listenavn, int talDerSkalGåOpI)
        {
            List<int> opbevaring = new List<int>();//opretter en liste til at indeholde de indexer tallene 3 går op i befinder sig på
            int listenslængde = listenavn.Count;           
            for (int i = 0; i < listenslængde; i++)
            {
                if (listenavn[i] % talDerSkalGåOpI == 0)
                {
                    int talDerSkalFjernes = listenavn[i];//Her fanger den de tal 3 går op i dvs 6, 12, 18
                    Console.WriteLine(talDerSkalFjernes); //Udskriver tallene så man kan se hvilke tal man manuelt skal fjerne
                    int talletsPosition = listenavn.IndexOf(talDerSkalFjernes); // Her fortæller den på hvilken plads de befinder sig 
                    opbevaring.Add(talDerSkalFjernes);//Tilføjer de tal 3 går op i til en liste

                }
            }
        }
    }
   
}