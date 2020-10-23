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

namespace ComboBox_ejemplo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();
            ListaCapitales.Add(new Capitales { capitales = "Madrid" });
            ListaCapitales.Add(new Capitales { capitales = "Paris" });
            ListaCapitales.Add(new Capitales { capitales = "NY" });
            ListaCapitales.Add(new Capitales { capitales = "Tokio" });
            ListaCapitales.Add(new Capitales { capitales = "Santiago" });
            ListaCapitales.Add(new Capitales { capitales = "Roma" });
            ComboboxCapitales.ItemsSource = ListaCapitales;

        }

        private void ChecTodos_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Paris.IsChecked = true;
            NY.IsChecked = true;
            Tokio.IsChecked = true;
            Santiago.IsChecked = true;
            Roma.IsChecked = true;

        }

        private void ChecTodos_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Paris.IsChecked = false;
            NY.IsChecked = false;
            Tokio.IsChecked = false;
            Santiago.IsChecked = false;
            Roma.IsChecked = false;
        }


        private void Individual_checked(object sender, RoutedEventArgs e)
        {
            if(Madrid.IsChecked == true && Paris.IsChecked == true && NY.IsChecked == true && Tokio.IsChecked == true && Santiago.IsChecked == true && Roma.IsChecked == true)
            {
                ChecTodos.IsChecked = true;
            }
            else 
            {
                ChecTodos.IsChecked = null;
            }

        }


        private void Individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Paris.IsChecked == false && NY.IsChecked == false && Tokio.IsChecked == false && Santiago.IsChecked == false && Roma.IsChecked == false)
            {
                ChecTodos.IsChecked = false;
            }
            else
            {
                ChecTodos.IsChecked = null;
            }

        }





    }




    public class Capitales
    {

       public string capitales { get; set; }

    }


}
