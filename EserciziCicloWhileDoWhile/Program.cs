using System;

namespace EserciziCicloWhileDoWhile
{
    class Program
    {
        static void Main()
        {
            //WHILEDOWHILE_Es1();
            WHILEDOWHILE_Es2();
            //WHILEDOWHILE_Es3();
            //WHILEDOWHILE_Es6();
            Console.WriteLine("FINE!!");
            Console.ReadLine();
        }

        /// <summary>
        /// Scrivere un programma in linguaggio C# che legga da tastiera una sequenza di 
        /// numeri positivi e ad ogni numero letto ne stampi la somma progressiva. 
        /// Il programma termina quando si introduce un numero minore o uguale a zero.
        /// </summary>
        static void WHILEDOWHILE_Es1()
        {
            int n, somma = 0;
            Console.WriteLine("*** WHILEDOWHILE ES. 1 ***");
            do
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    break;
                somma += n;
                Console.WriteLine($"out = {somma}");
            } while (n > 0);
            Console.WriteLine("Fine!");
        }

        /// <summary>
        /// Si scriva un programma in linguaggio C# che acquisisca da tastiera 
        /// una parola (cioè una stringa di caratteri priva di separatori) 
        /// e la stampi a video se e solo se tale parola è palindroma, 
        /// ossia leggibile nello stesso modo da destra a sinistra e viceversa (es. OSSESSO). 
        /// </summary>
        static void WHILEDOWHILE_Es2()
        {
            Console.WriteLine("*** WHILEDOWHILE ES. 2 ***");
            Console.Write("Inserisci parola: ");
            string parola = Console.ReadLine();

            if (IsPalindroma(parola))
                Console.WriteLine(parola);
        }
        static bool IsPalindroma(string parola)
        {
            int l = parola.Length;
            for (int i = 0; i < l / 2; i++)
                if (parola[i] != parola[l - 1 - i])
                    return false;
            return true;
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
            if (n > 0)
            {
                while (n > 127)
                    n -= 128;
                Console.WriteLine($"il numero {n} corrisponde al carattere {(char)n}");
            }
            else
            {
                Console.WriteLine($"Numero non valido!");
            }
        }

        static void WHILEDOWHILE_Es4()
        {
            int n;
            Console.WriteLine("*** WHILEDOWHILE ES. 3 ***");
        }

        /// <summary>
        /// Utilizza un ciclo while per dividere due interi attraverso sottrazioni successive, 
        /// fornendo in uscita il quoto e il resto della divisione.
        /// </summary>
        static void WHILEDOWHILE_Es6()
        {
            Console.WriteLine("*** WHILEDOWHILE ES. 6 ***");
            int dividendo, divisore;
            int resto, quoto;
            int restoPositivo, quotoPositivo, divisorePositivo;

            // input
            Console.Write("Dividendo: ");
            dividendo = int.Parse(Console.ReadLine());
            Console.Write("Divisore: ");
            divisore = int.Parse(Console.ReadLine());

            // elaborazione
            restoPositivo = Math.Abs(dividendo);
            quotoPositivo = 0;
            divisorePositivo = Math.Abs(divisore);
            while (restoPositivo >= divisorePositivo)
            {
                quotoPositivo++;
                restoPositivo -= divisorePositivo;
            }

            resto = Math.Sign(dividendo) * restoPositivo;
            quoto = Math.Sign(divisore) * Math.Sign(dividendo) * quotoPositivo;

            // output
            Console.WriteLine("Operazione\tMath\tWhile");
            Console.WriteLine($"Quoto = \t{dividendo / divisore}\t{quoto}");
            Console.WriteLine($"Resto = \t{dividendo % divisore}\t{resto}");
        }
    }
}
