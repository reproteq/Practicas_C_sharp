using System;
using System.Runtime.InteropServices;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");

            Caballos Micaballo = new Caballos("Babieca");
            IPatasparasaltar Mibabieca = Micaballo;  // principio de sustitucion de la herencia ES UN ....
            ITienenPatas Mibabiecapatas = Micaballo;


            Console.WriteLine(Mibabieca.numeroPatas());// herencia ambigua
            Console.WriteLine(Mibabiecapatas.numeroPatas());// herencia ambigua

            Humanos Mihumano = new Humanos("Pepe");
            Gorilas Migorila = new Gorilas("Copito");
            Ballenas Miballena = new Ballenas("MoviDick");
            Lagartija milagartija = new Lagartija("Ttreptil");
            milagartija.getNombre();


            Mamiferos [] arrayAnimales = new  Mamiferos[4];




            arrayAnimales[0] = Micaballo;
            arrayAnimales[1] = Mihumano;
            arrayAnimales[2] = Migorila;
            arrayAnimales[3] = Miballena;
    

            for (int i=0;i < arrayAnimales.Length;i++)
            {
                //Console.WriteLine(arrayAnimales[i].getNombre());
                arrayAnimales[i].Respirar();
                arrayAnimales[i].Pensar();
            }

            Console.WriteLine("Fin Main");

        }
    }

    interface ITienenPatas
    {
        int numeroPatas();
    }

    interface IDeportesyAnimales
    {
        string tipodeporte();
        Boolean esolimpico();
    }

    interface IPatasparasaltar
    {
        int numeroPatas();
    }

   abstract class Animales
   {
        public void Respirar()
        {

        }

        public abstract void getNombre(); 

   }
         

    class Mamiferos : Animales // classe padre
    {


        public Mamiferos(string nombre)
        {
            nombreServivo = nombre;
        }

        public void Respirar()
        {
            Console.WriteLine("Todos los mamiferos reespirar");
            
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Todos los mamiferos piensan un poco");
        }

        private string nombreServivo;

        public override void getNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es {nombreServivo}");
            
            //return nombreServivo;
        }
    }

    class Lagartija : Animales
    {
        public Lagartija(string nombre)
        {
            this.miNombre = nombre;
        }

        private string miNombre;
        public override void getNombre()
        {
            Console.WriteLine($"Soy una lagartija y este es mi nombre {miNombre}");
        }

    }


    class Humanos : Mamiferos, ITienenPatas // clase humanos hereda de mamiferos y tiene una interface ITienenPatas
    {
        public Humanos(string nombreHumano) : base(nombreHumano)
        {

        }

        public override void Pensar()
        {
            Console.WriteLine("Los humanos piensan mucho");
        }

        public  int numeroPatas() //interface 
        {
            return 2;
        }

    }

    class Caballos : Mamiferos , ITienenPatas, IDeportesyAnimales, IPatasparasaltar
    {
        public Caballos(string nombreCaballo) : base(nombreCaballo)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Los caballos poco pueden pensar");
        }

        int ITienenPatas.numeroPatas() // ambiguedad de interface
        {
            return 4;
        }

        public string tipodeporte()
        {
            return "hipica";
        }

        public Boolean esolimpico()
        {
            return true;
        }

        int IPatasparasaltar.numeroPatas() //ambiguedad mismo nombre numropatas() 
        {
            return 2;
        }

    }

    class Gorilas : Mamiferos
    {
        public Gorilas(string nombreGorila) : base(nombreGorila)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Los gorialas tienen pensameinto instintivo avanzado");
        }

    }

    class Ballenas : Mamiferos
    {
        public Ballenas(string nombreBallena) : base(nombreBallena)
        {

        }

        public override void Pensar()
        {
            Console.WriteLine("Las ballenas tienen el cerebro muy complejo y piensan");
        }

    }
}