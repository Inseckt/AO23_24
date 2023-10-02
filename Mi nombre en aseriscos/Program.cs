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
            Console.ForegroundColor = ConsoleColor.DarkRed; //Cambio el color a rojo de la consola oscar tomas fernandez sayar
            //Voy a escribir mi nombre con asteriscos
            Console.WriteLine("*****  *****  *****  *****  *****    *******  *****  **     **  *****  *****   *****  *****  *****    *   *  *****  *   *  ****    *****  *****   *****  *****  *     *  *****  *****\n" + //Uso 2 cosas, la primera "+" para que me reconozca los saltos de linea y el 2ª /n para hacer un salto de linea por que si no me estaba escribiendo todo en una linea, sin leerme las demas. Me busque la vida con mi amigo google.
                              "*   *  *      *      *   *  *    *      *     *   *  * *   * *  *   *  *       *      *      *    *   **  *  *   *  **  *  *   *   *         *    *      *   *   *   *   *   *  *    *\n"+
                              "*   *  *****  *      *****  *****       *     *   *  *   *   *  *****  *****   ****   ***    *****    * * *  *****  * * *  *    *  ***    ******  *****  *****    * *    *****  *****\n"+
                              "*   *      *  *      *   *  *    *      *     *   *  *       *  *   *      *   *      *      *    *   *  **  *   *  *  **  *   *   *       *          *  *   *     *     *   *  *    *\n"+
                              "*****  *****  *****  *   *  *     *     *     *****  *       *  *   *  *****   *      *****  *     *  *   *  *   *  *   *  ****    *****  *****   *****  *   *     *     *   *  *     *\n" +


                              "                *\n" +
                              "        *                *\n" +// hago los 2 en el mismo ejemplo
                              "*               *              *\n"
                               );
            Console.ReadLine(); // Hacemos que la consola se abra para mostrarnos lo que acabamos de escribir en ella.
            
            
            
            
        }
    }
}
