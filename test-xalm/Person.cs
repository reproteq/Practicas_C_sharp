using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_xalm
{
    class Person
    {
        // Definicion de variables miembro 
        private string name;
        private string lastName;
        // Constructor
        public Person(string name, string last_name)
        {
            // this hace referencia al objeto o instancia de la clase actual, su uso es opcional, pero obligatorio
            // cuando el nombre de una propiedad coincide con el numbre de un parametro
            this.name = name;  // obligatorio
            this.lastName = last_name; // opcional
        }

        // Definicion de propiedades

        // Las propiedades son la interfaz publica de los datos en una clase
        // se deben mantener las variables miembro privadas o protegidas, y si se desea exponer
        // publicamente se deben usar propiedades

        // Estas son propiedades de lectura/escritura
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        // Propiedad de solo lectura
        public string FullName
        {
            get { return this.Name + " " + this.LastName; }
        }


    }
}
