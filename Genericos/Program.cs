using System;
using System.ComponentModel;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ContenedorObjetos micontenedor = new ContenedorObjetos(4);
            //
            Empleado miempleado1 = new Empleado(199, "Tati");
            Empleado miempleado2 = new Empleado(3939, "veronike");
            Empleado miempleado3 = new Empleado(4299, "aliti");
            Empleado miempleado4 = new Empleado(699, "maricarmitis");

            micontenedor.AgregarObj(miempleado1);
            micontenedor.AgregarObj(miempleado2);
            micontenedor.AgregarObj(miempleado3);
            micontenedor.AgregarObj(miempleado4);

            Empleado nomDeEmpleado = (Empleado)micontenedor.getElemento(2);
             
            Console.WriteLine(nomDeEmpleado.getNom());

            /*
            //objtos tipo string
            micontenedor.AgregarObj("tato");
            micontenedor.AgregarObj("ali");
            micontenedor.AgregarObj("vero");
            micontenedor.AgregarObj("mari");
            */
          //  micontenedor.VerContenido();

        }
    }

    class ContenedorObjetos
    {
        public ContenedorObjetos(int z)
        {
            this.z = z;
            arrContenedor = new Object[z];

        }

        public void AgregarObj(Object Obj)
        {
            arrContenedor[i] = Obj;
            i++;
        }

        public Object getElemento(int i)
        {

            return arrContenedor[i];
        }

        
        public void VerContenido()
        {
            for (int j = 0; j < arrContenedor.Length; j++)
            {
                Console.WriteLine(arrContenedor[j]);
            }
        }


        private Object[] arrContenedor;
        
        private int z;
        private int i = 0;
 
    }

    class Empleado
    {
        public Empleado(double salario, string nom)
        {
            this.salario = salario;
            this.nom = nom;
        }

        public string getNom()
        {

            return nom;
        }
        private string nom;
        private double salario;
    }



}
