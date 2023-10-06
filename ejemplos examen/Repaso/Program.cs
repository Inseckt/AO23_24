using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 valores
            int a, b, c;
            double media, modulo;
            Console.WriteLine(" valor A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("valor B ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("valor C ");
            c = int.Parse(Console.ReadLine());

            media = (a + b + c);
            modulo = Math.Sqrt(a * a + b * b + c * c);
            modulo = Math.Round(modulo, 2);
            
            int valorMasPequeno = Math.Min(a, b), c);




        }
    }
}
