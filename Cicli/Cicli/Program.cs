using System;
using System.Collections.Generic;
using System.Text;

namespace Cicli
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> stringhe = new List<string>();

            stringhe.Add("ciao");
            stringhe.Add("come");
            stringhe.Add("stai");

            stringhe[2] = "stai?";

            //for (int i = 0; i < stringhe.Count; i++) {
            //    Console.WriteLine(" > " + stringhe[i]);
            //}

            stringhe.Remove("come");
            stringhe.RemoveAt(1);


            List<int> valori = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //valori.RemoveAll(VerificaPari);

            //valori.RemoveAll(
            //    elem => elem % 2 == 0
            //);
            valori[0] = 10;

            valori.Insert(0, 10);

            Console.WriteLine("foreach");

            foreach (int val in valori) {
                Console.WriteLine(" > " + val);
            }

            
            for(int i = 0; i < valori.Count;  i++){
                int val = valori[i];


            }


            Console.ReadKey();

        }

        static bool VerificaPari(int elem) {
            return elem % 2 == 0;
        }

        private static void Vettori()
        {
            int lunghezzaMax = 10;

            int[] valori = new int[lunghezzaMax];

            for (int i = 0; i < valori.Length; i++)
            {
                valori[i] = i * i;
            }


            int[] altriVal;

            altriVal = new int[]{ 
                3,4,5,7,23,77,343,77,33
            };

            string[] altriVal2 = { 
                "dsf","sdf","asdf","dvxbc"
            };

            object[] v = {
                1,true,"asdfas",9.33             
            };

            StampaArray(v);
        }

        private static void StampaArray(object[] array)
        {
            Console.WriteLine("Array con dimensione: " + array.Length);
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(" [" + i + "] => " + array[i]);
            }
        }

        private static void Cicli()
        {
            int i = 0;
            while (i < 20)
            {
                Console.WriteLine("Numero: " + i);

                i = i + 1;
                //i += 1;
            }

            for (i = 0; i < 33; i++)
            {
                Console.WriteLine("> " + i);
            }
        }
    }
}
