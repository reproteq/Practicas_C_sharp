using System;
using System.ComponentModel;

namespace Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            Map Mapa1 = new Map();
            Console.WriteLine(Mapa1.InfoMap());

            Console.WriteLine(Mapa1.NewName("dtc"));

            Console.WriteLine(Mapa1.InfoMap());

            Map Mapa2 = new Map();

            Mapa2.NewName("EGR");

            Console.WriteLine(Mapa2.InfoMap());

        }
    }

    class Map 
    {
        private int id;
        private string name;
        private int indice;
        private int offet;
        private string addr;
        private long longitud;
        private int rows;
        private int cols;
        private bool parent;
        private bool child;

        public Map()
        {
            
            id = 1;
            name = "MapDefault";
            indice = 0;    
            offet = 12;
            addr = "10B1";
            longitud = 1222;
            rows = 1;
            cols = 1;
            parent = false;
            child = false;
        }

        public  int NewId(int arg) 
        {
          return id =  arg;
        }

        public string NewName(string arg)
        {
            return name = arg;
        }
        public int NewIndice(int arg)
        {
            return indice = arg;
        }
        public int NewOffset(int arg)
        {
            return offet = arg;
        }
        public string NewAddr(string arg)
        {
            return addr = arg;
        }
        public long NewLong(long arg)
        {
            return longitud = arg;
        }
 
        public int NewRows(int arg)
        {
            return rows = arg;
        }
        public int NewCols(int arg)
        {
            return cols = arg;
        }

        public bool NewParent(bool arg)
        {
            return parent = arg;
        }

        public bool NewChild(bool arg)
        {
            return child = arg;
        }




        public string InfoMap()
        {
            return   "INfoMpa  ID:"+id + " / Name: " + name + " / offset: " + offet + " / Addr: " + addr + " / long: " + longitud +
                " / Rows: "+ rows +" / Cols: " + cols +" / Parent: "+ parent +" / Child: "+child;
        }
    
    }
}
