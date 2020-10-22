using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged_Ex2
{
    // clase publica i con una interface Inotifypropertychanged para detectar cambios en propiedades de objetos
    public class JoinTboxValues : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // metodo NotifyPropertyChanged es el encargado de detectar los cambios en las propiedades de los objetos que llevaran la llamada a este metodo
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // declaracion de variables str o campos de clase
        private string tbox1, tbox2, tbox3, tbox4;
        internal object Tbox;

        public string Tbox1 
        {
            get { return tbox1; }
            set { tbox1 = value;
                OnPropertyChanged("Tbox4"); // llamada al metodo onpropertychanged
            }
        }

        public string Tbox2
        {
            get { return tbox2; }
            set { tbox2 = value;
                OnPropertyChanged("Tbox4");
            }
        }

        public string Tbox3
        {
            get { return tbox3; }
            set { tbox3 = value;
                OnPropertyChanged("Tbox4");
            }
        }

        public string Tbox4
        {
            get { return tbox1 + " " + tbox2 + " " + tbox3 ; }
            set { tbox4 = value; }
        }

        
    }


}
