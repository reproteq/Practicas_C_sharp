using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCeroClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "0";
        }


        private void btnUnoClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "1";
        }

        private void btnDosClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "2";
        }

        private void btnTresClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "3";
        }

        private void btnCuatroClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "4";
        }
        private void btnCincoClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "5";
        }
        private void btnSeisClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "6";
        }
        private void btnSieteClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "7";
        }
        private void btnOchoClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "8";
        }
        private void btnNueveClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "9";
        }

        private void btnSumaClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "+";
        }

        private void btnRestaClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "-";
        }

        private void btnMultiplicacionClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "x";
        }

        private void btnDivisionClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "/";
        }

        private void btnPorcentajeClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "%";
        }

        private void btnParentesisAbrirClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "(";
        }

        private void btnParentesisCerrarClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = ")";
        }


        private void btnFlechaIzClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "<-";
        }


        private void btnFlechaDerClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "->";
        }

        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "Limpiar";
        }

        private void btnResultadoClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "=";
        }

        private void btnMasMenosClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "+ -";
        }

        private void btnComaClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = ",";
        }

        private void btnAClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "A";
        }
        private void btnBClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "B";
        }

        private void btnCClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "C";
        }

        private void btnDClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "D";
        }

        private void btnEClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "E";
        }

        private void btnFClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "F";
        }


        private void btnHexClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "Hex";
        }
        private void btnDecClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "Dec";
        }

        private void btnOctClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "Oct";
        }

        private void btnBinClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "Bin";
        }

        private void btnAtrasClick(object sender, RoutedEventArgs e)
        {
            TBoxResultado.Text = "Atras";
        }






    }







}
