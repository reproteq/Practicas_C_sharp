using System;
using System.Dynamic;

namespace Calendario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calendar mical = new Calendar(Meses.Dic);
            Console.WriteLine(mical.getMimes());
        }
    }

    enum Meses { Ene=1, Feb=2, Mar=3, Abr=4, May=5, Jun=6, Jul=7, Ago=8, Sep=9, Oct=10, Nov=11, Dic=12 }

    class Calendar
    {
        public Calendar(Meses miMes)
        {
            this.mimes = (int)miMes;
        }

        private int mimes;

        public int getMimes()
        {
            return mimes;
        }

    }




}
