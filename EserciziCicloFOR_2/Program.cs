using System;

namespace EserciziCicloFOR_2
{
    class Program
    {
        static void Main()
        {
            //FOR_2_Es1();
            FOR_2_Es2();
            //FOR_2_ES3();
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
                output += i + ", ";
            }
            output += "\b\b.";
            Console.WriteLine(output);
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
            int da1a3;
            string pronostico = "X";

            for (int i = 1; i <= numeroDiPartite; i++)
            {
                da1a3 = generatoreNumeriCasuali.Next(0, 3);
                pronostico = (da1a3 == 0) ? "X" : da1a3.ToString();
                Console.WriteLine($"Partita numero {i}:\t{pronostico}");
            }
        }

    }
}
