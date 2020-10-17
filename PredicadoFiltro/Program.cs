using System;
using System.Collections.Generic;

namespace PredicadoFiltro
{
    class Program
    {
        static void Main(string[] args)
        {
            //app que de devolvera una lista de nombres ademas nos dira si algun nombre coincide con uno elegido

            //  array nombres
            string[] arrNom = { "Tato", "Vero", "Alia", "Mary", "Migue", "Lupe", "Gori" };

            // array edades
            int[] arrEdad = { 44,12,5,23,55,32,4 };

            // array objeto del tipo persona que llevara 2 parametros un string como nombre y un entero como edad
            Persona[] personas = new Persona[7];

            // bucle for que rellena el array de objetos persona y les setea la propiedad de nombre i edad que coge de los arrays arrNom y arrEdad
            for(int i = 0; i < arrNom.Length; i++)
            { 
                 personas[i]= new Persona();
                 personas[i].Nom = arrNom[i];
                 personas[i].Edad = arrEdad[i];
            }

            // lista o coleccion  de objetos del tipo persona 
            List<Persona> ListaPersona = new List<Persona>();

            // rellenamos toda la lista o coleccion desde el array de objetos persona
            ListaPersona.AddRange(personas);

            // recorremos  con un bucle foreach todos los objetos del tipo persona y pintamos su propiedad Nom y edad
            foreach(Persona p in personas)
            {
                Console.WriteLine(p.Nom +" "+ p.Edad);
            }

            // predicado para el objeto persona el cual tiene  como parametro la funcion booleana que comprobara una condicion en el campo nom
            Predicate<Persona> Predicado = new Predicate<Persona>(ExisteAlia);

            // variable booleana que recorrera la lista o coleccion de personas y utiliza el metodo Exist para comprobar si existe o no
            bool Existe = ListaPersona.Exists(ExisteAlia);

            // si existe la variable booleana pintara un resultado positivo i de no existir pintara otro
            if (Existe) Console.WriteLine("Existe uan Alia en la lista de nombres");
            else Console.WriteLine("No hay ninguna Alia en la lista");

        }

        


        // funcion que chekeara si existe un nombe el el array de personas llamado alia
        // static para que sea accesible desde el main i boolean para que solo nos devuelva true o false
         static bool ExisteAlia(Persona personas)
         {
            if (personas.Nom == "Alia") return true;
            else return false;
         }

    }





    // clase Persona que tiene 2 campos nom i edad
    class Persona
    {
        private string nom;
        private int edad;

        public string Nom { get => nom; set => nom = value; }
        public int Edad { get => edad; set => edad = value; }
    }


}
