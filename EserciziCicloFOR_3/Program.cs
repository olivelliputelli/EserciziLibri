using System;

namespace EserciziCicloFOR_3
{
    class Program
    {
        static void Main()
        {
            FOR_3_Es3();
            //FOR_3_Es5();
            //FOR_3_Es6();
        }

        /// <summary>
        /// Chiedere 2 numeri interi (a,b) e disegnare un 
        /// rettangolo pieno di dimensioni a*b usando il carattere  " * ". 
        /// </summary>
        static void FOR_3_Es3()
        {
            int @base, altezza;
            Console.WriteLine("*** FOR-3 ES. 3 ***");
            Console.Write("Base: ");
            @base = int.Parse(Console.ReadLine());
            Console.Write("Altezza: ");
            altezza = int.Parse(Console.ReadLine());

            for (int r = 0; r < altezza; r++)
            {
                for (int c = 0; c < @base; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Descrivi un algoritmo con il ciclo for che riceve in 
        /// ingresso un numero e ne calcola la sua 
        /// potenza n-esima sempre con n inserito da tastiera. (flow-chart e programma)
        /// </summary>
        static void FOR_3_Es5()
        {
            Console.WriteLine("*** FOR-3 ES. 5 ***");
            Console.Write("Numero (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Potenza (m): ");
            int m = int.Parse(Console.ReadLine());

            int potenza = 1;

            for (int i = 1; i <= m; i++)
                potenza *= n;

            Console.WriteLine($"{n}^{m} = {potenza}");
        }

        /// <summary>
        /// Fattoriale n!
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
