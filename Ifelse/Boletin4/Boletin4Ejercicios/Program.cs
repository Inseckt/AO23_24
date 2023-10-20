using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin4Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ejercicio = 0;

            Console.WriteLine("Introducir ejercicio:");
            ejercicio = int.Parse(Console.ReadLine());

            if (ejercicio == 4)
            {
                //ejercicio 4 Escribir un programa que lea tres números y muestre por pantalla la media
                //aritmética. Si la media es superior a 5 mandará un mensaje de  “Alumno aprobado”. En
                //cualquier otro caso el mensaje indica: “Alumno suspenso”

                double numero1, numero2, numero3, mediaAritmetica;

                Console.WriteLine("Introduce el primer numero:");
                numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo numero:");
                numero2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el tercer numero:");
                numero3 = double.Parse(Console.ReadLine());

                mediaAritmetica = (numero1 + numero2 + numero3) / 3;
                Console.WriteLine($"Tu media aritmeticaes = {mediaAritmetica}");

                if (mediaAritmetica > 5)
                {
                    Console.WriteLine("alumno aprobado");
                }
                else
                {
                    Console.WriteLine("Alumno suspenso");
                }



            }
            else if (ejercicio == 5)
            {
                //ejercicio 5 Diseñar un programa que lea(es decir solicita al usuario que los introduzca
                //por teclado) dos números reales, los guarde en dos variables de tipo double calcule su
                //suma guardándola en una variable, SI ES POSITIVA  mostrar por pantalla la raíz cuadrada
                //de la suma (usar la clase Math.sqrt(variable)),  en cualquier otro caso muestra un mensaje
                //informando de que no se puede calcular la raíz.

                double numero4, numero5, suma, raizCuadrada;
                Console.WriteLine("Introduce el primer numero: ");
                numero4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo numero: ");
                numero5 = double.Parse(Console.ReadLine());

                suma = numero4 + numero5;

                if (suma > 0)
                {
                    raizCuadrada = Math.Sqrt(suma);
                    Console.WriteLine($"El numero positivo tiene esta raiz cuadrada: {raizCuadrada}");
                }
                else
                {
                    Console.WriteLine("No se puede calcular la raiz al ser una suma negativa o que el resultado de 0");//Aqui no sabia si considferamos positivo o negativo cero por eso en if usop > en vec de >=, preguntarselo al profe
                }



            }
            else if (ejercicio == 6) 
            {
                //ejercicio 6 Escribir un programa que solicite al usuario una contraseña que se guardará en
                //una variable de tipo String. El programa debe tener almacenada la contraseña previamente en
                //otra variable. Si las dos contraseñas son iguales manda un mensaje diciendo que la
                //contraseña es correcta en otro caso indica que no lo es.

                string contraseñaIncorrecta, contraseñaCorrecta = "1234";
                Console.WriteLine("Introduce la contraseña:");
                contraseñaIncorrecta = Console.ReadLine();

                if (contraseñaIncorrecta == contraseñaCorrecta)
                {
                    Console.WriteLine("La contraseña es correcta.");
                }
                else 
                {
                Console.WriteLine("La contraseña es incorrecta.");
                }
            }
            else if (ejercicio == 7)
            {
                //ejercicio 7 Diseñar un programa que lea dos números y calcule el mayor elevado al más pequeño
                //(usar la clase Math.pow (base,exponente).
                double numero6, numero7, numeroElevado;
                Console.WriteLine("Introduce el primero numero: ");
                numero6 = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo numero: ");
                numero7 = double.Parse(Console.ReadLine());


                if (numero6 < numero7)
                {
                    numeroElevado = Math.Pow(numero7, numero6);
                    Console.WriteLine($"El numero mayor elevado al numero mas pequeño: {numeroElevado}");
                }
                else if (numero6 > numero7)
                {
                    numeroElevado = Math.Pow(numero6, numero7);
                    Console.WriteLine($"el numero mayor elevado al numero mas pequeño: {numeroElevado}");
                }
                else 
                {
                Console.WriteLine("Ambos numeros son iguales no se puede realizar el calculo");
                }
                    
                      



                

            }
            else if (ejercicio == 8)
            {
                //ejercicio 8 Debido al sobrepeso Homer tiene que realizar su actividad laboral desde casa,
                //para ello la central necesita realizar un programa que lo ayude a gestionar la seguridad de
                //la central. Esta aplicación medirá la presión y la temperatura del núcleo. Si la presión es
                //superior a 2 atm debe mostrar el mensaje “Abrir válvula de seguridad”.Si la temperatura
                //supera los 500 Kelvin el mensaje debe ser “Reducir la temperatura. Si suceden ambas
                //situaciones debe mostrar ambos mensajes. Si no debe aparecer “Todo en orden”.


                double presion, temperatura;
                Console.Write("Introduce la presión: ");
                presion = double.Parse(Console.ReadLine());
                Console.Write("Introduce la temperatura: ");
                temperatura = double.Parse(Console.ReadLine());

                if (presion > 2 && temperatura > 500)
                {
                    Console.WriteLine("Abrir válvula de seguridad");
                    Console.WriteLine("Reducir la temperatura");
                }
                else if (presion > 2)
                {
                    Console.WriteLine("Abrir válvula de seguridad");
                }
                else if (temperatura > 500)
                {
                    Console.WriteLine("Reducir la temperatura");
                }
                else
                {
                    Console.WriteLine("Todo en orden");
                }
            }


            Console.ReadLine();

        }
    }
}
