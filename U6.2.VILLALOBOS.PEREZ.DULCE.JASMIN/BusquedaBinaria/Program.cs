using System;

namespace BusquedaBinaria
{
    class Program
    {      
        static void Main(string[] args)
        {
            //El algoritmo de búsqueda binaria es un excelente método para buscar 
            // datos dentro de una estructura(generalmente un arreglo unidimencional). 
            //Se le da el nombre de búsqueda binaria por que el algoritmo divide en dos 
            // el arregelo, aludiendo al concepto de bit, el cual puede tener dos estados.
            Buscar buscar = new Buscar();
            buscar.B1();
            
            // BASICAMENTE EL ARREGLO SE DIBIDE EN 2 PARTES Y LA BUSQUEDA SE LLEVA A CABO DE FORMA 
            // SIMULTAMEA , POR QUE SE RECORREN LAS DOS PARTES AL MISMO TIEMPO , SE PUEDE DECIR QUE 
            // ES MAS RAPIDO QUE LA BUSQUEDA SECUENCIAL POR QUE EN VEZ DE QUE SEA UNA BUSQUEDA ATRAVES DE TOOOS LOS ARREGLOS 
            // POR EJEMPLO SI EL LINEAL TIENE 10 Y EL BINARIO 10 : EL LINEAL TENDRA QUE PASAR POCADA UNO DE LOS ELEMNTOS 
            //SI EL ELEMENTO SE ENCUENTRA HASTA EL FINAL TENDRA QUE PASAR POR TODOS 
            //EN CAMBIO EN EL BINARIO EL TIWMPO DE BUSQUEDA SERA REDUCCIODO A LA MITAD ....

            Ejemplo2 buscaB = new Ejemplo2();
            buscaB.B2();
            Console.ReadKey();
        }
    }
}
