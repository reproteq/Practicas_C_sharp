using System;
using System.IO;

namespace Class_Obj_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //numero de elementos que contendra el array
            int numElement = 4;
            int indexElement = 2;
            Console.WriteLine("Class ObjArr es un contenedor generico de ObjX");

            // instancia de la clase ObjArr en la que le pasamos num de elementos u objetos que contendra el array contenedor de objetos de tipo objX
            ObjArr<ObjX> miObjArr = new ObjArr<ObjX>(numElement);

            // agregamos al array miobjarr atraves del metodo creado addObj  y le pasamos como parametros el string name y el entero value que requiere objx
            miObjArr.addObj(new ObjX("TT", 1000));
            miObjArr.addObj(new ObjX("AliA", 2000));
            miObjArr.addObj(new ObjX("Vero", 3000)); // Resultado del ejercicio , indexelement 2 es vero 3000
            miObjArr.addObj(new ObjX("Mary", 4000));

            // creamos un campo name  de tipo objx para el elemento u objeto que nos indica el metodo getobj el cual solo necesita el indice del array
            ObjX ObjXname = miObjArr.getObj(indexElement);
            ObjX ObjXvalue = miObjArr.getObj(indexElement);

            // escribir en consola el campo name del objx que recupera atraves del metodo getname
            Console.WriteLine(ObjXname.getName());
            // escribir en consola el campo val del objx que recupera atraves del metodo getval
            Console.WriteLine(ObjXvalue.getVal());

        }
    }

    // Clase array que contendra los objetos y se denomina T solo poro convencion 
    class ObjArr<T>                        
    {

        // constructor de la clase con parametro de entero z que es el numero de objetos que contendra
        public ObjArr(int z)
        {
            objArr = new T[z];

        }

        // metodo publico y void porque no devuelve nada que se le pasa un objeto como parametro y lo agrega al array de objetos ademas incrementa i
        public void addObj(T Obj)
        {
            objArr[i] = Obj;
            i++;
        }

        // metodo publico que obtiene un elemento del array al pasarle por parametro un entero llamado i que es el indice del array de objetos
        public T getObj(int i)
        {
            return objArr[i];
        }

        // declaracion de variables para la clase ObjArr algunas no las inicializo solo las declaro

        //z numero de elementos totales del array
        private int z; 

        // i identificador de numero del elemento del array
        private int i = 0;

        // array de objetos
        private T[] objArr;

        // objeto
        private T Obj;


    }


    // clase ObjX es un ejemplo generico de una clase que es un objeto en este caso solo le pasamos 2 parametros uno es el string name y el otro un entero val
    class ObjX
    {
        // contructor de la clase que recibe 2 parametros, name y val 
        public ObjX(string name, int val)
        {
            this.name = name;
            this.val = val;

        }


        // getter para obtener el name que es de tipo string
        public string getName()
        {
            return name;
        }

        // getter para obtener el val que es del tipo entero
        public int getVal()
        {
            return val;
        }

        // declaracion de variables de la clase ObjX privadas para que solo sean accesibles desde la clase

        private string name;
        private int val;
    }

 
}
