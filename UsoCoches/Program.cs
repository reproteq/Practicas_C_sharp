using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche coche1;
            coche1 = new Coche();

            Console.WriteLine(coche1.InfoCoche());

            Coche coche2 = new Coche();
            coche2.NuevoLargo(22);

            Console.WriteLine(coche2.InfoCoche());

        }
    }

    class Coche 
    {

        private int ruedas;
        private bool aacc;
        private double largo;
        private double ancho;
        private string tapiceria;
        

        public Coche() 
        {
            ruedas = 4;
            aacc = true;
            largo = 12.2;
            ancho = 3.1;
                   
        }

        public void  NuevoLargo(double NuevoLargo) 
        {

            largo = NuevoLargo;
        }


        public string  InfoCoche()
        {
             return  "INFO COCHE " + "RUEDEAS "+ ruedas +"/"  +" acc" + aacc + "largo " + largo + "ancho " + ancho ;
        }



    }




}
