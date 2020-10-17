using System;

namespace DelegadosPredicadosLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // creacion del objeto delegado con la llamada a la classe mnsbien. mensaje
            Objdelegado miDelegado = new Objdelegado(MsjBien.Mensaje);

            // llamada al objeto midelegado.
            miDelegado();

            // nueva intanciacion del objeto delegado con la llamada a la clase mnsje bienbenida y su metodo mensaje
            miDelegado = new Objdelegado(MsjDesp.Mensaje);

            // nueva llamada al objeto delegado que en este caso llama a otra clase i a otro metodo en este caso e mnsj despedida i a su metodo mensaje
            miDelegado();

        }


        // declaracion del objeto delegado, se configura con los mismos parametros que la clase que llamara , en este caso static void 
        delegate void Objdelegado();

    }

    // clase mnsje bienvenida con un metodo public = publico , static para que sea accesible desde el main  y void porque no devuelve nada solo pinta el mensaje. 
    class MsjBien
    {
        public static void Mensaje()
        {
            Console.WriteLine("hola");
        }
    }


    class MsjDesp
    {
        public static void Mensaje()
        {
            Console.WriteLine("adios");
        }

    }
}
