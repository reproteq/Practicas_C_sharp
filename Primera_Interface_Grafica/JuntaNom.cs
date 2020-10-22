using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_Interface_Grafica
{
    public class JuntaNom : INotifyPropertyChanged
    {
        


        private string nom, ape, nomape;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
