using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)  
        {
           
            int numero = LeggiNumero("Inserisci un primo valore");
            int numero2 = LeggiNumero("Inserisci un secondo valore");

            if (numero > numero2)
            {
                Console.WriteLine("Il numero maggiore è " + numero);
            }else{

                if (numero < numero2)
                {
                    Console.WriteLine("Il numero maggiore è " + numero2);
                }else {
                    Console.WriteLine("I numeri sono uguali");
                }
            }


            //Console.WriteLine("hai scritto: " + numero + " e " + numero2);
            
            Console.ReadKey();
        }

        private static int LeggiNumero(string messaggio)
        {
            string text;

            Console.WriteLine(messaggio);
            text = Console.ReadLine();
            
            int numero = Convert.ToInt32(text);

            return numero;
        }



        static void Esempi1() {
            Console.WriteLine("Ciao!!!");

            int i = 1;
            i = i * 2;

            int valInt = 10;
            long valLong = 10;
            uint valPosInt = 40;

            // coordinate
            float valDec1 = 10.3F;
            double valDec2 = 10.3;

            // valute
            decimal valDecFix = 4.3M;


            bool flag = true;
            flag = false;

            char c = 'c';

            byte b = 0;
            b = 0x00; // esadecimale

            string nome = "Pippo";

            nome = Convert.ToString(valInt);

            int val2 = Convert.ToInt32("124");


            string nomeCompleto = nome + " Pluto";

            string label = "Coordinate: " + valDec1;

            //i = 5 / (i - 2);
        }
    }
}
