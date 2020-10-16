using System;
using System.Collections.Generic;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<string, int> Personas = new Dictionary<string, int>();

             
            int[] arrEdad = { 44, 39, 3, 66, 67 };
            string[] arrNom = { "Tato", "Vero", "Alia", "Gori", "Lupe" };



            for(int i=0;i<arrEdad.Length;i++)
            {
                 
                Personas.Add(arrNom[i], arrEdad[i]);
            }

            foreach(KeyValuePair<string, int> persona in Personas)
            {
                Console.WriteLine("Nom:" +  persona.Key + "  Edad:"+ persona.Value);
            }

            Console.WriteLine(":::::::::::::::::::array de diccionarios y array de objetos persona:::::::::::::");


            int dics = 5;
            Dictionary<string, int>[] matrix = new Dictionary<string, int>[dics];

            for(int i=0; i< dics; i++)
            {
                matrix[i] = new Dictionary<string, int>();


                Personas miPersona = new Personas(arrNom[i], arrEdad[i]);
                matrix[i].Add(arrNom[i],arrEdad[i]);
            }


            for (int i = 0; i < matrix.Length; i++)
            {

            }

        }
    }




    class Personas
    {
        public Personas(string nom , int edad)
        {
            this.nom = nom;
            this.edad = edad;

        }

        private string nom;
        private int edad;

        public string getNom()
        {
            return nom;
        }

        public int getEdad()
        {
            return edad;
        }
    }


}
