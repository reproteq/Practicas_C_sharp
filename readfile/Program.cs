using System;

namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int count = 0;
                string ruta = @"C:\Users\w10\Desktop\file.txt";
                archivo = new System.IO.StreamReader(ruta);

                while(( linea = archivo.ReadLine()) != null)
                {

                    Console.WriteLine(linea);
                    count++;
                }

            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {

                if (archivo != null) archivo.Close();
                        
                 Console.WriteLine("se cerro la lectura"); 
            }



        }
    }
}
