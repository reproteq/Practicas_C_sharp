using System;
using System.IO;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ManejoArchivos mimanejo = new ManejoArchivos();
            mimanejo.mensaje();

 
        }
    }


    class ManejoArchivos
    {
        StreamReader archivo = null;
        private string linea;
        //private string rutaArchivo = "C:\Users\w10\Desktop\file.txt";
        private int contador = 0;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"C:\Users\w10\Desktop\file.txt");
            

            while ((linea = archivo.ReadLine())  != null)
            {
                Console.WriteLine(linea);
                contador++;
            }

        }

        public void mensaje()
        {
            Console.WriteLine("Lineas tomadas {0}", contador);
        }

        ~ManejoArchivos() //destructor de la clase 
        {
            archivo.Close();
        }

    }


}
