using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Listbox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> ListPob = new List<Poblaciones>();
            ListPob.Add(new Poblaciones { Poblacion1="Madrid", Poblacion2="Barcelona", Temp1=33, Temp2=35 });
            ListPob.Add(new Poblaciones { Poblacion1 = "Benicarlo", Poblacion2 = "Kalig", Temp1 = 33, Temp2 = 22 });
            ListPob.Add(new Poblaciones { Poblacion1 = "Murcia", Poblacion2 = "Sevilla", Temp1 = 12, Temp2 = 43 });
            ListPob.Add(new Poblaciones { Poblacion1 = "Bilbao", Poblacion2 = "Badalona", Temp1 = 16, Temp2 = 26 });

            ListaPoblaciones.ItemsSource = ListPob;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 +" " + (ListaPoblaciones.SelectedItem as Poblaciones).Temp1
                +" " + (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " + (ListaPoblaciones.SelectedItem as Poblaciones).Temp2);
        }
    }

    public class Poblaciones
    {

        public string Poblacion1 { get; set; }
        public int Temp1 { get; set; }

        public string Poblacion2 { get; set; }
        public int Temp2 { get; set; }

        public int TempDif
        {
            get { return Temp2 - Temp1; }
            set { }             
        }
     

        

    }


}
