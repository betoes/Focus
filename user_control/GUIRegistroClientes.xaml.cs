
using SysCredito.EntiteFramework;
using SysCredito.model.dao;
using SysCredito.ventana;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        public GUIRegistroClientes()
        {
            InitializeComponent();

            List<cliente> listaClientes = ClienteDAO.ObtenerClientes();
            table_Clientes.ItemsSource = listaClientes;

        }

        private void btAgregar_cliente_Click(object sender, RoutedEventArgs e)
        {
            GUIcliente guiCliente = new GUIcliente();
            guiCliente.Show();
        }
        
    }
}