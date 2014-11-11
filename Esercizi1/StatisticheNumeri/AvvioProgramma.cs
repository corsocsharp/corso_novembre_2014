using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace StatisticheNumeri
{
    class AvvioProgramma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            Console.Write("> ");
            string testo = Console.ReadLine();

            int numero = Convert.ToInt32(testo);

            Console.WriteLine("Numero: " + numero);

            int doppio = numero *2;
            Console.WriteLine("Doppio: " + doppio);

            int quadrato = numero * numero;
            Console.WriteLine("Quadrato: " + quadrato);

            // calcolo pari/dispari con modulo
            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero pari");
            }else {
                Console.WriteLine("Numero dispari");
            }
            

            // altra modalità di calcolo del pari/dispari
            int numCalcolato = (numero / 2) * 2;

            if (numero== numCalcolato)
            {
                Console.WriteLine("Numero pari");
            }
            else
            {
                Console.WriteLine("Numero dispari");
            }

            Console.ReadKey();
        }
    }

    
}
