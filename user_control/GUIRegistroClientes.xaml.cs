using SysCredito.domain;
using SysCredito.model.dao;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SysCredito.user_control
{
    /// <summary>
    /// Lógica de interacción para GUIRegistroClientes.xaml
    /// </summary>
    public partial class GUIRegistroClientes : UserControl
    {
        FOCUSEntities entities = new FOCUSEntities();

        public GUIRegistroClientes()
        {
            InitializeComponent();

            List<Cliente> clientes = new List<Cliente>();

             

            if (entities.cliente.ToList().Count > 0)
            {

                clientes_view.Items.Clear();
                clientes_view.ItemsSource = entities.cliente.ToList();

            }
            else
            {
                MessageBox.Show("Sin datos registrados");
            }

        }

        private void Clientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Bt_Buscar_Click(object sender, RoutedEventArgs e)
        {
            string rfc = tb_RFC.Text;
            Cliente cliente = new Cliente();

            cliente = ClienteDAO.buscar_cliente(rfc);

            if (cliente != null)
            {
                clientes_view.Items.Clear();
                clientes_view.Items.Add(cliente);
            }
            else
            {
                MessageBox.Show("no se encontro el cliente con ese RFC");
            }
        }

        private void Bt_Buscar_Click_1(object sender, RoutedEventArgs e)
        {
            Cliente cliente = ClienteDAO.buscar_cliente(tb_RFC.Text);

            if (cliente != null)
            {
                clientes_view.Items.Clear();
                List<Cliente> clientes = new List<Cliente>();
                clientes.Add(cliente);
                clientes_view.ItemsSource = clientes;
                bt_solicitud.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}