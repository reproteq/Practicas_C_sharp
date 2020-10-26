
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
using System.Data;

namespace WpfSql
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
 
            string con = "WpfSql.Properties.Settings.MiDbSqlConnectionString";
           

            string miConexion = ConfigurationManager.ConnectionStrings[con].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();

        }

        SqlConnection miConexionSql;

        private void MuestraClientes()
        {
            string consulta = "SELECT * FROM CLIENTE";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();
                miAdaptadorSql.Fill(clientesTabla);

                listaClientes.DisplayMemberPath = "nombre";
                listaClientes.SelectedValuePath = "Id";
                listaClientes.ItemsSource = clientesTabla.DefaultView;

            }



        }


        private void MuestraPedidos()
        {
            string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.cCliente" + " WHERE C.ID=@ClienteId";
                       

            //  consulta con parametros 
            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);
            using (miAdaptadorSql)
            {

                sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
                DataTable pedidosTabla = new DataTable();
                miAdaptadorSql.Fill(pedidosTabla);

                listaPedidos.DisplayMemberPath = "fechaPedido";
                listaPedidos.SelectedValuePath = "Id";
                listaPedidos.ItemsSource = pedidosTabla.DefaultView;

            }



        }



        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraPedidos();
            //MessageBox.Show("Lista clientes");
        }
    }
}
