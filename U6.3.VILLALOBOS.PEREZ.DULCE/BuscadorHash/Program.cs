using System;
using System.Collections;

namespace BuscadorHash
{
    class Program
    {
        static void Main(string[] args)
        {
            //El método llamado por transformación de claves(hash), permite aumentar la
            //velocidad de búsqueda sin necesidad de tener los elementos ordenados.Cuenta
            //también con la ventaja de que el tiempo de búsqueda es prácticamente
            //independiente del número de componentes del arreglo.
            // Trabaja basándose en una función de transformación o función hash(H) que
            //convierte una clave en una dirección(índice) dentro del arreglo.

            Buscar buscar = new Buscar();
            buscar.BuscadorH();
            Console.ReadKey();
        }
    }

}
