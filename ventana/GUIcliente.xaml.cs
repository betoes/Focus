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
        private int page = 1;

        public GUIcliente()
        {

            InitializeComponent();
            setPage(page);
        }

        public void setPage(int page)
        {
            switch (page)
            {

                case 1:

                    GUIDatosPersonales datosPersonales = new GUIDatosPersonales();
                    SPpage.Children.Clear();
                    SPpage.Children.Add(datosPersonales);
                    tbDatosPersonales.Background = Brushes.White;
                  break;

                case 2:
                    GUIDatosTrabajo datosTrabajo = new GUIDatosTrabajo();
                    SPpage.Children.Clear();
                    SPpage.Children.Add(datosTrabajo);
                    tbDatosTrabajo.Background = Brushes.White;
                    break;
            }
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            page++;
            setPage(page);
        }

    }
}
