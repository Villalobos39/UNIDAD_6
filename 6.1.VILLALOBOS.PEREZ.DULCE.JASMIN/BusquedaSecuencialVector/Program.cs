using System;

namespace BusquedaSecuencialVector
{
    class Program
    {

        static void Main(string[] args)
        {
            int numero, contador = 0, posicion = 1; //inicializo las variables 
            int[] vector = { 12, 3, 6, 4, 7, 8, 5, 2, 6, 5, 25, 9, 84, 64, 72 }; // el contador  i inicializa en 0 
            //que representa la posicion del vector 
            bool encontro = false;
            //si el numero se encuentra la pocion sera cierta 
            Console.Write("ELEMENTO A BUSCAR : ");
            numero = int.Parse(Console.ReadLine());
            // el ususrio ingresa el valor a buscar 
            while (!(encontro) && contador <= 15)
            {//el ciclo se activa y se lleva acabo hasta que se encuentre el valor buscado 
                if (numero == vector[contador])
                {// si el valor esta en el arreglo entonces encontrado es cierto 
                    encontro = true;
                    posicion = contador; // la posicion es igual al contador 
                }
                contador = contador + 1;
            }
            if (encontro) // se imprime la posicion 
                Console.Write("ESTA EN LA POSICION  : " + (posicion + 1));
            Console.ReadKey();
        }
    }
}
