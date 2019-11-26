using SysCredito.user_control;
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
using System.Windows.Shapes;

namespace SysCredito.ventana
{
    /// <summary>
    /// Lógica de interacción para GUIAsesorprincipal.xaml
    /// </summary>
    public partial class GUIAsesorprincipal : Window
    {
        public GUIAsesorprincipal()
        {
            InitializeComponent();
        }

        private void CerrarSesion(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            closeWindows();
        }

        public void closeWindows()
        {
            this.Close();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            GUIRegistroClientes uc_registro_clientes = new GUIRegistroClientes();
            ucs.Children.Clear();
            ucs.Children.Add(uc_registro_clientes);

        }   
    }
}
