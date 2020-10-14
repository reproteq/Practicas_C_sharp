using System;
using System.Data;

namespace arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // array nums
            int[] arrayNums = new int[4];
            arrayNums[0] = 12;
            arrayNums[1] = 123;
            arrayNums[2] = 12334;
            arrayNums[3] = 84;

            ProcesaDatos(arrayNums);// llamada al metodo Procesadatos y como parametro se le pasa el arraynums

            ModificaDatos(arrayNums);// llamda al metodo modificadatos y como parametro se lel pasa el arraynums que modificara incrementado su valor en +11 
            Console.WriteLine("datos modificado");
            foreach(int i in arrayNums)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("bucle muestra como se modifico el arraynums despues llamarlo del metodo modificadatos");

            for (int i=0; i< arrayNums.Length; i++)
            {
                Console.WriteLine(arrayNums[i]);
            }

            // llamada al metodo que construye un array de forma dinamica

            int [] arraydinamic = devuelveArray();

            foreach(var i in arraydinamic)
            {
                Console.WriteLine(i);
            }


            // llamada al metodo que construye un array de forma dinamica
            Console.WriteLine("bucle for");

            int[] otroarray = devuelveArray();

            for(int i=0;i<otroarray.Length;i++)
            {
                Console.WriteLine(otroarray[i]);
            }





        }


        // metodo static void porque no devuelve nada que necesita un array de enteros int como parametro
        // basicamente pinta con un foreach todos los campos del array pasado como parametro desde main con la llamada al metodo
        static void ProcesaDatos(int [] datos)
        {
            foreach(int i in datos)
            {
                Console.WriteLine(i);
            }
        }


        static void ModificaDatos(int [] otrosdatos)
        {
            for(int i=0;i< otrosdatos.Length; i++)
            {
                otrosdatos[i] += 11;
                
            }


        }

        // metodo que construye un array y lo devuelve

        static int [] devuelveArray()
            {
            
            Console.WriteLine("cuantos elementos quieres que tenga el array?");
            string elementos = Console.ReadLine();

            int elem = int.Parse(elementos);

            int[] datos = new int[elem];

            for (int i=0; i<elem; i++)
            {
                Console.WriteLine($"introduce valores para elemento {i}");
                
                string valor = Console.ReadLine();
                int val = int.Parse(valor);
                datos[i] = val;
            }


            return datos;

            }



    }
}
