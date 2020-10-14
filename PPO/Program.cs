using System;

namespace PPO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Circulo mycirculo;
            //mycirculo = new Circulo();            
            //Console.WriteLine(mycirculo.calculaArea(3));

            ConvertidorEuro2Dolar obj;
            obj = new ConvertidorEuro2Dolar();
            Console.WriteLine(obj.Convierte(3));

            obj.euroNewPrice(22.2);
            Console.WriteLine(obj.Convierte(3));


        }
    }

    class Circulo 
    {

        double pi = 3.14;

        public double calculaArea(int radio) 
        {

            return pi * radio * radio;
        }
            
    }


    class ConvertidorEuro2Dolar 
    {
        private double euro = 1.23;
        
        public double Convierte(double dolar)
        {
            return euro * dolar;

        }
    

        public void euroNewPrice(double nuevoPrecio) 
        {
             euro = nuevoPrecio;
        
        }
    
    }


}
