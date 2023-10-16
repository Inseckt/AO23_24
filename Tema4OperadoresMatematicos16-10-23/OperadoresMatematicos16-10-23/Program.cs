using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresMatematicos16_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores de asgnacion +=

            x += 9; //x pasa a valer 11
            x -= 2; //x pasa a valer 9
            //Operadores relacionales
            int s1 = 9;
            int s2 = 6;

            bool condicion1 = s1 == s2;  //false 
            bool condicion2 = s2 != 9;   //false 

            Console.WriteLine(s1 + " = "+ s2 + " ? " +condicion1);

            //Operadores logicos
            //Y logico -- && -- A && B -- Devuelve true si A y B son true

            bool condicion3 = (9 > 5) && (9 != 0);
            bool condicion4 = (9 == 0) && (9 > 5);

            //O logico >> || >> A || B >> Devuelve true si A o B son true
            bool condicion5 = (9 < 5) || (9 == 9);
            bool condicion6 = (9 < 5) || (9 % 2 == 0);
            bool condicion7 = (9 < 5) || (9 % 2 != 0);

            //No logico ! >> Niega lo que va despues
            // !true = False , !false = true;
            




        }
    }
}
