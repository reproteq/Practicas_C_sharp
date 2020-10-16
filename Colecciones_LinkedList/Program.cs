using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Colecciones_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList");

             // este tipo de array necesita el parameto de longitud de array predefinido
            /*
            string[] arrWords = new string[5];
            arrWords[0] = "uno";
            arrWords[1] = "dos";
            arrWords[2] = "tres";
            arrWords[3] = "cuatro";
            arrWords[4] = "cinco";
             */

            // este tipo de array no necesita que se pase el parametro de longitud , simplemente agregas elementos 
            string[] arrWords = {"uno","dos","tres","cuatro","cinco ","seis","siete" };

            // linkedlist string , es una coleccion de objetos del tipo string en este caso que
            LinkedList<string> words = new LinkedList<string>(arrWords);

            Console.WriteLine("añadiendo elementos a la coleccion");

            foreach(string word in arrWords)
            {
                words.AddFirst(word);
                Console.WriteLine(word);
              
            }

            Console.WriteLine("Notas musicales collection");

            var tune = new LinkedList<string>();
            string []arrSolfa = {"do","re","mi","fa","so" };

            foreach(string s in arrSolfa)
            {
                //tune.AddFirst(s);
                tune.AddLast(s);
                Console.WriteLine("Se agrego "+ s);

            }
            Console.WriteLine("Los elementos de la colleccion de notas musicales son los siguientes");

            //tune.RemoveLast();

            foreach (string s in tune)
            {
                Console.WriteLine(s);
            }

          

            /*
            tune.AddFirst("do"); // do
            tune.AddLast("so"); // do - so
            tune.AddAfter(tune.First, "re"); // do - re- so
            tune.AddAfter(tune.First.Next, "mi"); // do - re - mi- so
            tune.AddBefore(tune.Last, "fa"); // do - re - mi - fa- so
            tune.RemoveFirst(); // re - mi - fa - so
            tune.RemoveLast(); // re - mi - fa
            LinkedListNode<string> miNode = tune.Find("mi");
            tune.Remove(miNode); // re - fa
            tune.AddFirst(miNode); // mi- re - fa
            foreach (string s in tune) Console.WriteLine(s);
            */


        }

 


    }
}
