using System;
using System.Collections.Generic;


namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colecciones del namespace collections");

            List<int> numeros = new List<int>();

            Console.WriteLine("intruduce elementos en la coleccion (pulsa 0 para salir)");

            // bucle while que se repite hasta que pulsamos 0

            int elem = 1;

            while(elem != 0)
            {
                // parseamos el string escrito en consola a entero 
                elem = Int32.Parse(Console.ReadLine());
                //agregamos el elemento a la coleccion
                numeros.Add(elem);
            }

            // elemina el 0 que es el numero que pulsamos para salir y que lo agrega por defecto
            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Los numeros introducidos en la coleccion son:");

            // bucle que recorre por cada elemento
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }



        }
    }
     
}
