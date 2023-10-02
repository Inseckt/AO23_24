using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LecturaPorTeclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que solicita al usuario DNI y Edad y salario
            string dni;
            byte edad;
            float salario;
            Console.WriteLine("Introduce el DNI: ");
            dni = Console.ReadLine();


            Console.WriteLine("Instroduce su Edad: ");
            edad =byte.Parse(Console.ReadLine()); //El parse deja que la variable byte nos deje asignarla a console readline para pasar de un strng(dato) a una variable numerica usamos .parse
            Console.ReadLine();

            Console.WriteLine("Introduzca su salario");
            salario = float.Parse(Console.ReadLine());// como es un sting tenemos que usar .parse para pasarlo a float si no llora.(la variable) 
           

            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Edad: " + edad);
            Console.ReadLine();

            
        }
    }
}
