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
using SysCredito.user_control;


namespace SysCredito.ventana
{
    /// <summary>
    /// Lógica de interacción para GUImenu.xaml
    /// </summary>
    public partial class GUIcliente : Window
    {
        public GUIcliente()
        {

            InitializeComponent();
            GUIDatosPersonales datosPersonales = new GUIDatosPersonales();
            this.Hide();
            SPpage.Children.Add(datosPersonales);
            tbDatosPersonales.Background = Brushes.White;
            tbDatosPersonales.Foreground = Brushes.Black;


        }

    }
}
