using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Empleado Tato = new Empleado("Tato");
            Tato.getNombre();
            //Tato.setSalario(1222);
            Tato.SALARIO = 1799;
           Console.WriteLine("El salario del empleado es " + Tato.SALARIO);
        }
    }

    //  classe con forma convencional  y clase con propiedad SALARIO
    class Empleado
    {
        public Empleado(string nom)
        {
            this._nom = nom;  
        }

        public string getNombre()
        {
            return _nom;
        }

        public double evaluaSalario(double _salario)
        {
            if (_salario < 0) return 0;
            else  return _salario;
        }
        //PROPIEDAD
        /*
        public double SALARIO
        {
            get{return this.salario;}
            set{this.salario = evaluaSalario(value); }
        }
        */

        //PROPIEDAD CON OPERADOR LAMBDA ademas por comvencion cuando es una propiedad se pone _ delante del campo
        public double SALARIO
        {
            get => this._salario;
            set => this._salario = evaluaSalario(value);
        }

        private string _nom;
        private double _salario;
    }

    /* 

    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nom = nombre;
        }

        public void getNombre()
        {
            Console.WriteLine(nom);
        }

        public double  setSalario(double salario)
        {
            if (salario < 0) this.salario = 0;
            else this.salario = salario; 

            return salario;
        }

        public double getSalario()
        {
            return salario;
        }


        private double salario;
        private string nom;
        

    }

    */


}
