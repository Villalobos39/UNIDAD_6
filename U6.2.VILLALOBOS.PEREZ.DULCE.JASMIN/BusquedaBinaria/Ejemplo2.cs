using System;
using System.Collections.Generic;
using System.Text;

namespace BusquedaBinaria
{
    class Ejemplo2
    {
       
        public void B2()
        {
            int numero, posicion = 0,  mitad = 0;
            int[] arreglo; bool encontro = false;
            // EN ESTE EJEMPLO LE PERMITO AL USUARIO INGRESAR LA LONGITUD DEL ARREGLO 
            // Y LOS VALORES DE CADA ELEMENTO 
            Console.Write("\n\nBUSQUEDA BINARIA : EJEMPLO 2");
            Console.Write("\nNUMEROS : ");
            numero = int.Parse(Console.ReadLine());
            arreglo = new int[numero]; // AQUI LO ASIGNO Y LUEGO PASO A CAPTURARLOS 
            for (int cont = 0; cont < numero; cont++)
            {// CAPTURO LOS ELEMENTOS Y LOS INGRESO AL ARREGLO 
                Console.Write("NUMEROS : "); // GUARDANDO CADA ELMENTO EN EL ARREGLO 
                arreglo[cont] = int.Parse(Console.ReadLine());
            }// DESPEGO EL ORDEN NORMAL DE LOS NUMEROS 
            Console.Write("\n NUMEROS INGRESADOS : \n");
            // LOS IMPRIMO PARA SABER COMO SE INGRESARON 
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" || " + arreglo[i]);
            }

            int final = numero - 1; // REPRESENTA EL VALOR MAS CERCANO AL ULTIMO 

            Console.Write("\n");
            Console.Write(" \nELEMENTO A BUSCAR : "); // SI EL ELEMENTOSE ENCUENTRA 
            int valor = int.Parse(Console.ReadLine());
            while (!encontro && posicion <= final)
            { // PARA ELLO SE DIVIDE EL ARREGLO EN DOS PARTES : ESE ES LA PRINCIPAL FUNCION DE BUSQUEDA BINARIA 
                mitad = (int)((posicion + final) / 2); // UNA VEZ DIVIVIDA EN DOS 
                if (valor == arreglo[mitad]) encontro = true; // SE EVALUAN POR PARTES SI ASI SE PUEDEN BUSCAR AL MISMO TIEMPO 
                //LAS DOS PARTES CONTINUAMENTE EN MENOS TIEMPO QUE LO QUE LLEVA HACER LA BUSQUEDA DE FORMAS LINEAL 
                else if (valor < arreglo[mitad]) final = mitad - 1;
                // SI EL ELEMNTO SE UBICA EN ALGUNA DE ESAS PARTES SE MIDE LA POSICION EN VASE A EL VALOR FINAL
                else posicion = mitad + 1;
                //SI NO SE CUMPLEN NINGUNA SE REGRESA UN SIMPLE VALOR DE QUE INDICA LA POSICION DEL ELEMENTO
            }
            if (encontro) Console.Write("\nEL NUMERO : " + valor + " ESTA EN : " + (mitad + 1));
            else Console.Write("\nNO SE ENCUENTRA \n"); // ESTA FOEMA SE IMPRIME 
            Console.ReadKey();
        }
    }
}
