using System;
using System.Collections;

namespace practicas2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("intro num mes");
            int mesintroducido = int.Parse(Console.ReadLine());
            try
            {

                Console.WriteLine(nomMes(mesintroducido));

            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);
            }

            
             

            Console.WriteLine("codigo");
        }


        public static string nomMes(int mes)
        {

            switch(mes)
            {

                case 1:
                    return "enero";



                case 2:
                    return "feb";


                case 3:
                    return "mar";

                case 4:
                    return "abr";

                case 5:
                    return "may";

                case 6:
                    return "jun";

                case 7:
                    return "hulio";

                default:
                    throw new ArgumentException();

            }



        }




    }
}
