using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged_Ejemplo
{
    public class JuntaNom : INotifyPropertyChanged
    {

        private string nom, ape, nomape;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public  string Nom
        {
            get { return nom; }
            set { nom = value;
                OnPropertyChanged("NomApe");
            }

        }


        public string Ape
        {
            get { return ape; }
            set { ape = value;
                OnPropertyChanged("NomApe");
            }

        }


        public string NomApe
        {
            get { return nomape = nom +" " + ape ; }
            set { nomape = value;
                
            }

        }

    }




}
