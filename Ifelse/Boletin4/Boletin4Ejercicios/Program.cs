﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            if (ejercicio == 3)
            {
                /*ejercicio 4 3.	Explica lo que hace el siguiente DFD y escribe el algoritmo en código en el Visual Studio.

                double a, b, c, d, menor;
                
                Console.WriteLine("Introduce el valor de a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el valor de b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el valor de c:");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el valor de d:");
                d = double.Parse(Console.ReadLine());
                if (a > b)
                {
                    menor = b;
                    Console.WriteLine("menor= b");
                }
                else if (a < b)
                {
                    menor = a;
                    Console.WriteLine("menor = a");
                }
                else if (menor > c)
                {
                    menor = c;
                    Console.WriteLine("menor = c");
                }
                else 
                {
                Console.WriteLine("menor = d");
                }
                */

            }
            else if (ejercicio == 4)
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
            else if (ejercicio == 9)
            {
                //9 Diseñar un programa que lea un número y si es múltiplo de 2 o de 3 mande un mensaje
                //informando de tal situación, en caso de que no lo sea no hará nada.

                double numeroMultiplo2_3;
                Console.WriteLine("introduzca un numero: ");
                numeroMultiplo2_3 = double.Parse(Console.ReadLine());

                if (numeroMultiplo2_3 % 2 == 0 && numeroMultiplo2_3 % 3 == 0)
                {
                    Console.WriteLine("Multiplo de ambos");
                }
                else if (numeroMultiplo2_3 % 2 == 0)
                {
                    Console.WriteLine("multiplo de 2");
                }
                else if (numeroMultiplo2_3 % 3 == 0)
                {
                    Console.WriteLine("multiplo de 3");
                }
                else

            }
            else if (ejercicio == 10)
            {
            }
            else if (ejercicio == 11)
            {
            }
            else if (ejercicio == 12)
            {
            }
            else if (ejercicio == 13)
            {
            }
            else if (ejercicio == 14)
            {
            }
            else if (ejercicio == 15)
            {
            }
            else if (ejercicio == 16)
            {
            }
            else if (ejercicio == 17)
            {
            }
            else if (ejercicio == 18)
            {
            }
            else if (ejercicio == 19)
            {
            }
            else if (ejercicio == 20)
            {
            }
            else if (ejercicio == 21)
            {
            }
            else if (ejercicio == 22)
            {
            }
            else if (ejercicio == 23)
            {
            }
            
            















                Console.ReadLine();


            }
        }
    }
}
