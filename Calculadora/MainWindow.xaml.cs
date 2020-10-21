using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
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

        CoreCalc miCoreCalc = new CoreCalc();
        Atras miAtras = new Atras();
        TboxA miTboxA = new TboxA();
        TboxB miTboxB = new TboxB();
        TboxC miTboxC = new TboxC();
             

        // click botones de la calculadora

        private void btnCeroClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "0";
            TBoxA.Text = miTboxA.TboxAres;
          
            
        }


        private void btnUnoClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres +="1";
            TBoxA.Text = miTboxA.TboxAres; 
        }

        private void btnDosClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "2";
            TBoxA.Text = miTboxA.TboxAres;
        }

        private void btnTresClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "3";
            TBoxA.Text = miTboxA.TboxAres;
        }

        private void btnCuatroClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "4";
            TBoxA.Text = miTboxA.TboxAres;
        }
        private void btnCincoClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "5";
            TBoxA.Text = miTboxA.TboxAres;
        }
        private void btnSeisClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "6";
            TBoxA.Text = miTboxA.TboxAres;
        }
        private void btnSieteClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "7";
            TBoxA.Text = miTboxA.TboxAres;
        }
        private void btnOchoClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "8";
            TBoxA.Text = miTboxA.TboxAres;
        }
        private void btnNueveClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "9";
            TBoxA.Text = miTboxA.TboxAres;
        }

        // ataras
        private void btnAtrasClick(object sender, RoutedEventArgs e)
        {
            // TBoxA.Text = "Atras";
            if (TBoxA.Text != "") 
            { 
                TBoxA.Text = miTboxA.TboxAres;
                var atr = miAtras.atras(TBoxA.Text);
                TBoxA.Text = atr;
                 miTboxA.TboxAres = atr;
            }
            else { MessageBox.Show("No hay nada que borrar , Por favor introduce un numero"); };
        }

        // decimals

        private void btnComaClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += ",";
            TBoxA.Text = miTboxA.TboxAres;
           // miRegEx.regex(".", TBoxA.Text);
        }

        // operaciones
        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            // TBoxA.Text = "Limpiar";
            TBoxA.Text = ""; // limpiamos el tboxa para  poder poner el otro numero para poder operar
            miTboxA.TboxAres = "";

            TBoxB.Text = ""; // limpiamos el tboxb para  poder poner el otro numero para poder operar
            miTboxB.TboxBres = "";

            TBoxC.Text = ""; // limpiamos el tboxc para  poder poner el otro numero para poder operar
            miTboxC.TboxCres = "";

        }

        //operacion resultado simbolo = 
        private void btnResultadoClick(object sender, RoutedEventArgs e)
        {
            // miTboxA.TboxAres += "=";
            if (TBoxA.Text != "")
            {
                double res = miCoreCalc.coreCalc(miTboxA.TboxAres, miTboxB.TboxBres, miTboxC.TboxCres);
                TBoxA.Text = res.ToString();
                miTboxA.TboxAres = res.ToString();
            }
            else { MessageBox.Show("Por favor introduce un numero"); };
            //limpiamos c b
            TBoxB.Text = ""; // limpiamos el tboxb para  poder poner el otro numero para poder operar
            miTboxB.TboxBres = "";

            TBoxC.Text = ""; // limpiamos el tboxc para  poder poner el otro numero para poder operar
            miTboxC.TboxCres = "";


        }

        private void btnSumaClick(object sender, RoutedEventArgs e)
        {
            if (TBoxA.Text != "")
            {
                miTboxC.TboxCres = "+"; // seteamos la propiedad del objeto c con el operador que tiene  que guardar
                TBoxC.Text = miTboxC.TboxCres; // le pasamos el valor al tbox c para que muestre el tipo de operacion que se va a realizar

                miTboxB.TboxBres = miTboxA.TboxAres;  // seteamos la propiedad del objeto b con el valor que se piko en la calc pasando el valor de tboxA a tboxB          
                TBoxB.Text = miTboxB.TboxBres; // le pasamos el valor a tbox b para que muestre el valor numerico que se piko y con el cual se va a operar

                TBoxA.Text = ""; // limpiamos el tboxa para  poder poner el otro numero para poder operar
                miTboxA.TboxAres = "";
            }
            else 
            { 
                MessageBox.Show("Por favor introduce un numero"); 
            }

        }

        private void btnRestaClick(object sender, RoutedEventArgs e)
        {
            if (TBoxA.Text != "")
            {
                miTboxC.TboxCres = "-";
                TBoxC.Text = miTboxC.TboxCres;
                // pasamos el valor de tboxa a tboxb
                miTboxB.TboxBres = miTboxA.TboxAres;
                TBoxB.Text = miTboxB.TboxBres;

                TBoxA.Text = ""; // limpiamos el tboxa
                miTboxA.TboxAres = "";
            }
            else 
            { 
                MessageBox.Show("Por favor introduce un numero"); 
            }
        }

        private void btnMultiplicacionClick(object sender, RoutedEventArgs e)
        {
            if (TBoxA.Text != "")
            {
                miTboxC.TboxCres = "x"; // seteamos la propiedad del objeto c con el operador que tiene  que guardar
                TBoxC.Text = miTboxC.TboxCres; // le pasamos el valor al tbox c para que muestre el tipo de operacion que se va a realizar

                miTboxB.TboxBres = miTboxA.TboxAres;  // seteamos la propiedad del objeto b con el valor que se piko en la calc pasando el valor de tboxA a tboxB          
                TBoxB.Text = miTboxB.TboxBres; // le pasamos el valor a tbox b para que muestre el valor numerico que se piko y con el cual se va a operar

                TBoxA.Text = ""; // limpiamos el tboxa para  poder poner el otro numero para poder operar
                miTboxA.TboxAres = "";
            }
            else 
            {
                MessageBox.Show("Por favor introduce un numero");
            }
        }

        private void btnDivisionClick(object sender, RoutedEventArgs e)
        {
            if (TBoxA.Text != "")
            {
                miTboxC.TboxCres = "/"; // seteamos la propiedad del objeto c con el operador que tiene  que guardar
                TBoxC.Text = miTboxC.TboxCres; // le pasamos el valor al tbox c para que muestre el tipo de operacion que se va a realizar

                miTboxB.TboxBres = miTboxA.TboxAres;  // seteamos la propiedad del objeto b con el valor que se piko en la calc pasando el valor de tboxA a tboxB          
                TBoxB.Text = miTboxB.TboxBres; // le pasamos el valor a tbox b para que muestre el valor numerico que se piko y con el cual se va a operar

                TBoxA.Text = ""; // limpiamos el tboxa para  poder poner el otro numero para poder operar
                miTboxA.TboxAres = "";
            }
            else 
            { 
                MessageBox.Show("Por favor introduce un numero"); 
            }
        }

        private void btnPorcentajeClick(object sender, RoutedEventArgs e)
        {
            if (TBoxA.Text != "")
            {
                miTboxC.TboxCres = "%"; // seteamos la propiedad del objeto c con el operador que tiene  que guardar
                TBoxC.Text = miTboxC.TboxCres; // le pasamos el valor al tbox c para que muestre el tipo de operacion que se va a realizar

                miTboxB.TboxBres = miTboxA.TboxAres;  // seteamos la propiedad del objeto b con el valor que se piko en la calc pasando el valor de tboxA a tboxB          
                TBoxB.Text = miTboxB.TboxBres; // le pasamos el valor a tbox b para que muestre el valor numerico que se piko y con el cual se va a operar

                TBoxA.Text = ""; // limpiamos el tboxa para  poder poner el otro numero para poder operar
                miTboxA.TboxAres = "";

            }
            else 
            { 
                MessageBox.Show("Por favor introduce un numero"); 
            }
        }

        private void btnParentesisAbrirClick(object sender, RoutedEventArgs e)
        {

            TBoxA.Text = "(";
        }

        private void btnParentesisCerrarClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = ")";
        }


        private void btnFlechaIzClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = "<-";
        }


        private void btnFlechaDerClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = "->";
        }




        private void btnMasMenosClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = "+ -";
        }

        // hex bin dec oct
        private void btnAClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "A";
            TBoxA.Text = miTboxA.TboxAres;
        }
        private void btnBClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "B";
            TBoxA.Text = miTboxA.TboxAres;
        }

        private void btnCClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "C";
            TBoxA.Text = miTboxA.TboxAres;
        }

        private void btnDClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "D";
            TBoxA.Text = miTboxA.TboxAres;
        }

        private void btnEClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "E";
            TBoxA.Text = miTboxA.TboxAres;
        }

        private void btnFClick(object sender, RoutedEventArgs e)
        {
            miTboxA.TboxAres += "F";
            TBoxA.Text = miTboxA.TboxAres;
        }


        private void btnHexClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = "Hex";
        }
        private void btnDecClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = "Dec";
        }

        private void btnOctClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = "Oct";
        }

        private void btnBinClick(object sender, RoutedEventArgs e)
        {
            TBoxA.Text = "Bin";
        }







    }







}
