using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AvisosTrafico nuevoAviso = new AvisosTrafico();
            nuevoAviso.mostrarAviso();
            Console.WriteLine(nuevoAviso.getFecha());

            AvisosTrafico nuevoAviso2 = new AvisosTrafico("Jefatura de trafico", "Avisa de sancion 3999 € ","12.1.2012");
            nuevoAviso2.mostrarAviso();
            Console.WriteLine(nuevoAviso2.getFecha());

        }
    }
}
