using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaArrayBoletin6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*ejercicio 7
            Funciones.printEnunciado(7);
                int n;
                Console.Write("Ingresar un numero mayor que 2 para el array: ");
                n =int.Parse(Console.ReadLine());
            
            while (n < 2)//compruebo que n sea mayor que dos
            {
                Console.WriteLine("La cantidad debe ser al menos 2. ");
                Console.Write("prueba de nuevo: ");
                n = int.Parse(Console.ReadLine());
            }

            int[] array = new int[n];
            Console.Write("valor para la primera ");
            array[0] = int.Parse(Console.ReadLine());
            Console.Write("valor para la ultima ");
            array[array.Length - 1] = int.Parse(Console.ReadLine());

            Funciones.printArray(array);

            Console.ReadLine();

            //ejercicio 8
                int[] array1 = new int[100];            
                Random generador = new Random();

                for (int i = 0; i < array1.Length; i++)
                {
                array1[i] = generador.Next(11);
                }
                
                Funciones.printArray(array1);
                */
            //ejercicio 16
            /*int contadorN = 0;
            int[] array2 = new int[12];
            Random generador1 = new Random();

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = generador1.Next(-11, 11);
                if (array2[i] < 0)
                {
                    contadorN++;
                }
            }            
            Funciones.printArray(array2);            
            Console.WriteLine("numeros negativos "+ contadorN);*/
            //18
            int contador18 = 0;
            String[] a18 = new String[10];
            a18[0] = "pipo muere";
            for (int i = 0; i < a18.Length; i++)
            {
                if (a18[i] == null)
                {
                    contador18++;
                }
                Console.WriteLine("Posiciones vacias: " + contador18);
            }
            //16
            int[] a16 = new int[50];
            Random rnd2= new Random();
            for (int i = 0; i < a16.Length; i++) 
            {
                a16[i] = rnd2.Next(-100, 101);
            }
            //12
            int[] a12 = new int[50];
            Console.WriteLine();
            Funciones

            long suma = 0;
            for (int i = 0; i < a12.Length; i++) 
            {
                suma += a12[i];
            }
            Console.WriteLine("Suma: " + suma);


            
            Console.ReadLine();
        }
    }
}
