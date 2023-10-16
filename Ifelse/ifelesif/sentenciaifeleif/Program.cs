using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentenciaifeleif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa qe clasifica un numero como negativo, cero o positivo

            int numero = 900;

            if (numero < 0)
            {
                Console.WriteLine("numero negativo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Numero es cero");
            }
            else
            { 
                Console.WriteLine("Numero positivo");
            }

            //Programa que clasifica un numero como multiplo de 3 y 5 o de uno de los dos o de ninguno

            int numero1 = 20;

            if (numero1 % 3 == 0 && numero1 % 5 == 0 )
            {
                Console.WriteLine("multiplo de ambos.");
            }
            else if  (numero1 %3 == 0 )
            {
                Console.WriteLine("es multiplo de 3");
            }
            else if (numero1 %5 == 0 )
            {
                Console.WriteLine("Es multiplo de 5");
            }
            else 
            { 
                Console.WriteLine("No es de ninguno");
            }




            Console.ReadLine();

        }
    }
}
