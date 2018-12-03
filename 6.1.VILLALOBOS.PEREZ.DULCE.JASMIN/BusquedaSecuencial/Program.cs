using System;
using System.Collections.Generic;

namespace BusquedaSecuencial
{
    class Program
    {
        static void Main(string[] args)
        {// Búsqueda lineal comprueba secuencialmente cada elemento 
         //de la lista hasta que encuentra un elemento que coincide 
         //con el valor de objetivo. Si el algoritmo llega al fin 
        //de la lista sin encontrar el objetivo, la búsqueda termina insatisfactoriamente.
            int numero, contador = 0, posicion = 1; //inicializo las variables 
            int[] vector = {3,65,4,2,15,7,8,9,0,13}; // EL CONTADOR i INICIALIZA EN 0 
            //que representa la posicion del vector 
            bool encontro = false;
            //si el numero se encuentra la pocion sera cierta 
            Console.Write("ELEMENTO A BUSCAR : ");
            numero = int.Parse(Console.ReadLine());
            // el ususrio ingresa el valor a buscar 
            while(!(encontro)&& contador <=10 )
            {//el ciclo se activa y se lleva acabo hasta que se encuentre el valor buscado 
                if(numero==vector[contador])
                {// si el valor esta en el arreglo entonces encontrado es cierto 
                    encontro = true;
                    posicion = contador; // la posicion es igual al contador 
                }
                contador = contador + 1;
            }
            if (encontro) // se imprime la posicion 
                Console.Write("ESTA EN LA POSICION  : "+(posicion+1));
            else if (numero!=vector[contador]) // de lo contrario 
                Console.Write("NO SE ENCUENTRA ");
            Console.ReadKey();
        }
    }
}
