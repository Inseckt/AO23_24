using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_EjerciciosBoletin3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 4
              El programa debe solicitar al usuario que ingrese un número. Este número es recogido en una variable de tipo Double llamada radio.
              A continuación, se debe calcular en sendas variables, la longitud del círculo, el área y el volumen de la esfera.
              Para ello haced uso de una constante de tipo double denominada PI cuyo valor es 3.141516.
              Longitud = 2 * PI * radio.
              Area = PI * radio2
              Volumen = (4 / 3) * PI * radio3
              El programa debe mostrar estos resultados por pantalla.
              Realizar primero el pseudocódigo de la solución.*/
            Console.WriteLine("***EJERCICIO 4");
            //Vamos a solicitar que el usuario nos ingrese un numero(Radio) y a esribir la variable 
            Console.WriteLine("Escribe el valor del Radio: ");
            //Queda mas bonito con double radio, longitud, area, volumen; Por que asi nos evitamos declarar cada variable segun se va necesitoando, como double.
            double radio = double.Parse(Console.ReadLine()); 

            //Darle valir a PI que es una constante

            const double PI = 3.141516; 

            //Ahora calcular la longitud del circulo

            double longitud = 2 * PI * radio;

            //Ahora calcular el area

            double area = PI * Math.Pow(radio, 2);

            //Ahora calcular el volumen

            //VOLUMEN PARA EL EJERCICO8 double volumen = (4.0 / 3.0) * PI * Math.Pow(radio, 3);

            //Que aparezca en pantalla

            Console.WriteLine("Longuitud = " + longitud);
            Console.WriteLine("Area = " + area);
            //VOLUMEN PARA EL EJERCICO8 Console.WriteLine("Volumen = " +  volumen);

            /*Ejercicio 5: Diseñar un programa que pide al usuario que introduzca el precio 
             (variable Double) y la cantidad (variable Short) de un determinado producto.
             A continuación calcula el importe final que será precio* cantidad y muestra
             por pantalla el siguiente mensaje:
             “El precio del producto es x euros y la cantidad que compra es y por lo tanto debe pagar z euros.Vuelva pronto.”*/
            Console.WriteLine("***EJERCICIO 5");
            //Pedir que nos pongan el precio del producto con (double), nº decimal

            Console.WriteLine("Introduzca el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            //Pedir que nos ponga la cantidad con (short), nº entero corto
            Console.WriteLine("Introduzca la cantidad que va a comprar: ");
            short cantidad = Convert.ToInt16(Console.ReadLine());

            //Ahora tengo que hacer el calculo de las 2 variables, lo voy a usar utilizando 
            //double.

            double importeTotal = precio * cantidad;

            //Mostrar el mensaje: Uso Console.WriteLine($" y el las llaves {}, en vez de concatenar usando el operador "+" he buscado una forma de que el "texto
            //Sea más legible para poder asignar los valores de las variables dentro de una cadena ded texto que es larga. Como no me sabia el comando, lo he buscado.
            //"$" Simbolo del dolar, Colocarlo antes de una cadena de texto indica que se trata de una cadena interpolada. Esto permite insertar los valores de las variables
            //directamente en la cadenad de texto.
            //"{}" Las llaves especifican donde se deben insertar los valores de las variables y hacer que esos resultados se inserten en la cadena final.

            Console.WriteLine($"El precio del producto es {precio} y la cantidad que compra es {cantidad} por lo tanto debepagar {importeTotal} euros. Vuelva pronto.");

            /*EJERCICIO 6
             *Realizar un programa que solicite al usuario dos números y calcule guardándolo en 
             *SENDAS VARIABLES: la SUMA, la RESTA , y la MULTIPLICACIÓN de esos dos números y muestre por pantalla los resultados con mensajes como:
            “La suma es “ , suma.
            “La resta es “, resta.
            “La multiplicación es “, multiplicación.*/
            Console.WriteLine("***EJERCICIO 6");
            //Pedir el primer numero y darle el valor
            Console.WriteLine("Introduzca el primer numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            //Pedir el segundo numero y darle valor
            Console.WriteLine("Introduzca el segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());  

            //Calcular la suma, la resta y la multiblicacion
            double suma = numero1 + numero2;
            double resta = numero1 - numero2;
            double multiplicacion = numero1 * numero2;

            //Mostramos ahora los resultados, lo voy a probar igual que en el ejercicio anterior, ademas todo en una misma fila, o en la opcion de cada uno en una linea distinta
            //Veo que funciona: Console.WriteLine($"La suma es = {suma} . La resta es = {resta} . La multiplicacion es = {multiplicacion}");
            Console.WriteLine($"La suma es = " + suma); // Pruebo tambien concatenando con el operador "+" 
            Console.WriteLine($"La resta es = {resta}");
            Console.WriteLine($"La multiplicacion es = {multiplicacion}");

            //Ejercicio 7
            Console.WriteLine("*********EJERCICIO 7********");
            
            double celsius, fahrenheit;
            Console.WriteLine("Escribe los grados celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine("Grados fahrenheit: " + fahrenheit);

            //EJERCICIO 8

            //Declarar variables para almacenar los valores ingresados escritos por teclado

            double volumen, moles, temperatura; //Como estoy haciendo todos los ejercicios en el mismo, aqui me ha saltado como que la variable volumen esta siendo usada, en el ejercicio PI, voy a poner esa variable como comentario, para que se me aplique aqui.

            //Declarar como onstante de los gases ideales (R)
            const double R = 0.082;
            Console.WriteLine("***EJERCICIO 8");
            // Pedirle al usuario que ingrese el volumen, numero de moles y temperatura en Kelvin
            Console.Write("Ingrese el volumen en litros: ");
            volumen = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el numero de moles: ");
            moles = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la temperatura en Kelvin: ");
            temperatura = Convert.ToDouble(Console.ReadLine());

            //Ahora calcular la presion utilizando la formula de los gases ideales
            double presion = (moles * R * temperatura) / volumen;

            Console.WriteLine($"Con un volumen de {volumen} litros, y una temperatura de {temperatura} Kelvin, {moles} moles de un gas ideal tienen una presión de {presion} atmósferas");

            //ejercicio 10 Escribir un programa que lea las horas trabajadas en un mes y la tasa a la que se le paga cada hora y el IRPF que se aplica como impuesto.
            //EL programa debe calcular el salario bruto y el salario neto del trabajador:
            //El salario neto se calcula restando al salario bruto el IRPF.

            //Primero necesito saber que el usuario introduzca las horas trabajadas en un mes.
            Console.Write("Introduzca las horas trabajadas en un mes: ");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            //Segundo necesito saber que el usuario introduzca lo que le pagan por hora.
            Console.Write("Introduzca el pago por hora: ");
            double pagoPorHora = Convert.ToDouble(Console.ReadLine());

            //Pedirle al usuario que introduzca cuanto le quitan de IRPF como un porcentaje. //luego se apsara a decimal
            Console.Write("Introduzca el IRPF que le quitan de la nomina: ");
            double irpfPorcentaje = Convert.ToDouble(Console.ReadLine());

            // Calcular el salario bruto.
            double salarioBruto = horasTrabajadas * pagoPorHora;

            // Calcular el IRPF % porcentaje y convertirlo a decimal. Esta formula no recordaba o no me la sabia, la he buscado.
            double irpfDecimal = irpfPorcentaje / 100.0;

            // Calcular el salario neto restando el IRPF al salario bruto.
            double salarioNeto = salarioBruto - (salarioBruto * irpfDecimal);

            // Mostrar los resultados con mensajes descriptivos.
            Console.WriteLine($"El salario bruto es: {salarioBruto} euros.");
            Console.WriteLine($"El salario neto es: {salarioNeto} euros.");

            Console.WriteLine("***EJERCICIO 10");
            Console.ReadLine();


            









        }
    }
}
