using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_3ConversionesDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dos tipos de conversiones: impricitas y explicitas:
            //Implicitas: Pasamos un valor de una variable de menor capacidad a otra de mayor capacidad
            byte n1 = 9;
            short n1copia = n1;
            int n1copia2 = n1copia;

            float n2 = 4.5f;
            double n2copia = n2;


            //Explicitas: Es cuando pasamos un valor de una variable de mayor capacidad a otra de menor capacidad, Son inseguras.

            //Ejemplos bien 
            int numero1 = 2400;
            short numero1Copia=(short)numero1;//se pone entreparentesis la variable a la cual queremos convertir
            short numero1Copia2 = Convert.ToInt16(numero1);

            double numero2 = 5.678;
            float numero2Copia= (float)numero2;
            float numer2Copia2= Convert.ToSingle(numero2);

            // Dos tipos de problemas.
            // ( OVERFLOW Y :(perdida de precision
            //Ejemplos mal

            short n3 = 30;
            //    byte n3Copia = (byte)n3;
            byte n3Copia2 = Convert.ToByte(n3);

            Console.WriteLine("n3= " + n3);
            //Console.WriteLine("n3copia=" + n3Copia); este es el ejemplo 1
            Console.WriteLine("n3copia="+ n3Copia2);
            



            //Perdida de precision

            float r1 = 9.56f;
            int r1Copia = (int)r1;
            Console.WriteLine("ri =" + r1);
            Console.WriteLine("r1Copia = " + r1Copia);

            Console.ReadLine();
































        }
    }
}
