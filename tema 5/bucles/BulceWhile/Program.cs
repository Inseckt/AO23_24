using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulceWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

               /* int i;
                i = 100;
            
            while (i <= 150 )
            {
                if (i % 2 == 0)
                {                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + " ");

                }
                else
                {                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i + " ");
                }
                i++;
            }
            Console.WriteLine();

            /*mostrar los valores entre n y m, cambiando el color cada 10 valores
            int n, m;
            n = 100;
            m = 150;

            while (n <= m)
            {
                if (n )
            
            
            }*/


            int n = 100;
            int m = 150;
            int i = n;
            int contador = 0;

            Console.WriteLine("valores entre " + n + " y " + m);
            while (i <= m)
            {                
                if (i % 10 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + " ");
                }                
                if (i % 10 == 9)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i + " ");
                }
                i++;
            }
            Console.WriteLine();

            Console.ReadLine();
        }                  
    }
}
