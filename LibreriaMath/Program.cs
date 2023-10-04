using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;

            //Calcular la raíz cuadrada

            float raiz = (float) Math.Sqrt(numero);//esto esta bien sqrt es la raiz cuadrada
                                                   //esto esta mal y es una pregunta de examen, float raiz=  Math.Sqrt(raiz); se puede usar double
                                                   //o poner (float)math.sqrt(numero)

            //calcular una potencia
            //raiz enesima -- Mat.pow(base, 1/n)
            float raizCubica = (float)Math.Pow(numero, 1 / 3);
            int x = 9;
            int y = 4;
            //x elevado a y
            long potencia =(long) Math.Pow(x, y);

            //redondeo de valores

            float valor = 4.6f;

            float valorIntmenor = (float)Math.Floor(valor);

            Console.WriteLine(valor+ "Valor redondeado= " + valorIntmenor);
            
            float valorIntmayor = (float)Math.Ceiling(valor);
            Console.WriteLine(valor + "Valor rendondeado up =" + valorIntmayor);

            float valorIntcercano = (float)Math.Round(valor);
            Console.WriteLine(valor + "Valor redondeo cercano= " + valorIntcercano);
            Console.ReadLine();


            



        }
    }
}
