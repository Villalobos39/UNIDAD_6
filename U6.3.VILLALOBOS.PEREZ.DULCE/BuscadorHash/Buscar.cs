using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuscadorHash
{
    class Buscar
    {
        string opc;
        Hashtable Buscador = new Hashtable();
        bool encontrado = false;
        public void BuscadorH()
        {
            //ESTE METODO DE BUSQUEDA TIENE COMO PRINCIPAL FUNCION EL USO DE 
            //PALABRAS O CARACTERES CLAVES, DONDE PUEDEN IDENTIFICAR 
            Console.Write("\nBUSCAR DE LIBROS ISBN \n");
            //USAMOS LA COLLECTION POR DEFECTO DEL C# Hasttable
           Console.Write("\nISBN    ||   LIBROS  \n\n");
            Buscador.Add("5545588", "ARISTOTELES Y DANTE ");
            Buscador.Add("3554666", "LAS VENTAJAS DE SER INVISIBLE");
            Buscador.Add("2258967", "LA CHICA DEL TREEN ");
            Buscador.Add("2145698", "BUSCANDO ALASKA ");
            Buscador.Add("6548828", "LA LADRONA DEL LIBRO  ");
            Buscador.Add("7892463", "FURA DE MI ");
            Buscador.Add("3654882", "EL CODIGO DA VINCI");
            Buscador.Add("4587621", "DRACULA ");
            Imprimir(Buscador); //AÑADIMOS LOS CAMPOS 
            do
            {
                Console.Write("\nBUSCAR ISBN: ");
                opc = Console.ReadLine();
                //SE LE PIDE AL USUARIO QUE INGRESE SU BUSQUEDA EN ESTE CASO ES POR EL CODIGO UNICO DE LIBROS
                //ESTO DETERMINA SI SE ENCUENTRA O NO 
                if (Buscador.ContainsKey(opc))
                { //SI LA CARACTERISTICA CLAVE EXISTE EN EL CONTESTO DE LA TABLA HASH
                    Console.WriteLine("\nEL LIBRO : " + Buscador[opc] +" || SI SE ENCUENTRA ");
                    encontrado = true; // SI EL ELEMENTO FUE ENCONTRADO EL CICLO SE DETIENE 
                }
                else Console.WriteLine("\nNO SE EN CONTRO");
            }
            while (encontrado == false); // DE LO CONTRARIO SE REPITE HATSA QUE INGLESE UNO QUE SE ENCUENTRE 
        }

        public static void Imprimir(Hashtable Tabla)
        { //ESTE METODO IMPRIMI LOS DATOS AÑADISOS TAL COMO SON IGRESADOS 
            foreach (DictionaryEntry elemento in Tabla)
            { //Y ASI TAMBIEN EL ELEMNTO DE CADA CLAVE 

                Console.WriteLine("{0} || {1}", elemento.Key, elemento.Value);
            }
        }
    }
}