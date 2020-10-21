using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Globalization;

namespace Calculadora
{
    class CoreCalc 
    {
        public double coreCalc(string a, string b, string c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            provider.NumberGroupSeparator = ".";
            provider.NumberGroupSizes = new int[] { 3 };


            switch (c)
            {
                case "-":
                    //resta
                    A = Convert.ToDouble(a, provider);
                    B = Convert.ToDouble(b, provider);
                    resul = B - A;
                   // MessageBox.Show("resta" + A + c + B + "=" + resul);

                    break;

                case "+":
                    //suma
                    A = Convert.ToDouble(a, provider);
                    B = Convert.ToDouble(b, provider);
                    resul = A + B;
                   // MessageBox.Show("suma" + A + c + B + "=" + resul);

                    break;

                case "x":
                    //multi
                    A = Convert.ToDouble(a, provider);
                    B = Convert.ToDouble(b, provider);
                    resul = A * B;                    
                    break;

                case "/":
                    //div
                    A = Convert.ToDouble(a, provider);
                    B = Convert.ToDouble(b, provider);
                    resul = B / A;
                    break;

                case "%":
                    //  number = (percentage / 100) * totalNumber;
                    A = Convert.ToDouble(a, provider);
                    B = Convert.ToDouble(b, provider);
                    resul = ((B / 100) * A);
                    break;

            }

            return resul;
        }




        private double A;
        private double B;
        
        private double resul;
        private string a;
        private string b;
        private string c; // simbolo
    }



    class Atras
    {
        public string atras(string str)
        {
            this.str = str;
            lastChar = str.Remove(str.Length - 1, 1);


            return lastChar;
        }

        private string str;
        private string lastChar;
    }



    class TboxA
    {
        public string TboxAres 
        {
            get => tboxAres; 
            set => tboxAres = value;
        }
        private string tboxAres;
        ~TboxA()
        {
            Console.WriteLine("Destroy A");
        }
    }

 

    class TboxB
    {
        public string TboxBres
        {
            get => tboxBres;
            set => tboxBres = value;
        }
        private string tboxBres;
        ~TboxB()
        {
            Console.WriteLine("Destroy B");
        }

    }

    class TboxC
    {
        public string TboxCres
        {
            get => tboxCres;
            set => tboxCres = value;
        }
        private string tboxCres;
        ~TboxC()
        {
            Console.WriteLine("Destroy C");
        }

    }



}
