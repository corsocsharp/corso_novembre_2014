using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticheNumeri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int>();

            while (true) {
                string testo = LeggiTesto("Inserisci un numero");
             
                if (String.IsNullOrEmpty(testo)) break;

                int valore = Convert.ToInt32(testo);

                //if (valore == 0) break;

                numeri.Add(valore);
            }

            //int min = numeri[0];
            //int max = numeri[0];
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int numPositivi = 0;
            double somma = 0;

            foreach (int valore in numeri) {
                
                somma += valore;

                if (valore > 0) numPositivi++;

                if (valore > max) max = valore;

                if (valore < min) min = valore;
            }

            double media = somma / numeri.Count;

            Console.WriteLine("Numeri: " + numeri.Count);
            Console.WriteLine("Somma: " + somma);
            Console.WriteLine("Media: " + media);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);

            Console.ReadKey();
        }

        private static string LeggiTesto(string messaggio)
        {
            Console.WriteLine(messaggio);
            Console.Write("> ");
            string testo = Console.ReadLine();
            return testo;
        }
    }
}
