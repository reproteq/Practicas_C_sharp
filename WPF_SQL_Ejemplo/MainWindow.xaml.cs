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
using System.Configuration;
using System.Data.SqlClient;

namespace WPF_SQL_Ejemplo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // conection MiDbSqlConnectionString1
            string miConexion = ConfigurationManager.ConnectionStrings["MiDbSqlConnectionString1"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        
        
        }

        SqlConnection miConexionSql;

        private void MuestraClientes()
        {
            string consulta = "SELECT * FROM CLIENTE";
        }



    }
}
