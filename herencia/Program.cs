using System;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Main!");

            Caballo Persa = new Caballo("Babieca");
            Humano Negro = new Humano("Pepe");
            Gorilas Rojo = new Gorilas("Moana");

            Persa.getNom();
            Persa.Galopar();
            Persa.Respirar();
            Console.WriteLine( "tengo " + Persa.numPatas());

            Mamiferos[] almacenDeAnimales = new Mamiferos[3];// array de objetos que comparten un metodo pensar i adoptara sentido en cada subclase de mamiferos class

            almacenDeAnimales[0] = Persa;
            almacenDeAnimales[1] = Negro;
            almacenDeAnimales[2] = Rojo;

            for(int i=0; i < almacenDeAnimales.Length; i++)
            {
                almacenDeAnimales[i].Pensar();// objeto poliformico
            }
        }
    }

    interface IMamiferosTerrestres     // interface es como una plantilla de  metodos que deveria implementar cada classe que la use
    {
        int numPatas();
    }

    class Mamiferos  // superclase padre
    {

        public Mamiferos(string nombre)  // constructor creado para no usar constructor por defecto
        {
            nombreSerVivo = nombre;

        }

        public virtual void Pensar()// metodo poliformico el metodo pensar adquier un sentido diferente en cada clase pero todos comparten la esencia seria como una version
        {
            Console.WriteLine("pienso");
        }

        public void Respirar()
        {
            Console.WriteLine("respiro");
        }

        public void CuidanCrias()
        {
            Console.WriteLine("cuido crias");
        }

        public void getNom()
        {
            Console.WriteLine(nombreSerVivo);
        }

        private string nombreSerVivo;
    }
        

    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        public Caballo(string nombreCaballo):base(nombreCaballo)
        {

        }

         public void Galopar()
        {
            Console.WriteLine("galopa");
        }

        public int numPatas()
        {
            return 4;
        }

    }


    class Humano : Mamiferos
    {

        public Humano(string nombreHumano) :base(nombreHumano)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("pensamiento avanzado");
        }

    }

    class Gorilas : Mamiferos
    {
        public Gorilas(string nombreGorilas) : base(nombreGorilas)
        {

        }

        public override void Pensar()
        {
            Console.WriteLine("pensamiento instintivo avanzado");
        }
        public void Trepar()
        {
            Console.WriteLine("trepa");

        }

    }




}
