using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace PracticaMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            juego();

        }

        static void juego()
        {

            int veces = 0;
            int numintro;


            Random numero = new Random();

            int numAL = numero.Next(0, 100);

            Console.WriteLine("introduce un numero");
 


            while (numAL != numintro )
            {
                
                try {
                     
                    numintro = Int32.Parse(Console.ReadLine());
                }
                catch(Exception e){
                    numintro = 0;



                    Console.WriteLine("catch");

                }
                if (numAL > numintro) { Console.WriteLine("rand es mayor que el que as puesto"); }
                if (numAL < numintro) { Console.WriteLine("rand es menor que lo q as puesto"); }
                if (numAL == numintro) { Console.WriteLine($"acertaste {numAL}  es el  numero aleatorio"); }

                veces++;
                Console.WriteLine($"intentos : {veces}");
            }


        }
    }
}
