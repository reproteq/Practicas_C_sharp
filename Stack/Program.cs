using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack collection!");

            Stack <string> StackCollection = new Stack <string>();
            /*
            var arrStr = new string[4];
            arrStr[0] = "Uno";
            arrStr[1] = "Dos";
            arrStr[2] = "Tres";
            arrStr[3] = "Cuatro";
            */

            string[] arrStr = { "Uno", "Dos", "Tres", "Cuatro" };

            foreach (string s in arrStr)
            {
                StackCollection.Push(s);
            }

            Console.WriteLine("Los elementos del arr se pasaron al stack");

            foreach (string s in StackCollection)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(":::::::agregamos a la pila con push:::::::::::::::::::");

            StackCollection.Push("Cinco");


            foreach (string s in StackCollection)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("::::::::::quitamos de la pila con pop ::::::::::::::::");

            StackCollection.Pop();
            foreach (string s in StackCollection)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("::::::::::vemos el indice de  pila con peek ::::::::::::::::");
            Console.WriteLine(StackCollection.Peek());

             
        }
    }
}
