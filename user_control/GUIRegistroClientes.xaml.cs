
using SysCredito.EntiteFramework;
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
        

        public GUIRegistroClientes()
        {
            InitializeComponent();

            List<cliente> clientes = new List<cliente>();

            Console.WriteLine(clientes.Count());
            if (clientes.Count() > 0)
            {

                clientes_view.Items.Clear();
                clientes_view.ItemsSource = clientes;

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
           

        }

        private void Bt_Buscar_Click_1(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_solicitud_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}