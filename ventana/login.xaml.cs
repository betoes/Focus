using SysCredito.model.poco;
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

namespace SysCredito.ventana
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void iniciarSesion(object sender, RoutedEventArgs e)
        {

            UsuarioSistemaDAO usuarioSistemaDAO = new UsuarioSistemaDAO();
            String user = txt_Usuario.Text;
            String pass = txt_Password.Password;

            if (user != "" && pass != "")
            {
               
                int inicio = usuarioSistemaDAO.login(user, pass);

                if (inicio > 0)
                {
                    GUIcliente cliente = new GUIcliente();
                    cliente.Show();
                }
                else
                {
                    MessageBox.Show("No se encontro a ningun usuario dentro del sistema");
                }
            } else
            {
                MessageBox.Show("Ingrese un usuario y una contraseña");
            }
        }

    }
}
