using System;

namespace Genericos2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 3;
            Console.WriteLine("Clase generica de objetos");

            AlmacenObjetos<Empleados> miAlmacen = new AlmacenObjetos<Empleados>(numero);

            miAlmacen.agregaElemento(new Empleados(302,"Tati"));
            miAlmacen.agregaElemento(new Empleados(3300,"Misifu"));
            miAlmacen.agregaElemento(new Empleados(2330,"Alita"));

            Empleados salarioEmpleado = miAlmacen.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());

            Console.WriteLine(salarioEmpleado.getNom());

            Console.WriteLine("bucle for para ver todos los objetos del array");
            miAlmacen.mostrarTodos();

            //
            Console.WriteLine("bucle par aver contenido del objeto empleados ");

            for(int i =0; i<numero; i++)
            {
                Empleados empleado = miAlmacen.getElemento(i);
                Console.WriteLine(empleado.getNom());
                Console.WriteLine(empleado.getSalario());
            }

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

        public void mostrarTodos()
        {
            for (int i = 0; i < arrObjeto.Length; i++){

                Console.WriteLine(arrObjeto[i]);
            }

        }

        private int z;// num de elementos del array
        private T Obj;// objeto que sera almacenado en eel array
        private int i = 0;// contador del array
        private T[] arrObjeto; //array de objetos
    }


    class Empleados
    {
        public Empleados(double salario, string nom)
        {
            this.salario = salario;
            this.nom = nom;

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
