using System;

namespace Genericos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AlmacenObjetos<Empleados> miAlmacen = new AlmacenObjetos<Empleados>(3);

            miAlmacen.agregaElemento(new Empleados(302));
            miAlmacen.agregaElemento(new Empleados(3300));
            miAlmacen.agregaElemento(new Empleados(2330));

            Empleados salarioEmpleado = miAlmacen.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());

        }
    }

    class  AlmacenObjetos<T>
    {

        public AlmacenObjetos(int z)
        {
             
            arrObjeto = new T[z];
        }

        public void agregaElemento(T Obj)
        {
           
            arrObjeto[i] = Obj;
            i++;

        }

        public T getElemento(int i)
        {
            return arrObjeto[i];
        }

        private int z;// num de elementos del array
        private T Obj;// objeto que sera almacenado en eel array
        private int i = 0;// contador del array
        private T[] arrObjeto; //array de objetos
    }


    class Empleados
    {
        public Empleados(double salario)
        {
            this.salario = salario;
           // this.nom = nom;

        }
        
        public double getSalario()
        {
            return salario;
        }

        public string getNom()
        {
            return nom;
        }

        private string nom;
        private double salario;

    }


}
