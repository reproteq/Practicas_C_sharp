using System;
using System.Collections.Generic;

namespace PredicadoFiltro
{
    class Program
    {
        static void Main(string[] args)
        {
            //app que de devolvera una lista de nombres que su edad sea mas de 18 años  


            string[] arrNom = { "Tato", "Vero", "Alia", "Mary", "Migue", "Lupe", "Gori" };
            int[] arrEdad = { 44,12,5,23,55,32,4 };
            Persona[] personas = new Persona[7];

            for(int i = 0; i < arrNom.Length; i++)
            { 
                 personas[i]= new Persona();
                 personas[i].Nom = arrNom[i];
                 personas[i].Edad = arrEdad[i];
            }

            List<Persona> ListaPersona = new List<Persona>();


            ListaPersona.AddRange(personas);

            foreach(Persona p in personas)
            {
                Console.WriteLine(p.Nom);
            }

            Predicate<Persona> Predicado = new Predicate<Persona>(ExisteAlia);

            bool Existe = ListaPersona.Exists(ExisteAlia);

            if (Existe) Console.WriteLine("Existe uan Alia en la lista de nombres");
            else Console.WriteLine("No hay ninguna Alia en la lista");

        }

        


        // funcion que chekeara si una edad entero  es superior a 18

         static bool ExisteAlia(Persona personas)
         {
            if (personas.Nom == "Alia") return true;
            else return false;
         }

    }






    class Persona
    {
        private string nom;
        private int edad;

        public string Nom { get => nom; set => nom = value; }
        public int Edad { get => edad; set => edad = value; }
    }


}
