using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre,ciudad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe una ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine(" Hola " + nombre + " Bienvenido a " + ciudad);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
