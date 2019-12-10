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
using SysCredito.EntiteFramework;
using SysCredito.model.dao;
using SysCredito.ventana;

namespace SysCredito.user_control
{
    /// <summary>
    /// Lógica de interacción para GUIControlUsuarios.xaml
    /// </summary>
    public partial class GUIControlUsuarios : UserControl
    {
        public GUIControlUsuarios()
        {
            InitializeComponent();
            List<usuariosistema> listaUsuarios = UsuarioSistemaDAO.getUsuarios();
            table_Usuarios.ItemsSource = listaUsuarios;
        }

        private void btAgregar_usuario_Click(object sender, RoutedEventArgs e)
        {

                GUIRegistroUsuario usuario = new GUIRegistroUsuario();
                usuario.Show();
         
        }

        private void btEditar_usuario_Click(object sender, RoutedEventArgs e)
        {
            usuariosistema usuariosistema = (usuariosistema)table_Usuarios.SelectedItem;
            if (usuariosistema == null)
            {
                MessageBox.Show("Seleccione antes un usuario");
            } else
            {
                GUIEditarUsuario gUIEditarUsuario = new GUIEditarUsuario(usuariosistema);
                gUIEditarUsuario.Show();
            }
        }

        private void btBuscar_usuario_Click(object sender, RoutedEventArgs e)
        {
            if (txtNoEmpleado.Text != "") {
                usuariosistema usuariosistema = UsuarioSistemaDAO.GetUsuariosistema(txtNoEmpleado.Text);
                List<usuariosistema> listaUsuarios = new List<usuariosistema>();
                listaUsuarios.Add(usuariosistema);
                table_Usuarios.ItemsSource = listaUsuarios;
            } else
            {
                MessageBox.Show("Ingrese el numero de empleado");
            }
        }
    }
}
