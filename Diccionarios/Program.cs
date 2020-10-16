using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diccionarios , es un tipo de clase que permite guardar indices o keys con su value. Muy util y muy parecido a los array php");

            Dictionary<string, int> Edades = new Dictionary<string, int>();

            Edades.Add("Antonio", 22);
            Edades.Add("Paco", 32);


            foreach (KeyValuePair<string,int> persona in Edades)
            {
                Console.WriteLine("Key "+ persona.Key +"  Value "+ persona.Value);
            }

            Console.WriteLine(":::::::::::::::::: diccionario dias de la semana rellendo desde 2 arrays uno par el key y otro para value:::::::::::::::::::::::::::::");

            string[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            int[] dia = { 1, 2, 3, 4, 5, 6, 7 };

            Dictionary<int, string> DiaSemana = new Dictionary<int, string>();
                        
            for(int i=0;i<semana.Length;i++)
            {
                DiaSemana.Add(dia[i], semana[i]);                

            }

            foreach(KeyValuePair<int, string> n in DiaSemana)
            {
                Console.WriteLine("Dia en numero " + n.Key +"   Dia de la semana " + n.Value);
            }

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::");





        }
    }
}
