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

namespace INotifyPropertyChanged_Ex2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // inicilizacion de la instancia de la clase jointboxvalues y seteo  de los campos de dicha clase
            miJoinTboxValues = new JoinTboxValues { Tbox1="A" , Tbox2="B", Tbox3="C" };
           // miJoinTboxValues = new JoinTboxValues { };

            // datacontext de la instacia de la clase u objeto creado
            this.DataContext = miJoinTboxValues;
        }



        // declaracion de propiedad de campo en este caso es un objeto creado en la class jointboxvalues.cs
        JoinTboxValues miJoinTboxValues;

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

            // borra los campos del xaml
             Textbox1.Text = "";
             Textbox2.Text = "";
             Textbox3.Text = "";
             Textbox4.Text = "";
             Textbox5.Text = "";
            
            // recorre el objeto i borra sus propiedades 
            var s = miJoinTboxValues;
            foreach (var p in s.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any()))
            {
                p.SetValue(s, "");                
            }


        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {

            // recorre el objeto i extrae sus propiedades en consola y en msgbox
            var s = miJoinTboxValues;
            foreach (var p in s.GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any()))

            {
                MessageBox.Show(p.GetValue(s, null).ToString());
                Console.WriteLine(p.GetValue(s, null));
            }
        }





    }



}
