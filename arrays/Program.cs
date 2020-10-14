using System;
using System.Security.Cryptography.X509Certificates;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //array 
            double[] arraySimple = new double[2];
            arraySimple[0] = 33.27;
            arraySimple[1] = 2.11;

            Console.WriteLine("array simple  con foreach");
            foreach(var values in arraySimple)
            {
                Console.WriteLine(values);
            }

            // array  de objeto Personas             
            Personas Mari = new Personas("Mari", 33);
            Personas Tato = new Personas("Tato", 44);
            Personas Ali = new Personas("ALi", 44);
            Personas Ver = new Personas("Ver", 44);

            Personas[] ArrPersona = new Personas[5];

            ArrPersona[0] = Mari;
            ArrPersona[1] = Tato;
            ArrPersona[2] = Ver;
            ArrPersona[3] = Ali;
            ArrPersona[4] = new Personas("alita", 2);

            Console.WriteLine("bucle for");
            for(int i=0; i< ArrPersona.Length; i++)
            {
                Console.WriteLine(ArrPersona[i].getNom()+ " " + ArrPersona[i].getEdad());
            }
           


            /// array objeto anonimo
            var personas = new[]
            {
                new{nombre="tt",edad =24},
                new{nombre= "sl",edad =33}
            };
            Console.WriteLine(personas[1]);

            // bucle foreach
            Console.WriteLine("bucle foreach");
            foreach(Personas variable in ArrPersona)
            {
                Console.WriteLine(variable.getNom() + " " + variable.getEdad());
            }


        }

    }


    class Personas 
    {
    
        public Personas(string Nom, int Edad) 
        {
            this.Nom = Nom;
            this.Edad = Edad;            
        }
        private string Nom;
        private int Edad;

        public string getNom()
        {
            return Nom;
        }

        public int getEdad()
        {
            return Edad;
        }


    }

}
