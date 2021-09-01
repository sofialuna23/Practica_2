using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
//    Crear tres variables de tipo Int y asisgnnarlees valorees estaticos
//        crear tres variables de tipo int la cual guardara la suma de las tres variables anteriores
//        Mostrar en pantalla el valor de suma, con el siguiente mensaje "El valor de la suma es" <suma>
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;
            int suma = numero_1 + numero_2 + numero_3;
            Console.WriteLine("El valor de Suma es:" + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
