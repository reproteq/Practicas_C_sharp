using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colecciones Queue");


            Queue<int> numeros = new Queue<int>();

            int[] arrNumeros = { 1, 2, 3, 4, 5, 6 };

            foreach(int n in arrNumeros)
            {
                numeros.Enqueue(n);
            }

            Console.WriteLine("El array se volco en la coleccion a continuacion mostrando el contenido");

            foreach (int n in numeros) Console.WriteLine(n);

            Console.WriteLine("Algunos ejemplos");

            numeros.Dequeue();

            foreach (int n in numeros) Console.WriteLine(n);

            Console.WriteLine("Algunos ejemplos");


            // Creates and initializes the source Queue.
            Queue<string> mySourceQ = new Queue<string>();
            mySourceQ.Enqueue("three");
            mySourceQ.Enqueue("napping");
            mySourceQ.Enqueue("cats");
            mySourceQ.Enqueue("in");
            mySourceQ.Enqueue("the");
            mySourceQ.Enqueue("barn");

            foreach (string s in mySourceQ) Console.WriteLine(s);

            Console.WriteLine("::::::::::::::::::::");
            // Creates and initializes the one-dimensional target Array.
            string[] myTargetArray = new string[9];
            myTargetArray.SetValue("The", 0);
            myTargetArray.SetValue("quick", 1);
            myTargetArray.SetValue("brown", 2);
            myTargetArray.SetValue("fox", 3);
            myTargetArray.SetValue("jumps", 4);
            myTargetArray.SetValue("over", 5);
            myTargetArray.SetValue("the", 6);
            myTargetArray.SetValue("lazy", 7);
            myTargetArray.SetValue("dog", 8);

            // Displays the values of the target Array.
            foreach (string s in myTargetArray) Console.WriteLine(s);

            Console.WriteLine("::::::: volcando coleccion en array :::::::::::::");

            Object[] myStandardArray = mySourceQ.ToArray();

            foreach (string s in myStandardArray) Console.WriteLine(s);

            Console.WriteLine("::::::: overwrite array desde coleccion :::::::::::::");

 

        }
    }
}
