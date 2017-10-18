using System;

namespace EserciziCicloWhileDoWhile
{
    class Program
    {
        static void Main()
        {
            WHILEDOWHILE_Es3();
        }

        /// <summary>
        /// Si scriva un programma in linguaggio C# che legga da tastiera un numero intero A, 
        /// lo riduca ad un valore compreso tra 0 e 127 mediante sottrazione ripetuta di un 
        /// adeguato numero di volte del valore 128 (non si utilizzi l’operatore modulo o and), 
        /// lo interpreti come caratteri ASCII e lo stampi sul video. 
        /// </summary>
        static void WHILEDOWHILE_Es3()
        {
            int n;
            Console.WriteLine("*** WHILEDOWHILE ES. 3 ***");
            Console.Write("N: ");
            n = int.Parse(Console.ReadLine());

            while (n > 127)
                n -= 128;
            Console.WriteLine($"il numero {n} corrisponde al carattere {(char)n}");
        }
    }
}
