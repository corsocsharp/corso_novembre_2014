using System;
using System.Collections.Generic;
using System.Text;

namespace ContaLettere
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valori = new string[3];

            for (int i = 0; i < valori.Length; i++) {

                string testo = LeggiTesto("Inserisci un valore");
                
                valori[i] = testo;
            }


            int totaleCaratteri = 0;

            for (int i = 0; i < valori.Length; i++) {
                string stringa = valori[i];
                
                totaleCaratteri = totaleCaratteri + stringa.Length;
            }

            // variante con foreach
            //foreach (string val in valori) {
            //    totaleCaratteri = totaleCaratteri + val.Length;
            //}

            Console.WriteLine("Numero totale caratteri: " + totaleCaratteri);

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
