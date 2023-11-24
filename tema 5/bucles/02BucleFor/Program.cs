using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BucleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //bucle For
            //mostras numeros entre uno y 20 por pantalla

            /*for ( int i = 1 ; i <= 20 ; i = i + 1 ) 
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();*/
            //calcular la suma de todos los numeros entre n y m usando for
            /*int n = 15;
            int m = 30;
            int suma = 0;
            for ( int i = n ; i <= m ; i++ ) 
            {
                suma = suma + i;                
            }
            Console.Write("La suma es: " + suma);*/

            //calcula los numeros impares entre n y m
            int n = 15;
            int m = 30;
            int suma = 0;
            
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    suma = suma + i;
                }
            }
            Console.Write("La suma es: " + suma);


            Console.ReadLine();

        }
        
    }
}
