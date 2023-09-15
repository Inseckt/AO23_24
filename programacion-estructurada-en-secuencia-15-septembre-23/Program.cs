using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_estructurada_en_secuencia_15_septembre_23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Necesito usar 3 variables. Preograma que le dos números y calcula la suma
            //Declaracion de variables
            int a, b, suma;
            //System.Int32 a1, b1, suma1; Solo es para fardar, no es importante por que ya esta implementado en el visual
            //Inicializamos a y b
            a = 9;
            b = 3;
            //calcular la suma
            suma = a + b;
            //EScribir el resultado
            Console.WriteLine("La suma es : 9+3=" + suma);
            Console.ReadLine();
        }
    }
}
