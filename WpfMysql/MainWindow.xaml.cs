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
using MySql;
using MySql.Data.MySqlClient;


namespace WpfMysql
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
 
            // MysqlConString = new MySqlConnection("server=serverip;user id=userdbIP;password=Pass;persistsecurityinfo=True;database=DataBaseTest");     
            try
            {
                MysqlConString.Open(); // here im getting the exception:
                Console.WriteLine("Mysql Connection .... conected OK!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error", ex.Message + "Ok");
            }

               
            MuestraClientes();
            MuestralistaPedidosTodos();

        }
        //
        MySqlConnection MysqlConString;
       
        private void MuestraClientes()
        {
            string Query = "SELECT * FROM Cliente";

            MySqlDataAdapter miAdaptadorSql = new MySqlDataAdapter(Query, MysqlConString);       
           
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
            string Query = "SELECT * FROM Pedido P INNER JOIN Cliente C ON C.ID=P.cCliente" + " WHERE C.ID=@ClienteId";
            MySqlCommand sqlComando = new MySqlCommand(Query, MysqlConString);
            MySqlDataAdapter miAdaptadorSql = new MySqlDataAdapter(sqlComando);

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
        }



        private void MuestraArticulos()
        {
            string Query = "SELECT * FROM Articulo P INNER JOIN Pedido C ON C.ID=P.pedidoId" + " WHERE C.ID=@PedidoId";
            MySqlCommand sqlComando = new MySqlCommand(Query, MysqlConString);
            MySqlDataAdapter miAdaptadorSql = new MySqlDataAdapter(sqlComando);
            using (miAdaptadorSql)
            {

                sqlComando.Parameters.AddWithValue("@PedidoId", listaClientes.SelectedValue);
                DataTable pedidosTabla = new DataTable();
                miAdaptadorSql.Fill(pedidosTabla);
                listaArticulos.DisplayMemberPath = "nombreArticulo";
                listaArticulos.SelectedValuePath = "Id";
                listaArticulos.ItemsSource = pedidosTabla.DefaultView;
            }
        }


       
        private void listaPedidos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraArticulos();
        }


        // muestra todos los pedidos existentes
        private void MuestralistaPedidosTodos()
        {
            string Query = "SELECT CONCAT (cCliente, ' ' , fechaPedido, ' ' ,formaPago ) AS ConcatenatedString FROM Pedido";
            MySqlDataAdapter miAdaptadorSql = new MySqlDataAdapter(Query, MysqlConString);
            using (miAdaptadorSql)
            {
                DataTable pedidosTablaTodos = new DataTable();
                miAdaptadorSql.Fill(pedidosTablaTodos);
                listaPedidosTodos.DisplayMemberPath = "ConcatenatedString";
                listaPedidosTodos.SelectedValuePath = "Id";
                listaPedidosTodos.ItemsSource = pedidosTablaTodos.DefaultView;
            }
        }


    }
}
