using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Boletin5Tema5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             encontrar el multiplo de 3 7 8 a a ez en un rango
            int limiteInferior = 1200;
            int limiteSuperior = 35000;
             
            for (int i = limiteInferior; I <= limiteSuperior; i++)
            {
                if (i % 3== 0 && i %7 == 0 && i % 8 = 0)
                  {
                    Console.Writeline("primer multiplo de 3 7 y 8" + 1);
                    break;
                  }
            }
             
             
             */
            while (true)//inicio del bucle
            {
                Console.Clear();//limpiar la consola
                int ejercicio = 0;
                Console.WriteLine("Introducir ejercicio del 5 al 25:");// perdir que metan un ejercicio                
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 5 && ejercicio <= 25)// si se ponen algun ejercicio del 4 al 23 se cumple
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"El ejercicio que ha selecionado es: {ejercicio}");// mostramos que ejercicio se ha seleccionado
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    if (ejercicio == 5)
                    {
                        //Muestra los números del 320 al 160, contando de 20 en 20 utilizando un bucle while
                        int i = 320;
                        while (i >= 160)
                        {
                            Console.Write(i + " ");
                            i -= 20;
                        }
                    }
                    else if (ejercicio == 6)
                    {
                        //Muestra los números múltiplos de 5 y 7 entre 0 y 100 utilizando un bucle for.
                        Console.WriteLine("Muestra los nº multiplos de 5 y 7 entre 0 y 100:");
                        Console.WriteLine();// espacio
                        for (int i = 0; i <= 100; i++)
                        {
                            if (i % 5 == 0 && i % 7 == 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                    }
                    else if (ejercicio == 7)
                    {
                        //Muestra la tabla de multiplicar de un número introducido por teclado.
                        Console.Write("Escribe un numero: ");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Aqui tienes la tabla de multiplicar de el numero que has escogido " + numero + ":");
                        Console.WriteLine();
                        for (int i = 1; i <= 10; i++)
                        {
                            int resultadoMultiplicacion = numero * i;
                            Console.WriteLine($"{numero} x {i} = {resultadoMultiplicacion}");// numero*i
                        }
                    }
                    else if (ejercicio == 8)
                    {
                        //Escribe un programa que muestre en tres columnas, el número, el cuadrado y el cubo de los 5 primeros números enteros a partir de uno que se introduce por teclado.
                        int numero, i;
                        Console.WriteLine("Escribe un numero: ");
                        numero = int.Parse(Console.ReadLine());

                        for (i = numero; i < numero + 5; i++)
                        {
                            Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
                        }
                    }
                    else if (ejercicio == 9)
                    {
                        //Bucle for descendente que escribe números reales y su raíz cuadrada. Se inicializa la variable n a 16, en cada iteración del bucle se decrementa n en 2,5.
                        //El mensaje resultado de la ejecución deberá ser el siguiente:
                        /* N raiz(n)
                         16     4

                        13.5    3.67423

                        11      3.31662

                        8.5     2.91548

                        6       2.44949
                        3.5     1.87083

                        1       1       */
                    }
                    else if (ejercicio == 10)
                    {
                        /*Realizar un programa que calcule la suma de los m primeros números,  siendo m un número no negativo
                         * que es introducido POR TECLADO por el usuario. El programa pedirá que el usuario introduzca un número 
                         * hasta que un número positivo sea introducido, si no repite el mensaje solicitando el dato.*/
                        int m = -1;
                        int suma = 0;
                        int contador = 0;

                        do
                        {
                            if (contador == 0)
                            {
                                Console.WriteLine("introducce un n entero");
                                m = int.Parse(Console.ReadLine());
                            }
                            else if (contador == 1)
                            {
                                Console.WriteLine("Introduzca un numero positivo porfavor");
                                m = int.Parse(Console.ReadLine());
                            }
                            else if (contador == 2)
                            {
                                Console.WriteLine("QUE tiene que ser positivo porfavor");
                                m = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("dejalo estar anda");
                            }
                            contador++;
                        }
                        while (m < 0 && contador <= 3);

                        if (m > 0)
                        {
                            for (int i = 1; i <= m; i++)
                            {
                                suma = suma + i;
                            }
                            Console.WriteLine("La suma es : " + suma);
                        }

                    }
                    else if (ejercicio == 11)
                    {
                        /*Calcular la suma de la serie 1/1^3 + 1/2^3 +... + 1/n^3. Donde n es un número positivo que se introduce por teclado.*/
                        int n;
                        double suma = 0;
                        Console.WriteLine("Introduce un numero positivo: ");
                        n = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= n; i++)
                        {
                            suma = suma + 1 / Math.Pow(i, 3);                            
                        }
                        Console.WriteLine("El resultado de tu suma es: " + suma);


                        
                    }
                    else if (ejercicio == 12)
                    {
                        /*Calcular la suma de los divisores de un número n  no negativo introducido por teclado.*/
                        int numero = 0;
                        int sumaDivisor = 0;

                        do
                        {
                            Console.WriteLine("Introduce un numero mayor que cero");
                            numero = int.Parse(Console.ReadLine());
                        }
                        while (numero <=0);
                        sumaDivisor = 1 + numero;
                        for (int i = 1; i <= numero/2; i++)
                        {
                            if (numero % 12 == 0)
                            { 
                             sumaDivisor = sumaDivisor + i;
                            }
                        }
                        Console.WriteLine("la suma de sus divisores es: " + sumaDivisor);
                    }
                    else if (ejercicio == 13)
                    {
                        /*Diseñar un programa que lea un número introducido por teclado y decida si ese número es perfecto. 
                          Un número es perfecto si es igual a la suma de sus divisores excepto el mismo. Por ejemplo, el 6 es un número perfecto porque la suma de sus divisores da 1+2+3 =6.*/
                        int numeroPerfecto = 0, sumaDivisores = 0;

                        Console.WriteLine("Introduza un numero: ");                        
                        numeroPerfecto = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 1; i < numeroPerfecto; i++)
                        {
                            if (numeroPerfecto % i == 0) 
                            {
                                sumaDivisores = sumaDivisores + i;
                            }
                        }
                        if (numeroPerfecto == sumaDivisores)
                        {
                            Console.WriteLine($"Enhorabuena el numero {numeroPerfecto} es un numero perfecto!");
                        }
                        else
                        { 
                            Console.WriteLine($"Lo siento el numero {numeroPerfecto} no es un numero perfecto.");
                        }
                    }
                    else if (ejercicio == 14)
                    {
                        //Calcular la suma de los n primeros números que sean múltiplos de 5, siendo n un número no negativo introducido por teclado.
                        int numero, suma, contador;
                        int n;
                        Console.WriteLine("Introduzca un numero no negativo: ");
                        n = int.Parse(Console.ReadLine());
                        if (n >= 0)
                        {
                            suma = 0;
                            contador = 0;
                            numero = 0;

                            while (contador < n)
                            {
                                if (numero % 5 == 0)
                                {
                                    suma += numero;
                                    contador++;
                                }
                                numero++;
                            }
                            Console.WriteLine("El serultado de la suma es" + n);
                        }
                        else 
                        {
                            Console.WriteLine("El numero que ha introducido no es valido");
                        }

                    }
                    else if (ejercicio == 15)
                    {
                        //Diseñar un programa que calcule el factorial de un número introducido por teclado.
                        //Ayuda: El factorial de un número n  es: n * (n - 1) * (n - 2)…*1
                        //Por ejemplo el factorial de 4 es: 4 * 3 * 2 * 1

                        Console.Write("Ingrese un numero: ");
                        int numero = int.Parse(Console.ReadLine());

                        int factorial = 1;

                        for (int i = 1; i <= numero; i++)
                        {
                            factorial *= i;
                        }

                        Console.WriteLine($"El factorial de {numero} es: {factorial}");


                    }
                    else if (ejercicio == 16)
                    {
                        //Diseñar un programa que cuente cuántos números múltiplos de 3 hay por debajo de un número n dado por teclado por el usuario.
                        Console.Write("Ingrese un numero: ");
                        
                        int numero = int.Parse(Console.ReadLine());

                        int contador = 0;

                        for (int i = 1; i < numero; i++)
                        {
                            if (i % 3 == 0)
                            {
                                contador++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Son {contador} los multiplos de 3 por debajo de el {numero}");
                    }
                    else if (ejercicio == 17)
                    {
                        //Diseñar un programa que cuente los divisores de un número n introducido por teclado.
                        Console.Write("Ingrese un numero: ");
                        int numero = int.Parse(Console.ReadLine());
                        int contador = 0;

                        for (int i = 1; i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                contador++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"El nº {numero} tiene {contador} numeros divisores.");
                    }
                    else if (ejercicio == 18)
                    {
                        //Diseñar un programa que lea un número positivo  y nos diga si ese número es primo o no. 
                        //Utilizar para resolverlo un bucle for.  Nota: Un número es primo si solamente es divisible entre 1 y
                        //sí mismo.Si el número introducido es negativo o cero el programa debe volver a pedir al usuario que
                        //introduzca un número positivo.
                        
                        int numero;
                        Boolean primo = true;
                        do
                        {
                            Console.WriteLine("Introduzca un numero: ");
                            numero = int.Parse(Console.ReadLine());
                        }while (numero < 0);
                        for (int i = 2; i < numero / 2; i++) 
                        {
                            if (numero % i == 0) 
                            {
                                primo = false;
                            }
                        }
                        if (primo) 
                        {
                            Console.WriteLine("Es primo");
                        }
                        else
                        {
                            Console.WriteLine("No es primo");
                        }
                    }
                    else if (ejercicio == 19)
                    {
                        int n = 100;
                        int m = 1000;

                        for (int i = n; i <= m; i++) 
                        {
                            if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0) 
                            {
                                Console.WriteLine("Muliplos de 3,5 y 7"+ i );
                            }
                        }

                    }
                    else if (ejercicio == 20)
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"Tabla de multiplicar del {i}:");
                            for (int j = 1; j <= 10; j++)
                            {
                                //int resultado = i * j;
                                Console.WriteLine($"{i} x {j} = {i * j}");
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (ejercicio == 21)
                    {
                        for (int i = 7; i >= 1; i--) //(int i=1; i <=7; i++) 
                        {
                            for (int j = 1; j <= i; j++) 
                            {
                                Console.Write("* ");                                
                            }
                            Console.WriteLine();
                        }
                        for  (int i = 1; i <= 7; i++) 
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        //int i= 0;
                        
                        /*do
                        {
                            Console.Write("* ");                            
                            if (i <= 5)
                            {

                            }
                            else
                            {

                            }
                            i++;

                        } while (i >= 10); */
                    }
                    else if (ejercicio == 22)
                    {
                        for (int i = 1; i <= 7; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 7; i >= 1; i--) //(int i=1; i <=7; i++) 
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (ejercicio == 23)
                    {

                    }
                    else if (ejercicio == 24)
                    {
                        int limiteInferior, limiteSuperior;
                        int contadorPrimos = 0;
                        Console.WriteLine("Inroduce limite inferior: ");
                        limiteInferior = int.Parse(Console.ReadLine());
                        Console.WriteLine("Inroduce limite superior: ");
                        limiteSuperior = int.Parse(Console.ReadLine());

                        Boolean primo = true;
                        for (int i = limiteInferior; i <= limiteSuperior; i++) 
                        {
                            primo = true;
                            for (int j = 2; j <= i / 2; j++) 
                            {
                                if (i % j == 0) 
                                {
                                    primo = false;
                                    break;
                                }
                            }
                            if (primo) 
                            {
                                contadorPrimos++;
                                Console.WriteLine(i + " Es primo");
                            }

                        }
                    }
                    else if (ejercicio == 25)
                    {
                        Random random = new Random();
                        int numero = random.Next(-5, 6);
                        int negativos= 0, positivos = 0;
                        int contador= 0;
                        double porcentaje= 0; 
                        for (int i = 1; i <= 10; i++)
                        {                            
                            for (int j = 1; j <= 5; j++)
                            {
                                numero = random.Next(-5, 6);
                                Console.Write($"{numero} ");
                                if (numero <= -1)
                                {
                                    negativos++;
                                }
                                else 
                                {
                                    positivos++;                                    
                                }
                                if (numero<= 2 && numero>=-2) 
                                {
                                    contador++;
                                }
                            }
                            porcentaje = (contador / 5) * 100;
                            Console.WriteLine();
                            Console.Write("Porcentaje de números entre un rango -2 y 2: " + porcentaje);
                            Console.Write(" Negativos: "+ negativos);
                            Console.WriteLine(" Positivos: "+ positivos);
                            negativos = 0;
                            positivos = 0;
                            contador = 0;
                           

                            
                            Console.WriteLine();
                        }



                    }//llave del utimo ejercicio
                }// llave de selecionar que ejercicio mostrar                
                else if (ejercicio > 25)
                {
                Console.WriteLine("te has equivocado de ejercicio.");//en el caso de que se escriba el ejercicio que no es entrara aqui
                }// llave de te equivocas de ejercicio
                Console.WriteLine(); Console.WriteLine();//espacios
                Console.WriteLine("quieres escoger otro ejercicio?  S/N:");// pregutnamos y guardamos la respùesta
                string respuesta = Console.ReadLine();
                if (respuesta != "S" && respuesta != "s")
                {
                    break;
                }//fin del bucle respuesta
            }//fin del bucle while ehercios 5 a 25
        }//static void main
    }//class
}//namespace
