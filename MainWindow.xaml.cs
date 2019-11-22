using SysCredito.model.dao;
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
using SysCredito.ventana;

namespace SysCredito
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void iniciarSesion(object sender, RoutedEventArgs e)
        {

            String user = txt_Usuario.Text;
            String pass = txt_Password.Password;

            if (user != "" && pass != "")
            {

                int inicio = UsuarioSistemaDAO.login(user, pass);

                if (inicio > 0)
                {
                    GUIAsesorprincipal guiAsesorprincipal = new GUIAsesorprincipal();
                    guiAsesorprincipal.Show();
                    closeWindows();
                }
                else
                {
                    MessageBox.Show("No se encontro a ningun usuario dentro del sistema");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario y una contraseña");
            }
        }

        public void closeWindows()
        {
            this.Close();
        }

    }
}
