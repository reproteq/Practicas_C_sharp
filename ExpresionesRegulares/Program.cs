using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Alejandro g y mi numero es 838-99-22-12 , vivo en beni provicina Castellón cp 12883";

            string patt = "[A]";

            string patt2 = @"\d{3}";

            Regex miRegex = new Regex(patt);
            Regex miRegex2= new Regex(patt2);


            MatchCollection miMach = miRegex.Matches(frase);

            MatchCollection miMach2 = miRegex2.Matches(frase);

            if (miMach.Count >= 0)
            {
                Console.WriteLine("se encontro algun resultado");
            }
            else Console.WriteLine("nada no hubo suerte con la busqueda");



            if (miMach2.Count >= 0)
            {
                Console.WriteLine("se encontro el patron de 3 digitos decimales");
            }
            else Console.WriteLine("nada no hubo suerte con la busqueda");



        }
    }
}
