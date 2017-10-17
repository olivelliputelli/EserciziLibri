using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            FOR_2_Es1();
        }

        /// <summary>
        /// Visualizzare sullo schermo i primi N numeri naturali, con N letto da tastiera. 
        /// es.N: 4 output: I primi 4 numeri naturali sono: 0, 1, 2, 3.
        /// </summary>
        static void FOR_2_Es1()
        {
            Console.WriteLine("*** ES. 1 ***");
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

        static void FOR_2_ES3()
        {

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




        /// <summary>
        /// Fattoriale
        /// </summary>
        static void FOR_3_Es6()
        {
            Console.WriteLine("*** ES. 1 ***");
            //Console.Write("Numero da calcolare il fattoriale: ");
            //int n = int.Parse(Console.ReadLine());
            for (int n = 1; ; n++)
            {
                long fattoriale = 1;

                for (int i = 1; i <= n; i++)
                {
                    fattoriale *= i;
                }
                if (fattoriale < 0)
                    break;
                Console.WriteLine($"{n}! = {fattoriale:N0}");
            }

        }


    }
}
