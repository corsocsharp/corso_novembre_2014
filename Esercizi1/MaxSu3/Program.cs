using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSu3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = LeggiNumero("Inserisci il primo numero");
            double numero2 = LeggiNumero("Inserisci il secondo numero");
            double numero3 = LeggiNumero("Inserisci il terzo numero");

            //double numMax = numero1;
            //if (numero2 > numMax) {
            //    numMax = numero2;
            //}

            //if (numero3 > numMax) {
            //    numMax = numero3;
            //}

            double numMax = Max(numero1, numero2);
            numMax = Max(numMax, numero3);

            //double numMax = Math.Max(numero1, numero2);
            //numMax = Math.Max(numMax, numero3);

            //double numMax = Max(Max(numero1, numero2), numero3);

            Console.WriteLine("Il massimo è " + numMax);
            Console.ReadKey();

        }

        /// <summary>
        /// Legge un numero dalla console
        /// </summary>
        /// <param name="messaggio">messaggio visualizzato all'utente</param>
        /// <returns></returns>
        private static double LeggiNumero(string messaggio)
        {
            Console.WriteLine(messaggio);
            Console.Write("> ");
            string testo = Console.ReadLine();
            return Convert.ToDouble(testo);
        }

        /// <summary>
        /// Trova il massimo tra 2 numeri
        /// </summary>
        static double Max(double val1, double val2)
        {

            if (val1 > val2)
            {
                return val1;
            }

            return val2;
        }
    }
}
