using System;
using System.Collections.Concurrent;

namespace practica_class_virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            avion miavion = new avion("tato");
            miavion.arrancar();
            miavion.conducir();
            miavion.getName();


            Console.WriteLine("polimorfismo en accion");
            coche micoche = new coche("mb");
            vehiculo mivehicul = micoche;
            mivehicul.conducir();// objeto polimorfico que distinge el objeto para darle una variante del metodo conducir si coche o si es avion
            mivehicul = miavion;
            mivehicul.conducir();
 
        }
    }


    class vehiculo
    {
        public vehiculo(string Vname)
        {
            name = Vname;
        }

        public void getName()
        {
            Console.WriteLine(name);
        }

        private string name;

        public void arrancar()
        {
            Console.WriteLine("arrancar base");
        }

        public void parar()
        {
            Console.WriteLine("parar base");
        }

        public  virtual void conducir()
        {
            Console.WriteLine("conducir base");
        }


        

    }



    class avion : vehiculo
    {
        public avion(string Aname):base (Aname)
        {
             
        }
        
        public override void conducir()
        {
            Console.WriteLine("conducir volar");
        }

    }



    class coche : vehiculo
    {
        public coche(string Cname):base(Cname)
        {

        }

        public override void conducir()
        {
            Console.WriteLine("conducir manejar");
        }

    }



}
