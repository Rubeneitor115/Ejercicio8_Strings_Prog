/***
 * Ruben Bernal Ramos
 * CSI1
 */

namespace Ejercicio8_Strings_Prog
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 110324
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicación
        /// rbr - 110324
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Declaro las variables
            string frase, fraseFinal;
            char caracterReemplazar, caracterReemplazado;

            //Pido la frase por consola
            Console.WriteLine("Introduzca una frase: ");
            frase = Console.ReadLine();

            //Pido el caracter que se desea reemplazar
            Console.WriteLine("Introduzca el caracter que desee reemplazar: ");
            caracterReemplazado = Convert.ToChar(Console.ReadLine());

            //Pido el caracter por el que se desea reemplazar
            Console.WriteLine("Introduzca el caracter por el que desee reemplazar el caracter: " + caracterReemplazado);
            caracterReemplazar = Convert.ToChar(Console.ReadLine());

            //Reemplazo los caracteres
            fraseFinal = frase.Replace(caracterReemplazado, caracterReemplazar);

            //Muestro la frase resultante por consola
            Console.WriteLine("La frase resultante es: " + fraseFinal);
        }
    }
}