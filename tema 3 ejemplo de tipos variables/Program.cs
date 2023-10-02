using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_3_ejemplo_de_tipos_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declararemos las variables
            byte n1;
            //Inicialiciamos una variable en este caso n1
            n1 = 10;            
            byte n2 = n1; // aqui declaramos n2 con el valor de n1



            //Declarar varias variables en la misma linea
            short num1, num2, num3;
            num1 = 9;
            num2 = 10;
            num3 = 5;


            //Podemos modiicar el valor de una variable, por que no es una constante no es un valor fijo es decir, sumarle o restarle un numer
            int x1 = 10;
            //Incrementar en uno el valor de x 1
            x1 = x1 + 1; // guarda en e1la suma de x1 +1
            Console.WriteLine("x1 = " + x1);
           

            //Por ejemplo: sumar 1 a la variable num1 tipo Short
          
            num1 = (short)(num1 + 1);//Conversion de int a short
            Console.WriteLine("num1 =" + num1);

            //Variable con numeros decimales
            double temperatura = 25.6;
            //Aumentar la temperatura en 10
            temperatura = temperatura + 10;
            Console.WriteLine("temperatura = " + temperatura);



            //Preograma que apartir de la base  y la altura , calcula el área de un triángulo
            //El área o superficie de un triángulo cualquiera es igual al producto de la base por la altura dividido por dos
            double altura, base1, area;

            altura = 10;
            base1 = 20;


            area=(altura * base1) / 2;
            Console.WriteLine("area = " + area);
            



            //resultado

            



            Console.ReadLine();
        }
    }
}
