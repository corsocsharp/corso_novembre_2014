using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EserciziVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dati = new List<string>();

            //bool continua = true;
            //while (continua) {
            //    string testo = LeggiTesto("Inserisci un testo");
            //    if (testo == "")
            //    {
            //        continua = false;
            //    }
            //    else {
            //        dati.Add(testo);
            //    }
            //}


            //string testo1;
            //do{
            //    testo1 =  LeggiTesto("Inserisci un testo");
            //    if (testo1 != "") {
            //        dati.Add(testo1);
            //    }
            //}while(testo1 != "");


            while (true) {
                string testo2 = LeggiTesto("Inserisci un testo");

                if (String.IsNullOrEmpty(testo2)){
                    break;
                }
                
                dati.Add(testo2);
            }

            int lungMax = 0;
            string maxString = "";
            foreach (string testo in dati)
            {
                if (testo.Length > lungMax)
                {
                    lungMax = testo.Length;
                    maxString = testo;
                }
            }

            Console.WriteLine("Testo di lungh. massima: '{0}' ( {1} ) ",
                        maxString, lungMax);



            Console.ReadKey();
        }

        private static void ElaboraNumeroParametriFisso()
        {
            string[] dati = new string[3];

            for (int i = 0; i < dati.Length; i++)
            {
                dati[i] = LeggiTesto("Inserisci un testo");
            }


            int lungMax = 0;
            string maxString = "";
            foreach (string testo in dati)
            {
                if (testo.Length > lungMax)
                {
                    lungMax = testo.Length;
                    maxString = testo;
                }
            }

            //Console.WriteLine("Testo di lunghezza massima: '"
            //        + maxString + "' (" + lungMax + ")");

            //string output =
            //    String.Format("Testo di lungh. massima: '{0}' ( {1} ) ",
            //            maxString, lungMax);
            //Console.WriteLine(output);

            Console.WriteLine("Testo di lungh. massima: '{0}' ( {1} ) ",
                        maxString, lungMax);
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
