using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Almacen de objetos que usan interface, solo 3 de las clases cumplem el requisito de la interface");
            Console.WriteLine("Almacen para Empleados Director");

            AlmacenParaEmpleados<Director> miAlmacenEmpleados = new AlmacenParaEmpleados<Director>(3);
            Director miDirector = new Director(3200);
            Director miDirector2 = new Director(4900);
            Director miDirector3 = new Director(5700);

            miAlmacenEmpleados.addEmpleado(miDirector);
            miAlmacenEmpleados.addEmpleado(miDirector2);
            miAlmacenEmpleados.addEmpleado(miDirector3);
            Console.WriteLine("El salario del director2 es " + miDirector2.getSalario());

            //
            AlmacenParaEmpleados<Secretaria> miAlmacenEmpleados2 = new AlmacenParaEmpleados<Secretaria>(3);
            Secretaria miSecretaria = new Secretaria(1299);
            Secretaria miSecretaria2 = new Secretaria(2293);
            Secretaria miSecretaria3 = new Secretaria(4244);
            miAlmacenEmpleados2.addEmpleado(miSecretaria);
            miAlmacenEmpleados2.addEmpleado(miSecretaria2);
            miAlmacenEmpleados2.addEmpleado(miSecretaria3);
            Console.WriteLine("El salario de la secretaria3 es " + miSecretaria3.getSalario());

 
            //
            AlmacenParaEmpleados<Electricista> miAlmacenEmpleados3 = new AlmacenParaEmpleados<Electricista>(1);
            Electricista miElectricista = new Electricista(4299);


            
            //  esta es la unica clase que no implementa la interface a pesar de pasarle por parametro un entero llamdo edad, por lo tanto da error
            // en tiempo de compilacion puesto que no cumple el requisito del entero llamdo salario especificado en la interface 
         //   AlmacenParaEmpleados<Estudiante> miAlmacenEmpleados4 = new AlmacenParaEmpleados<Estudiante>(1);
            
         //   Estudiante miEstudiante = new Estudiante(24);
         //   miAlmacenEmpleados4.addEmpleado(miEstudiante);

        }
    }

    class AlmacenParaEmpleados <T> where T:IparaEmpleados 
    {
        public AlmacenParaEmpleados(int z)
        {
            ArrEmpleados = new T[z];
        }

        public T addEmpleado(T Obj)
        {
            return ArrEmpleados[i] = Obj;
        }

        public T getEmpleado(int i)
        {
            return ArrEmpleados[i];
        }

        private T[] ArrEmpleados;
        private T Obj;
        private int i = 0;
        private int z;
    }



    interface IparaEmpleados
    {
        double getSalario();
    }

    class Director :IparaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }


    class Secretaria : IparaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }


    class Profesor : IparaEmpleados
    {
        public Profesor(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }


    class Electricista : IparaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }

    class Estudiante
    {
        public Estudiante(int edad)
        {
            this.edad = edad;
        }
        private int edad;
    }



}

