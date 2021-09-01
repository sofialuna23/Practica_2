using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String dato = "";
            int edad = 0 ; 

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            dato = Console.ReadLine();
            edad = Convert.ToInt32(dato);
            Console.WriteLine("\n Te llamas " + nombre + " y tienes {0}", edad + " años ");
            Console.WriteLine("\n \n -- Presiona cualquier tecla para continuar --");
            Console.ReadKey();
        }
    }
}
