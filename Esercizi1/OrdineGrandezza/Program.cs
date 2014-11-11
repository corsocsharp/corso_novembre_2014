using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdineGrandezza
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = LeggiNumero("Inserisci un numero");

            if (numero < 100) {
                Console.WriteLine("=> decine");
            }

            if (numero < 1000 && numero >= 100)
            {
                Console.WriteLine("=> centinaia");
            }

            // if (numero >= 1000)
            if (! (numero < 1000) )
            {
                Console.WriteLine("=> migliaia");
            }


            Console.ReadKey();
        }

        private static int LeggiNumero(string messaggio)
        {
            Console.WriteLine(messaggio);
            Console.Write("> ");
            string testo = Console.ReadLine();
            return Convert.ToInt32(testo);
        }
    }
}
