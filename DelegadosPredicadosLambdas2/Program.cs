using System;

namespace DelegadosPredicadosLambdas2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciacion del la calsse MnsjA en el objeto de tipo delegate que recien creamos y le asignamos el nombre miOjetoDelegado
            objDelegado miObjDelegado = new objDelegado(MnsjA.Mensaje);

            // declaracion y asignacion de la variable string mnsj
            string mnsj = "Hola que tal";

            // llamda al objeto midelegado y le pasamos el string como parametro que requiere la class a la cual esta intanciando el objeto
            miObjDelegado(mnsj);
            Console.WriteLine("::::::::::::::::::::::::::");

            miObjDelegado = new objDelegado(MnsjB.Mensaje);


            mnsj = "adios hasta luego";

            miObjDelegado(mnsj);

        }

        // declaracion del objeto delegate, void xq no devuelve nada , le pasaremos un str como param
        delegate void objDelegado(string mnsj);
    }



    // clase  sin construcctor o por defecto , con metodo publico ,  static para ser accesible desde el main, void pq no devuelve nada y con un str como parametro
    class MnsjA
    {
        public static void Mensaje(string mnsj) 
        {
            
            Console.WriteLine("Mensaje A class {0}", mnsj);
        
        }
        

    }


    class MnsjB
    {
        public static void Mensaje(string mnsj)
        {
            Console.WriteLine("Mensaje B class  {0}", mnsj);
        }

    }

}
