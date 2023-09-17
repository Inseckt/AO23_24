using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_nombre_en_aseriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {//Ahora voy a cambiar el titulo de la consola
            Console.Title = "OSCAR";
            Console.ForegroundColor = ConsoleColor.DarkRed; //Cambio el color a rojo de la consola
            //Voy a escribir mi nombre con asteriscos
            Console.WriteLine("*****  *****  *****  *****  *****\n"+ //Uso /n para hacer un salto de linea por que si no me estaba escribiendo todo en un salto de linea, me busque la vida con mi amigo google.
                              "*   *  *      *      *   *  *    *\n"+
                              "*   *  *****  *      *****  *****\n"+
                              "*   *      *  *      *   *  *    *\n"+
                              "*****  *****  *****  *   *  *     *\n"
                               );
            Console.ReadLine(); // Hacemos que la consola se abra para mostrarnos lo que acabamos de escribir en ella.
            
            
            
            
        }
    }
}
