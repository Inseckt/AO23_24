using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Boletin4Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)//inicio del bucle
            {
                Console.Clear();//limpiar la consola


                int ejercicio = 0;

                Console.WriteLine("Introducir ejercicio:");// perdir que metan un ejercicio
                ejercicio = int.Parse(Console.ReadLine());

                if (ejercicio >= 4 && ejercicio <= 23)// si se ponen algun ejercicio del 4 al 23 se cumple
                {
                    Console.WriteLine($"Su ejercicio {ejercicio}");// mostramos que ejercicio se ha seleccionado



                    //NO HE COMENTADO LOS EJERCICIOS YA CORREGIDOS DE 4 AL 8

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
                        {//Aqui entrariamos en caso de que mediaAritmetica sea mayor que 5
                            Console.WriteLine("alumno aprobado");
                        }
                        else//Console.WriteLine("Alumno suspenso");
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

                        if (suma > 0)//Como dije antes, aqui al tener mas de una instruccion si que tenemos que usar las llaves y si que tienen que ir en distintas lineas
                        {
                            raizCuadrada = Math.Sqrt(suma);
                            Console.WriteLine($"El numero positivo tiene esta raiz cuadrada: {raizCuadrada}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede calcular la raiz al ser una suma negativa o que el resultado de 0");
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

                        double numeroMultiplo2_3;// declarar variable
                        Console.WriteLine("introduzca un numero: ");// Leer el numero 
                        numeroMultiplo2_3 = double.Parse(Console.ReadLine());

                        if (numeroMultiplo2_3 % 2 == 0 || numeroMultiplo2_3 % 3 == 0) //uso % para tener como resultado el resto 0 y al poner que es == a 0 se si es multiplo de 2 o de 3
                        {//He comprobado que cuando usamos if else y SOLAMENTE hay UNA instruccion, no hace falta usar {} y puede ir en la misma linea que el if o el esle, Console.WriteLine("Multiplo de ambos"); podria ir en la linea 205.
                            Console.WriteLine("Es multiplo de 2 o de 3 averigualo jeje");
                        }
                        //Aqui creo que poner el else es tonteria por que el ejercicio dice que si no se cumplen cualquiera de las condiciones el programa no hara nada
                    }
                    else if (ejercicio == 10)
                    {
                        //10. Diseñar un programa que aplique un descuento del 10% si el precio de un producto es inferior a 100 y del 15% si es superior.

                        double precio, rebaja;
                        Console.WriteLine("introduzca el precio de lo que has comprado: ");// declarar variables y pedir el precio de lo que se ha comprado
                        precio = double.Parse(Console.ReadLine());

                        if (precio < 100)// aqui entramos si el precio es menor de 100 y asignamos la rebaja
                        {
                            rebaja = precio * 0.10;
                        }
                        else// aqui si es mayor
                        {
                            rebaja = precio * 0.15;
                        }
                        Console.WriteLine($"Se ahorra: {rebaja}");//Al escribirlo al final de la llave el codigo queda mas limpio.
                    }
                    else if (ejercicio == 11)
                    {
                        //11. Realizar un programa que lea una calificación en una variable real y decida qué nota tiene según el siguiente criterio :
                        //Menor que 0 o mayor que 10 = Error en nota, 0 a <5.0 = Suspenso, 5.0 a <6.5 = Aprobado,
                        //6.5 a < 8.5 = Notable, 8.5 a 10 = Sobresaliente.

                        double nota;
                        Console.WriteLine("Escriba la nota que has sacado: ");
                        nota = double.Parse(Console.ReadLine());

                        if (nota < 0 || nota > 10)// aqui entramos si la nota no esta entre 0 y 10 si es menor que 0 o mayor que 10
                        {
                            Console.WriteLine($"Error en la nota");
                        }
                        else if (nota >= 0 && nota < 5.0)//en este ejercicio al usar operadores relacionales en todos los else e ifs concretamos todas las posibilidades de numeros sin que se escape ninguno que no este dentro de el rango de la nota. Ademas asi lo entiendo mejor
                        {
                            Console.WriteLine("Suspenso");
                        }
                        else if (nota >= 5.0 && nota < 6.5)// entramos si el mayor op igual a 5 y menor que 6,5
                        {
                            Console.WriteLine("Aprobado");
                        }
                        else if (nota >= 6.5 && nota < 8.5)// aqui si es mayor o igual a 6,5 y menor de 8,5
                        {
                            Console.WriteLine("Notable");
                        }
                        else// aqui si es mayor
                        {
                            Console.WriteLine("Sobresaliente");
                        }


                    }
                    else if (ejercicio == 12)
                    {
                        //12. Escribir un programa que lea un número y si ese número es múltiplo de 4, entonces le suma 25, sino si es múltiplo de 5 le
                        //suma 50 y en otro caso le suma 100. Debe mostrar el valor inicial y final del número introducido

                        int numeroMultipo4_5;
                        Console.WriteLine("Introduzca un numero:");
                        numeroMultipo4_5 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Su numero elegido es {numeroMultipo4_5}");//Aqui puse el string fuera de if y ese para cumplir lo que me pide el ejercico, mostrar el valor inicial del numero.

                        if (numeroMultipo4_5 % 4 == 0)// calculamos el resto para saber si es multiplo de 4
                        {
                            numeroMultipo4_5 += 25; //sumamos el valor con +=
                        }
                        else if (numeroMultipo4_5 % 5 == 0)// calculamos el resto si es  multiplo de 5
                        {
                            numeroMultipo4_5 += 50;
                        }
                        else
                        {
                            numeroMultipo4_5 += 100;
                        }
                        Console.WriteLine($"Su numero ahora es el {numeroMultipo4_5}");// aqui puse el string fuera de if y else para que siempre muestre el resultado final

                    }
                    else if (ejercicio == 13)
                    {
                        //13. Escribir un programa (y realizar el DFD) que evalúe el valor de una variable decimal llamada “temp” , y escriba uno de los
                        //siguientes mensajes dependiendo de su valor:
                        //SÓLIDO: Si el valor de temp es menor que cero.
                        //LÍQUIDO: Si el valor de temp se encuentran entre cero y 100.
                        //VAPOR: Si el valor de temp es superior a 100.
                        //PLASMA: Si la temperatura superior 1000000

                        decimal temp;
                        Console.WriteLine("Escriba la temperatura entre -1000000 y 1000000: ");
                        temp = decimal.Parse(Console.ReadLine());

                        if (temp < 0)
                        {
                            Console.WriteLine($"como la temperatura es {temp} el resultado es SOLIDO!!!");
                        }
                        else if (temp == 0 || temp <= 100)
                        {
                            Console.WriteLine($"como la temperatura es {temp} el resultado es LIQUIDO!!!");
                        }
                        else if (temp > 100 && temp <= 1000000)
                        {
                            Console.WriteLine($"como la temperatura es {temp} el resultado es VAPOR!!!");
                        }
                        else
                        {
                            Console.WriteLine($"como la temperatura es {temp} el resultado es plasma!!!");
                        }

                    }
                    else if (ejercicio == 14)
                    {
                        //14. Mostrar al usuario un menú con las opciones: a.Sumar b.Restar c.Multiplicar d.Dividir e.Raiz de la suma.
                        //Una vez leida la opción , se le solicitan dos números y se realiza la operación indicada.

                        char opcion, continuar;//Este ejercicio me ha dado infinitos quebraderos de cabeza, creo que le faltan o opciones por poner pero consegui que en cierta manera haga lo que pide el ejercicioç
                                               //un poco cochambroso pero lo hace

                        do//inicio de do para hacer un bucle y comprobar mas opciones
                        {
                            Console.WriteLine("Por favor eliga una de las siguientes operaciones: ");
                            Console.WriteLine("Opcion a. Sumar.");
                            Console.WriteLine("Opcion b. Restar.");
                            Console.WriteLine("Opcion c. Multiplicar.");
                            Console.WriteLine("Opcion d. Dividir.");
                            Console.WriteLine("Opcion e. Raiz cuadrada de la suma.");
                            opcion = Console.ReadKey().KeyChar;
                            Console.WriteLine();//espacio
                            double n1, n2, resultado = 0;//Aqui la unica manera que se me ocurrio de que resultado se mostrase al final sin que ocupase todas las lineas de case, es asignarle un valor 0
                                                         //Y que igualmente se ejecute la opcion switch y que muetre su resultado correspondiente en caso de que no se cumplan ninguna de las condiciones

                            Console.WriteLine("introduzca el primer numero: ");
                            n1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("introduzca el segundo numero: ");
                            n2 = double.Parse(Console.ReadLine());

                            switch (opcion) //con el switch pongo los casos de la opcion que el usuario ha realizado, y le asigno la operacion al resultado.
                            {
                                case 'a':
                                    resultado = n1 + n2;// aqui entramos si el usuario escribe a y hacemos el calculo
                                    break;
                                case 'b':
                                    resultado = n1 - n2;// aqui entramos si el usuario escribe b y hacemos el calculo
                                    break;
                                case 'c':
                                    resultado = n1 * n2;// aqui entramos si el usuario escribe c y hacemos el calculo
                                    break;
                                case 'd':
                                    if (n2 != 0 || n1 != 0)// aqui declaro que si cualquiera de los numeros es 0 le diga al usuario que no se puede realizar, pidiendole que ponga otros numeros
                                    {
                                        resultado = n1 / n2;// aqui hacemos el calculo en caso de que uno de los numeros no sea 0
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lo siento no puedes dividir por cero.");
                                    }
                                    break;
                                case 'e':
                                    resultado = Math.Sqrt(n1 + n2);// aqui entramo si el usuario escribe c y hacemos el calculo
                                    break;
                                default:
                                    Console.WriteLine("Lo siento opcion incorrecta, seleccione una opcion correcta. ");// si el usuario no ha escrito la opcion bien, le saldra esto para que pueda seleccionar una de nuevo
                                    break;
                            }//cerramos el switch
                            Console.WriteLine($"su resultado es: {resultado}");//hacemos un bucle para probar mas cosas
                            Console.WriteLine("Quiere seleccionar otra opcion? s->sí/n->no");
                            continuar = Console.ReadKey().KeyChar;//Para que no espere a que el usuario pulse Enter
                            Console.WriteLine();
                        }//cerramos el do
                        while (continuar == 's');//Hice el bucle de continuar para poder probar todas las opciones aqui lo cerramos con while

                    }
                    else if (ejercicio == 15)
                    {
                        //15. Una compañía de agua está implantando un nuevo sistema de cobro. Para cada casa realiza la siguiente factura:
                        //- Los primeros 50 litros son gratis: Pago = 0.
                        //- Entre 50 y 200 litros se cobra el litro a 4,75 euros Pago = (Nº Litros – 50)*4,75.
                        //- A partir de 200 litros se cobra el litro a 20 euros Pago = (Nº Litros - 200)*20 + 150 * 4,75.
                        //La cuota mínima es de 45 euros, es decir que si el dinero a pagar resulta menor de 45 euros, entonces será de 45 euros.
                        //Realice un programa que calcule el gasto de agua de una familia en un mes dada la cantidad de litros gastada.

                        //declaramos las variable y pedimos al usuario que nos de cuantos litros ha gastado
                        int litrosConsumidos;
                        double pagoFactura;
                        Console.WriteLine("Introduzca cuantos litros has gastado: ");
                        litrosConsumidos = int.Parse(Console.ReadLine());

                        if (litrosConsumidos <= 50)//aqui entramos si consumimos  50 o menos de 50 litros y el pago valdra 0
                        {
                            pagoFactura = 0.0;
                        }
                        else if (litrosConsumidos <= 200)//aqui entramos si consumimos mas de 50 y 200  y hacemos el calculo 
                        {
                            pagoFactura = (litrosConsumidos - 50) * 4.75;
                        }
                        else
                        {
                            pagoFactura = (litrosConsumidos - 200) * 20 + 150 * 4.75;//aqui entramo si no se cumple ninguno de los 2 casos anteriores y hacemos el calculo
                        }
                        if (pagoFactura < 45)//comprobar que la cuota minima sea la correcta y asignarle el precio
                        {
                            pagoFactura = 45;
                        }
                        Console.WriteLine("Tiene que realizar el siguiente pago " + pagoFactura); //mostramos el precio
                    }
                    else if (ejercicio == 16)
                    {
                        //16. Desarrollar un programa que lea el precio  de 3 artículos, que muestre la suma total de los precios de dichos artículos
                        //e imprima la cantidad total a pagar que se debe calcular de acuerdo con la siguiente clasificación:
                        //a) Si la suma de los precios es menor de 500.00 no hay ningún descuento.
                        //b) Si la suma de los precios está entre 500.00 y 1,000.00 € se le descuenta el 3 % del total.
                        //c) Si la suma de los precios es mayor de 1,000.00 y menor de 2,000.00 se le descuenta el 5 % del total.
                        //d) Si la suma de los precios es mayor o igual a 2,000.00 y menor o igual a3,000.00 se le descuenta el 7 % del total.
                        //e) Si la suma de los precios es mayor de 3,000.00 se le descuenta el 10 % del total

                        double precioArticulo1, precioArticulo2, precioArticulo3, sumaDeLosArticulos, precioAPagar, descuento = 0;//Aqui van las variables que vamos a usar y le asigno a descuento 0 en caso de que no se cumplan
                        Console.WriteLine("Inroduzca el precio del primer articulo: ");//pedimos que nos introduzca el precio de los articulos
                        precioArticulo1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Inroduzca el precio del segundo articulo: ");
                        precioArticulo2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Inroduzca el precio del tercer articulo: ");
                        precioArticulo3 = double.Parse(Console.ReadLine());

                        sumaDeLosArticulos = precioArticulo1 + precioArticulo2 + precioArticulo3; //hacemos la suma de los articulos

                        if (sumaDeLosArticulos < 500.00)// entramos aqui si la suma es menor de 500 y no le aplicamos descuento
                        {
                            descuento = 0;
                        }
                        else if (sumaDeLosArticulos >= 500 && sumaDeLosArticulos <= 1000.00)// entramos aqui si la suma es mayor o igual que 500 y menos que 1000 aplicandole el 3% de descuento
                        {
                            descuento = sumaDeLosArticulos * 0.03;
                        }
                        else if (sumaDeLosArticulos > 1000.00 && sumaDeLosArticulos < 2000.00)// entramos aqui si la suma es mayor o igual de 1000 y menos de 2000 le aplicamos el 5% de descuento
                        {
                            descuento = sumaDeLosArticulos * 0.05;
                        }
                        else if (sumaDeLosArticulos >= 2000.00 && sumaDeLosArticulos <= 3000.00)// entramos aqui si la suma es mayor o igual de 2000 y menor que 3000 le aplicamos el 7% de descuento
                        {
                            descuento = sumaDeLosArticulos * 0.07;
                        }
                        else
                        {
                            descuento = sumaDeLosArticulos * 0.10; //entramos aqui si esmayor que 3000.00 y se le aplica un 10% de descuento.                    
                        }

                        //ahora hacemos el calculo de restarle el descuento al precio de los articulos y enseñamos todo como si fuera un ticket
                        precioAPagar = sumaDeLosArticulos - descuento;
                        Console.WriteLine($"El precio de lo que ha comprado es: {sumaDeLosArticulos} euros");
                        Console.WriteLine($"El descuento que le aplicamos es: {descuento} euros");
                        Console.WriteLine($"El precio final que tiene que es: {precioAPagar} euros");
                    }
                    else if (ejercicio == 17)
                    {
                        //17. Se desea calcular el salario bruto y neto semanal de los trabajadores de una empresa de acuerdo a las siguientes normas.
                        //Para el salario bruto:
                        //a.Si las horas semanales trabajadas son <= 38, el salario bruto será igual a las horas trabajadas por la tasa a la que se paga la hora.
                        //b.Horas extras(más de 38), a una tasa 50% superior a la ordinaria.
                        //Una vez calculado el salario bruto, el salario neto se calcula de la siguiente forma:
                        //a.Impuestos 0 por 100, si el salario bruto es menor o igual a 300 euros.
                        //b.Impuestos del 10 por ciento, si el salario bruto es mayor a 300 euros.
                        //Realizar un programa que solicite la tasa por hora y las horas trabajadas y calcule el  salario neto y el bruto.

                        double horasExtra, horasSemana = 38, salarioNeto, salarioBruto, precioHora;//Declaramos las variables que vamos a necesitar y le pedimos al usuario que introduzca tanto las horas trabajadas en una semana como el precio por cada hora.
                        Console.WriteLine("Introduzca las horas trabajadas en esta semana: ");
                        horasSemana = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca cuanto cobra por hora trabajada;");
                        precioHora = double.Parse(Console.ReadLine());

                        if (horasSemana <= 38)// aqui entramos si las horas trabajadas son igual o menores de 38
                        {
                            salarioBruto = horasSemana * precioHora;// hacemos el calculo
                        }
                        else
                        {
                            horasExtra = horasSemana - 38;// aqui entramos si las horas de la semana son mas de 38 y luego calculamos cuantas horas extra se han trabajado a mas, restandole las horasextra menos 38, ademas hacemos el calculo de su precio
                            salarioBruto = (horasSemana * precioHora) + (horasExtra + (precioHora * 0.50));
                        }
                        if (salarioBruto <= 300)//aqui entramos si el salario bruto es igual o menor de 300 y le asignamos el valor a salario neto
                        {
                            salarioNeto = salarioBruto;
                        }
                        else
                        {
                            salarioNeto = salarioBruto - (salarioBruto * 0.10);// aqui entramos si el salario bruto es superior y le aplicamos el 10% de impuestos
                        }
                        //ahora mostramos el salario bruto y el salario neto
                        Console.WriteLine($"El salario bruto semanal es de: {salarioBruto} ");
                        Console.WriteLine($"El salario neto semanal es de: {salarioNeto}");






                    }
                    else if (ejercicio == 18)
                    {
                        //18. Escribe una instrucción switch que examine el valor de una variable entera llamada “indicador”  y escriba uno de los
                        //siguientes mensajes:
                        //a.CALOR, si el indicador tiene valor 1
                        //b.TEMPLADO, si tiene valor 2
                        //c.FRIO, si tiene valor 3
                        //d.FUERA DE RANGO, si tiene valor 4

                        int indicador;// variable declarada y `pedir un unmero del 1 al 3
                        Console.WriteLine("Introduzca un numero del 1 al 3:");
                        indicador = int.Parse(Console.ReadLine());

                        switch (indicador)//con el switch pongo los casos que el usuario ha realizado, y le asigno el resultado.
                        {
                            case 1:
                                Console.WriteLine("CALOR");//aqui entraremos siempre que sea 1
                                break;
                            case 2:
                                Console.WriteLine("TEMPLADO");//aqui entraremos siempre que sea 2
                                break;
                            case 3:
                                Console.WriteLine("FRIO");//aqui entraremos siempre que sea 3
                                break;
                            default:
                                Console.WriteLine("FUERA DE RANGO");//aqui entraremos siempre que no sea 1, 2 o 3
                                break;
                        } // fin de llave switch               
                    }
                    else if (ejercicio == 19)
                    {
                        //19. Escribe una instrucción Select que examine el valor de una variable de tipo Char llamada “color”  y escriba uno de los siguientes mensajes:
                        //a.ROJO, si vale “r” ó “R”
                        //b.VERDE, si vale “v” ó “V”
                        //c.AZUL, si vale “a” ó “A”
                        //d.NEGRO, si tiene asignado cualquier otro caracter.

                        char calor, respuesta1;//declarar variables y pedir que elijan letras                
                        Console.WriteLine("Introduzca una de estas letras: r o R, v o V, a o A");
                        calor = char.Parse(Console.ReadLine());
                        do//inicio de do para poder elegir otra letra
                        {
                            switch (calor)//con el switch pongo los casos que el usuario ha realizado, y le asigno el resultado.
                            {
                                case 'r':
                                case 'R':
                                    Console.WriteLine("ROJO");
                                    break;
                                case 'v':
                                case 'V':
                                    Console.WriteLine("VERDE");
                                    break;
                                case 'a':
                                case 'A':
                                    Console.WriteLine("AZUL");
                                    break;
                                default:
                                    Console.WriteLine("NEGRO");
                                    break;
                            }//fin de llave switch
                            Console.WriteLine("Quieres poner otra letra? S/N: ");// le pido al usuario si quiere elejir otra letra y le asigno a respuesta que se lea al pulsar la tecla
                            respuesta1 = Console.ReadKey().KeyChar;
                        }//fin de llave do
                        while (respuesta1 == 'S' || respuesta1 == 's');// si el usuario decide si se repetira la opcion de elegir letra
                        Console.WriteLine();//salto de linea
                    }
                    else if (ejercicio == 20)
                    {
                        //20. Realizar un programa que indique cuantas cifras tiene un número. Hasta 6 cifras.

                        int numeroCifras;//Declaramos variable y le pedimos al usuario que introduzca un numero de maximo 6 cifras 
                        Console.WriteLine("Introduzca un numero, como maximo puede tener 6 cifras:");
                        numeroCifras = int.Parse(Console.ReadLine());

                        if (numeroCifras == 0 || numeroCifras < 10)//aqui entramos si el numero es de una cifra, y le enseñamos al usuario que numero es y cuantas cifras tiene
                        {
                            Console.WriteLine($"El numero {numeroCifras} tiene 1 cifra");
                        }
                        else if (numeroCifras == 10 || numeroCifras <= 99)// aqui con 2 cifras
                        {
                            Console.WriteLine($"El numero {numeroCifras} tiene 2 cifras");
                        }
                        else if (numeroCifras == 100 || numeroCifras <= 999)// aqui con 3 cifras
                        {
                            Console.WriteLine($"El numero {numeroCifras} tiene 3 cifras");
                        }
                        else if (numeroCifras == 1000 || numeroCifras <= 9999)// aqui con 4 cifras
                        {
                            Console.WriteLine($"El numero {numeroCifras} tiene 4 cifras");
                        }
                        else if (numeroCifras == 10000 || numeroCifras <= 99999)// aqui con 5 cifras
                        {
                            Console.WriteLine($"El numero {numeroCifras} tiene 5 cifras");
                        }
                        else if (numeroCifras == 100000 || numeroCifras <= 999999)// aqui con 6 cifras
                        {
                            Console.WriteLine($"El numero {numeroCifras} tiene 6 cifras");
                        }
                        else
                        {
                            Console.WriteLine("numero incorrecto, intentelo de nuevo");
                        }
                    }
                    else if (ejercicio == 21)
                    {
                        //21. Realizar un programa que resuelva una ecuación de segundo grado.ax^2 + bx + c = 0 Para ello deberá solicitar al usuario que introduzca los 3 coeficientes(a, b, c) por teclado.
                        //-Si a es cero, la solución es: x1 y x2 = -c/b
                        //-Si b es cero, las soluciones son:  x1 yx2 = +- raizcuadrada de -c/a  Siempre y cuando la raíz sea positiva, en caso contrario no tiene solución.
                        //-Si c es cero, las soluciones son: x1 = 0 y x2 =- b/a
                        //-Si a b y c son distinto de cero se calculará la solución en base a la mítica fórmula: x1 y x2 = -b+- raid de b^2 - 4ac/ 2a        
                        //El programa debe asegurarse que existe solución real(es decir que la raíz no es negativa) ,si no existiese se informaría
                        //al usuario de dicha circunstancia Ayuda: Necesitaréis dos variables para guardar las dos soluciones.

                        double a, b, c, x1, x2;//variables declaradas y pedir por teclado los coeficientes
                        Console.WriteLine("introduzca el coeficiente a: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca el coeficiente b: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca el coeficiente c: ");
                        c = double.Parse(Console.ReadLine());

                        if (a == 0)// aqui entramos si a es igual a 0 y asignamos el valor del resultado a x1 y x2
                        {
                            x1 = -c / b;
                            x2 = -c / b;
                        }
                        else if (b == 0)// aqui entramos si b es igual a 0 y asignamos el valor del resultado a x1 y x2
                        {
                            x1 = Math.Sqrt(-c / a);
                            x2 = Math.Sqrt(-c / a);
                            if (x1 < 0)// aqui comprobamos que si el numero es negativo la ecuacion no tiene solucion real
                            {
                                Console.WriteLine("La ecuacion no tiene solucion.");
                            }
                        }
                        else if (c == 0)// aqui entramos si c es igual a 0 y asignamos el valor del resultado a x1 y x2
                        {
                            x1 = 0;
                            x2 = -b / a;
                        }
                        else // si a b o c son distitos a 0 e hace el siguiente calculo y entra aqui
                        {
                            x1 = (-b + Math.Sqrt(b * b - 4 * a * c) / 2 * a);
                            x2 = (-b - Math.Sqrt(b * b - 4 * a * c) / 2 * a);
                        }
                        Console.WriteLine("Las soluciones son las siguientes:");
                        Console.WriteLine($"x1 = {x1}");
                        Console.WriteLine($"x2 = {x2}");

                    }
                    else if (ejercicio == 22)
                    {
                        //22. Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4 (por ejemplo 1984).
                        //Sin embargo los años múltiplos de 100 (aunque sean múltiplos de 4) sólo son bisiestos si a la vez son múltiplos de 400.
                        //(Por ejemplo 1800 no es bisiesto pero 2000 sí lo fue).

                        int año;// variable declarada y leida
                        Console.WriteLine("Introduzca un año: ");
                        año = int.Parse(Console.ReadLine());

                        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))//encapsulo con parentesis para poser usar tambien ||
                        {
                            Console.WriteLine($"El año {año} es bisiensto!!");// entramos si es bisiesto
                        }
                        else
                        {
                            Console.WriteLine($"El año {año} no es bisiesto!!");// entramos si no es bisiesto
                        }
                    }
                    else if (ejercicio == 23)
                    {
                        //23. Escribir un programa que ordene tres números de menor a mayor.

                        double numero1, numero2, numero3, numeroMenor, numeroMediano, numeroMayor;
                        Console.WriteLine("Escriba el primer numero: ");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el segundo numero: ");
                        numero2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el tercer numero: ");
                        numero3 = double.Parse(Console.ReadLine());

                        if (numero1 <= numero2 && numero1 <= numero3)
                        {//aqui entrariamso en el caso de que el numero uno sea el pequeño, entocnes comparariamos si el numero 2 y el 3 son los medianos o los grandes, en ambas posibilidades y "descartamos la posibilidad de que sean iguales"
                            numeroMenor = numero1;

                            if (numero2 <= numero3)
                            {
                                numeroMediano = numero2;
                                numeroMayor = numero3;
                            }
                            else
                            {
                                numeroMediano = numero3;
                                numeroMayor = numero2;
                            }//esta llave cierra si numero 1 es el pequeño                
                        }
                        else if (numero2 <= numero1 && numero2 <= numero3)
                        {//aqui entrariamso en el caso de que el numero dos sea el pequeño, entocnes comparariamos si el numero 1 y el 3 son los medianos o los grandes, en ambas posibilidades y "descartamos la posibilidad de que sean iguales"
                            numeroMenor = numero2;

                            if (numero1 <= numero3)
                            {
                                numeroMediano = numero2;
                                numeroMayor = numero3;
                            }
                            else
                            {
                                numeroMediano = numero3;
                                numeroMayor = numero2;
                            }//esta llave cierra si numero 2 es el pequeño 
                        }
                        else
                        {//aqui entrariamso en el caso de que el numero 3 sea el pequeño, entocnes comparariamos si el numero 2 y el 1 son los medianos o los grandes, en ambas posibilidades y "descartamos la posibilidad de que sean iguales"
                            numeroMenor = numero3;

                            if (numero1 <= numero2)
                            {
                                numeroMediano = numero1;
                                numeroMayor = numero2;
                            }
                            else
                            {
                                numeroMediano = numero2;
                                numeroMayor = numero1;
                            }//esta llave cierra si numero 3 es el pequeño                   
                        }
                        Console.WriteLine("Aqui te muestro por orden de menor a mayor los numeros que has introducido:");
                        Console.WriteLine($"menor: {numeroMenor}");
                        Console.WriteLine($"mediano: {numeroMediano}");
                        Console.WriteLine($"mayor: {numeroMayor}");




                    }







                }
                else if (ejercicio > 23) 
                {
                    Console.WriteLine("te has equivocado de ejercicio.");// en el caso de que se escriba el ejercicio que no es entrara aqui
                }

                Console.WriteLine("quieres escoger otro ejercicio?  S/N:");// pregutnamos y guardamos la respùesta
                string respuesta = Console.ReadLine();
                if (respuesta != "S" && respuesta != "s")
                {
                    break;
                }//fin del bucle
                
                
            }  
        }
    }
}
