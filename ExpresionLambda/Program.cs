using System;
using System.Collections.Generic;

namespace ExpresionLambda
{
    class Program
    {
        static void Main(string[] args)
        {
             

            List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9 };
            // lambda expresion
            List<int> npares = numeros.FindAll(n => n%2 == 0);

            foreach (int n in npares) { Console.WriteLine(n); }

            Console.WriteLine(":::::::::Lambda:::::::::");
            // lambda expresion
            npares.ForEach(n => Console.WriteLine(n));


            Console.WriteLine("::::: uso de delegado ::::::::::::::");
            // uso del delegado

            operacionMat sumar = new operacionMat(suma);

            Console.WriteLine(sumar(2,4));


            Console.WriteLine("::::::::version:Lambda:::::::::");
            // uso del delegado y de expresion lambda para sumar 2 enteros
            operacionMat sumarLambda = new operacionMat((n1, n2) => n1 +n2);


        }

        // declaracion del delegado
        public delegate int operacionMat(int n1, int n2);

        static int suma(int n1, int n2)
        {
            return n1 + n2;
        }


    }




}
