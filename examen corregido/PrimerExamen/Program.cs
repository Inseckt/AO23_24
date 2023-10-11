using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numero;
            Console.WriteLine(" introce el numero = ");
            numero = int.Parse(Console.ReadLine());

            //app a
            double raiz = Math.Sqrt(numero);
            raiz = Math.Round(raiz, 2);

            //app b
           double potencia  = Math.Pow(numero, 6);
            //ap c
            short copia = (short)numero;

            //app d
            float porcentaje = numero * 0.2f;

            //app e
            numero = (int)(numero + 0.35f * numero);

            Console.WriteLine("apartado a: " + numero + raiz);
            Console.WriteLine("apartado b: " + numero + potencia);
            Console.WriteLine("apartado c: " + numero + copia );
            Console.WriteLine("apartado d: " + numero + porcentaje );
            Console.WriteLine("apartado e: " + numero + numero);


            float horas, mes, irpf, salarioBruto, salarioNeto, precioHoras, horasMes;
            Console.WriteLine("horas trabajadas: ");
            horas = float.Parse(Console.ReadLine());
            Console.WriteLine("Precio Hora:");
            precioHoras = float.Parse(Console.ReadLine());
            Console.WriteLine("Dime el irpf:");
            irpf = float.Parse(Console.ReadLine());

            horasMes = horas * 4;
            salarioBruto = horasMes * precioHoras;
            salarioNeto = salarioBruto - (irpf * salarioBruto) / 100;

            Console.WriteLine("Salario Bruto: " + salarioBruto);
            Console.WriteLine("Salario Neto: " + salarioNeto);
            Console.ReadLine();

        }
    }
}
