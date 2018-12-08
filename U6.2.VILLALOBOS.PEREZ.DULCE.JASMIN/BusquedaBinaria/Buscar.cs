using System;
using System.Collections.Generic;
using System.Text;

namespace BusquedaBinaria
{
    class Buscar
    {
        int numero, posicion = 0, final = 9, mitad = 0;
        readonly int[] arreglo; bool encontro = false;
        //DECLARO LAS VARIABLES PRINIPALES 
        public void B1()
        {// EL ARREGLO TIENE UNA LONGITUD DE 10 ELEMENTOS 
            Console.Write("\n\nBUSQUEDA BINARIA : EJEMPLO 1\n");
            int[] arreglo = { 2, 5, 4, 9, 18, 24, 27, 39, 46, 55 };
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" || " + arreglo[i]);
            }
            Console.Write(" \nELEMENTO A BUSCAR : "); // SI EL ELEMENTOSE ENCUENTRA 
            numero = int.Parse(Console.ReadLine());
            while (!encontro && posicion <= final)
            { // PARA ELLO SE DIVIDE EL ARREGLO EN DOS PARTES : ESE ES LA PRINCIPAL FUNCION DE BUSQUEDA BINARIA 
                mitad = (int)((posicion + final) / 2); // UNA VEZ DIVIVIDA EN DOS 
                if (numero == arreglo[mitad]) encontro = true; // SE EVALUAN POR PARTES SI ASI SE PUEDEN BUSCAR AL MISMO TIEMPO 
                //LAS DOS PARTES CONTINUAMENTE EN MENOS TIEMPO QUE LO QUE LLEVA HACER LA BUSQUEDA DE FORMAS LINEAL 
                else if (numero < arreglo[mitad]) final = mitad - 1;
                // SI EL ELEMNTO SE UBICA EN ALGUNA DE ESAS PARTES SE MIDE LA POSICION EN VASE A EL VALOR FINAL
                else posicion = mitad + 1;
                //SI NO SE CUMPLEN NINGUNA SE REGRESA UN SIMPLE VALOR DE QUE INDICA LA POSICION DEL ELEMENTO
            }
            if (encontro) Console.Write("\nEL NUMERO : " + numero + " ESTA EN : " + (mitad + 1));
            else Console.Write("\nNO SE ENCUENTRA \n"); // ESTA FOEMA SE IMPRIME 
            Console.ReadKey();
        }
    }
}
