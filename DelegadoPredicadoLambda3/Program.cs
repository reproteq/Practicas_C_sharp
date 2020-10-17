using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace DelegadoPredicadoLambda3
{
    class Program
    {
        static void Main(string[] args)
        {
            // aplicacion que devolvera los numeros pares de una lista de numeros

            // declaracion e instanciacion de una lista de enteros donde guardaremos los numeros par que sean chekeados por la funcion booleana
            List<int> ListaNumeros = new List<int>();

            // array de numeros enteros
            int[] arrNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            // atraves del metodo addrange de las clases list agregamos todo el array de numeros enteros
            ListaNumeros.AddRange(arrNum);
            // hasta aqui tenemos los numeros del array en la lista

            //necesitamos un predicado delegado que compruebe con la funcion booleana chekpar si cumplen o no con la condicion
            // Recupera todos los elementos que coinciden con las condiciones definidas por el predicado especificado.
            // declaramos un predicado que devolvera un entero int e instanciamos el predicado que tiene como parametro la funcion booleana que chekeara el entero
            Predicate<int> miDelegadoPredicado = new Predicate<int>(ChekPares);

            // lista de enteros que recogera  atraves del metodo findall y pasandole como predicado la funcion booleana, todos los enteros que la funcion bool devuelva true
            List<int> ListaPares = ListaNumeros.FindAll(miDelegadoPredicado);

            // bucle  que por cada n  en la lista de pares escribe en consola
            foreach (int n in ListaPares)
            {
                Console.WriteLine(n);
            }
                  

                        
        }
               

        // funcion que comprueba que un numero  n es par  o no i devuelve un valor booleano

        public static bool ChekPares(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }



    }



}
