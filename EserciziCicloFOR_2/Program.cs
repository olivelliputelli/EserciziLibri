using System;

namespace EserciziCicloFOR_2
{
    class Program
    {
        static void Main()
        {
            //FOR_2_Es1();
            //FOR_2_Es2();
            //FOR_2_ES3();
            FOR_2_Es7();
            //FOR_2_Es8();
            //FOR_2_Es11();
        }

        /// <summary>
        /// Visualizzare sullo schermo i primi N numeri naturali, con N letto da tastiera. 
        /// es.N: 4 output: I primi 4 numeri naturali sono: 0, 1, 2, 3.
        /// </summary>
        static void FOR_2_Es1()
        {
            Console.WriteLine("*** FOR-2 ES. 1 ***");
            Console.Write("Numero di numeri naturali da visualizzare: ");
            int numeroDiNumeriNaturali = int.Parse(Console.ReadLine());

            string output = $"I primi {numeroDiNumeriNaturali} numeri naturali sono: ";
            for (int i = 0; i < numeroDiNumeriNaturali; i++)
            {
                output += i + ", ";
            }
            output += "\b\b.";
            Console.WriteLine(output);
        }

        /// <summary>
        /// Visualizzare sullo schermo i primi N numeri naturali, 
        /// con N letto da tastiera IN ORDINE INVERSO. (programma e flow-chart)
        /// </summary>
        static void FOR_2_Es2()
        {
            Console.WriteLine("*** FOR-2 ES. 2 ***");
            Console.Write("Estremo superiore: ");
            int estremoSuperiore = int.Parse(Console.ReadLine());

            string output = $"Numeri naturali da {estremoSuperiore} a 0: ";
            for (int i = estremoSuperiore; i >= 0; i--)
                output += i + ", ";
            output += "\b\b.";

            Console.WriteLine(output);
        }

        /// <summary>
        /// Visualizzare sullo schermo i numeri pari da 1 a  N , con N letto da tastiera.
        /// </summary>
        static void FOR_2_ES3()
        {
            Console.WriteLine("*** FOR-2 ES. 3 ***");
            Console.Write("Estremo superiore: ");
            int estremoSuperiore = int.Parse(Console.ReadLine());

            string output = $"Numeri pari da 1 a {estremoSuperiore}: ";
            for (int i = 2; i <= estremoSuperiore; i += 2)
            {
                output += i + ", "; // output = output + i + ", ";
            }
            output += "\b\b.";
            Console.WriteLine(output);
        }

        /// <summary>
        /// Siano inseriti da tastiera due numeri: N1 e N2. 
        /// Stampare i numeri da 1 al maggiore tra N1 e N2. 
        /// Ad esempio se N1=5 e N2=8 devono essere stampati i numeri da 1 a 8 
        /// (infatti 8 è il maggiore tra i due numeri che si immagina essere stati inseriti); 
        /// se invece N1=6 e N2=5 allora devono essere stampati i numeri da 1 a 6. 
        /// Risolvi l’esercizio prima con il for  e poi con il do … while.
        /// </summary>
        static void FOR_2_Es7()
        {
            int n1, n2;
            Console.WriteLine("*** FOR-2 ES. 7 ***");
            Console.Write("N1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("N2: ");
            n2 = int.Parse(Console.ReadLine());

            string outputFor = "Con il For: ";
            for (int i = 1; i <= Math.Max(n1,n2); i++)
            {
                outputFor += i + ", ";
            }
            outputFor += "\b\b.";

            string outputDoWhile = "Con il Do While: ";
            int j = 1;
            do
            {
                outputDoWhile += j + ", ";
                j++;
            } while (j <= Math.Max(n1, n2));
            outputDoWhile += "\b\b.";

            Console.WriteLine(outputFor);
            Console.WriteLine(outputDoWhile);
        }

        /// <summary>
        /// Generare e visualizzare una sequenza di 1000 numeri casuali.  
        /// </summary>
        static void FOR_2_Es8()
        {
            Console.WriteLine("*** FOR-2 ES. 8 ***");
            Random generatoreNumeriCasuali = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(generatoreNumeriCasuali.Next(0,9)+", ");
            }
            Console.WriteLine("\b\b.");
        }

        /// <summary>
        /// Generare e visualizzare una sequenza casuale corrispondente ad 
        /// una colonna di una schedina di calcio.
        /// </summary>
        static void FOR_2_Es11()
        {
            Random generatoreNumeriCasuali = new Random();

            Console.WriteLine("*** ES. 11 ***");
            Console.Write("Numero di partite: ");
            int numeroDiPartite = int.Parse(Console.ReadLine());
            int da0a2;
            string pronostico = "";

            for (int i = 1; i <= numeroDiPartite; i++)
            {
                da0a2 = generatoreNumeriCasuali.Next(0, 3);
                pronostico = (da0a2 == 0) ? "X" : da0a2.ToString();
                Console.WriteLine($"Partita numero {i}:\t{pronostico}");
            }
        }    
    }
}
