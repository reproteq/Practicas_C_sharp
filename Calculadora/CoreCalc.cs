using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculadora
{
    class CoreCalc
    {

        public double Resultado;

        public Operacion miOperacion = new Operacion();
    }





    class Operacion
    {

    }


    class Suma
    {
        public static double suma(double n1, double n2)
        {
            MessageBox.Show("Suma.suma");
            return n1 + n2;

        }
    }

    class Resultado
    {
        public static double resultado(double n1, double n2, Operacion operacion)
        {
            double res = n1;
         
            return res;
        }


        public double n2;
        public double n1;
        public double res;
    }

}
