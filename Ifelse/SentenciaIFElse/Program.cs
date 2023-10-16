using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciaIFElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que clasifica un numero como par o imparç
            int numero = 11;

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + "es par");
            }
            else
            {
                Console.WriteLine(numero + "es Impar");
            }


            //Programa que indica si un numero es 0 o distinto de 0
            int numero2 = 3;

            if (numero2 != 0)
            {
                Console.WriteLine(numero2 + "Es = 0");
            }
            else
            { 
            Console.WriteLine(numero2 + "Es distinto de 0");
            }


            //Programa que clasifica un numero como multiplo de 3 o no

            int numero3 = 15;

            if (numero3 % 3 == 0)
            {
                Console.WriteLine(numero3 + "Es multiplo de 3");
            }
            else
            {
                Console.WriteLine(numero3 + "No es multiplo de 3");
            }


            //Programa que apartir del salario bruto de un trabajador aplica un irpf del 15% si el salario es <1200 y un irpf del 19% si es superior

            double salario, salarioNeto;
            Console.WriteLine("Inroduzca el salario bruto: ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 1200)

            {
                salarioNeto = salario - salario * 0.15;

            }
            else
            { 
              salarioNeto = salario - salario * 0.19 ;
            }
            Console.WriteLine("Salario neto: " + salarioNeto);


           



            Console.ReadLine();
        }
    }
}
