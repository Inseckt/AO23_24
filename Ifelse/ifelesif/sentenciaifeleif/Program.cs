using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentenciaifeleif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa qe clasifica un numero como negativo, cero o positivo

            int numero = 900;

            if (numero < 0)
            {
                Console.WriteLine("numero negativo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Numero es cero");
            }
            else
            { 
                Console.WriteLine("Numero positivo");
            }

            //Programa que clasifica un numero como multiplo de 3 y 5 o de uno de los dos o de ninguno

            int numero1 = 20;

            if (numero1 % 3 == 0 && numero1 % 5 == 0 )
            {
                Console.WriteLine("multiplo de ambos.");
            }
            else if  (numero1 %3 == 0 )
            {
                Console.WriteLine("es multiplo de 3");
            }
            else if (numero1 %5 == 0 )
            {
                Console.WriteLine("Es multiplo de 5");
            }
            else 
            { 
                Console.WriteLine("No es de ninguno");
            }


            // actividad 3 Para aprobar la asignatura debemos cumplir los siguientes requisitos, aprobar los examenes, las tareas y l buen comortamiento


            Boolean examenesAprobados = true;
            Boolean tareasAprobadas = true;
            Boolean comportamientoCorrecto = true;

            //anidando 

            if (examenesAprobados && tareasAprobadas && comportamientoCorrecto)
            {
                Console.WriteLine("Enhorabuena has aprobado");
            }
            else 
            {
                Console.WriteLine("Lo siento estas ");
            }

            //SENTENCIA SWITCH NS PERMITE TRABAJAR CON RANGOS




            Char opcion;
            Char continuar;

            do
            {
                Console.WriteLine("Escoge una opcion");
                Console.WriteLine("A, Saludar");
                Console.WriteLine("B, Animar");
                Console.WriteLine("C, Despedir");
                opcion = char.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 'A':
                        Console.WriteLine("HOla");
                        break;
                    case 'B':
                        Console.WriteLine("Animate");
                        break;
                    case 'C':
                        Console.WriteLine("chao!");
                        break;
                    default:
                        Console.WriteLine("te has equivocado");
                        break; //Opcional
                               //Bucle para que el programa no se cierre




                }// la que cierra el swich
                Console.WriteLine("Quiere volver al menu? s/n");
                continuar = char.Parse(Console.ReadLine());





                Console.ReadLine();
            } //llave que cierra el bucle do
            while (continuar == 's');// con esto se cierra y con esto se crea la condicion para que se ejecute el bucle
        }
    }
}
