using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)//inicio del bucle
            {
                Console.Clear();//limpiar la consola
                int ejercicio = 0;
                Console.WriteLine("Introducrir ejecicio del 1 al 4:");// perdir que metan un ejercicio                
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 1 && ejercicio <= 4)//si se ponen algun ejercicio
                {
                    if (ejercicio == 1)
                    {
                        int numero = 12;
                        int contador = 0;

                        while (contador < 5)
                        {
                            Console.Write($"{numero}");
                            if (contador < 4)
                            {
                                Console.Write(", ");
                            }

                            numero += 10;
                            contador++;
                        }
                        Console.WriteLine();
                        int numeroResta = 100;
                        int contadorResta = 0;

                        while (contadorResta < 5)
                        {
                            Console.Write($"{numeroResta}");
                            if (contadorResta < 4)
                            {
                                Console.Write(", ");
                            }

                            numeroResta -= 20;
                            contadorResta++;
                        }
                    }
                    else if (ejercicio == 2)
                    {
                        int n, m;
                        do
                        {
                            Console.Write("Ingrese un numero: ");
                            n = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese otro nmero: ");
                            m = int.Parse(Console.ReadLine());

                            if (n >= m)
                            {
                                Console.WriteLine("el primer nº debe ser menor que el segundo");
                            }

                        } while (n >= m);
                        int contador = 0;

                        for (int numero = n; contador < 10; numero++)
                        {
                            if (numero % 2 != 0 && numero % 7 == 0)
                            {
                                Console.WriteLine(numero);
                                contador++;
                            }
                        }
                    }
                    else if (ejercicio == 3)
                    {
                        int n;
                        double suma = 0;
                        Console.WriteLine("Ingrese un nº: ");
                         n = int.Parse(Console.ReadLine());
                        for (int i = 10; i <= n; i += 2)
                        {
                            suma += 1.0 + i / Math.Pow(i, 3);
                        }
                        Console.WriteLine($"La suma es: {suma}");
                    }
                    else if (ejercicio == 4)
                    {
                        //con lo que ya sabes, hac un programa que decida si dos numeros son amigos. Dos numeros son amgos si la
                        //suma de sus divisores de un numero sin contar él mismo, es igual al otro numero y viceversa
                        int numeroAmigo = 0, numeroAmigo2= 0, sumaDivisores = 0;

                        Console.WriteLine("Introduza un numero: ");
                        numeroAmigo = int.Parse(Console.ReadLine());
                        numeroAmigo2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                       

                    }              

                    
                }//cierre de escojer ejercicos
                else if (ejercicio > 4)
                {
                    Console.WriteLine("te has equivocado de ejercicio.");//en el caso de que se escriba el ejercicio que no es entrara aqui
                }// llave de te equivocas de ejercicio
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("escoger otro ejercicio?  S/N:");
                string respuesta = Console.ReadLine();
                if (respuesta != "S" && respuesta != "s")
                {
                    break;
                }//fin del bucle respuesta

            }//fin del bucle while
        }
    } 
}//name            
    

