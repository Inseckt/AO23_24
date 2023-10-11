using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Ejercicio 2****");
            int numero1Entero;
            Console.WriteLine("Introduzca un valor numerico entero: ");//Oscar tomas fernandez sayar apartado A) le pide al usuario que introduzca un valor
            numero1Entero = short.Parse(Console.ReadLine());
            //Apartado A
            double raizCuadrada = Math.Sqrt(numero1Entero) ;
           

            

            float elevado = (float)Math.Pow(numero1Entero, 10 / 6);
            Console.WriteLine($"Su resusltado del apartado a {numero1Entero} es el siguiente{raizCuadrada} = ");
            Console.WriteLine($"Su resusltado del apartado b es el siguiente = ");
            Console.WriteLine($"Su resusltado del apartado c es el siguiente = ");
            Console.WriteLine($"Su resusltado del apartado d es el siguiente = ");
            Console.WriteLine($"Su resusltado del apartado e es el siguiente = ");












            Console.WriteLine();
            Console.WriteLine("****Ejercicio 3****");
            //Declarar variables
            double salarioNeto, salarioBruto, irpf, horas, precioHora;

            //solicitar al usuario las horas
            Console.WriteLine("Introduzca las horas trabajadas en un mes: ");
            horas = double.Parse(Console.ReadLine());
            //Solicitar cuanto le quitan de irpf
            Console.WriteLine("Introduzca cuanto le descuentan de irpf: ");
            irpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca (precio / hora) que recibe: ");
            precioHora = float.Parse(Console.ReadLine());
            
            //hacer los calculos
            salarioBruto = horas * precioHora;
            salarioNeto = salarioBruto - (irpf * salarioBruto) / 100;

            Console.WriteLine("Su salario bruto es el siguiente: " + salarioBruto);
            Console.WriteLine("Su salario neto es el siguiente: " + salarioNeto);
            
            //Oscar Tomas Fernandez Sayar, comprobar que se muestra en pantalla los datos que nos proporciona el usuario


            Console.ReadLine(); 












        }
    }
}
