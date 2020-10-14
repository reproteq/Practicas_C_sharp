using System;
using System.Collections.Concurrent;

namespace Structs_Y_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Empleado MiEmpleado1 = new Empleado(1299, 21);

            // MiEmpleado1.cambiarSalario(MiEmpleado1,100);
            // Console.WriteLine(MiEmpleado1);
            Currela miCurrela = new Currela("Paco", 1200,Bono.bueno);
            miCurrela.getResult();
            Console.WriteLine("El salario total incluido el bono de "+ miCurrela.getNom() + "es "+  miCurrela.getSalario());
        }
    }

    /*
    class Empleado  // struc Empleado usa el stack se copia cada vez i no se ve afectado por herencias
                    // no permite  la declaracion de contructor por defecto , se tiene que crear contructor
                    // el compilador no inicia los campos, puedes iniciarlos en el constructor
                    //no puede haber sobrecarga de constructores
                    // no heredan de otras clases pero si implementan interfaces
                    // son sealed (selladas)
                    // y  class usa el heap structura tipo arbol si modifica el padre los hijos heredan cambios


    {
        
        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }
 

        public int salarioBase;
        public int comision;

        public override string ToString()
        {
            return string.Format("El salario base es ({0},{1})", this.salarioBase, this.comision);
        }


        public void cambiarSalario(Empleado emp,int incremeto)
        {
            emp.salarioBase = salarioBase + incremeto;
            emp.comision = comision + incremeto;
        }


    }
        */
   
    enum Bono { bajo=100, normal= 300 , bueno=600 , alto=1000}
    

    class Currela
    {
        public Currela(string nom, double sueldo, Bono bonoCurrela)
        {
            this.nom = nom;
            this.sueldo = sueldo;
            this.bono = (double)bonoCurrela;
        }

        public string getNom()
        {
            return nom;
        }

        public double getSalario()
        {
            return sueldo + bono ;
        }

        public void getResult()
        {
            Console.WriteLine("El sueldo "+ sueldo +"  del currela  "+ nom +"y el bono es  "+bono);
        }


        private string nom;
        private double sueldo;
        private double bono;

    }



}
