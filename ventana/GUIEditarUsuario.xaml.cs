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
using SysCredito.EntiteFramework;
using SysCredito.model.dao;

namespace SysCredito.ventana
{
    /// <summary>
    /// Lógica de interacción para GUIEditarUsuario.xaml
    /// </summary>
    public partial class GUIEditarUsuario : Window
    {
        usuariosistema usuarioSis;
        public GUIEditarUsuario(usuariosistema usuariosistema)
        {
            InitializeComponent();
            usuarioSis = usuariosistema;
            txtnombre.Text = usuariosistema.nombre;
            txtApellidoMaterno.Text = usuariosistema.apellidomaterno;
            txtApellidoPaterno.Text = usuariosistema.apellidopaterno;
            txtClave.Text = usuariosistema.claveacceso;
            txtnoEmpleado.Text = usuariosistema.numempleado;
            txtFechaRegistro.Text = usuariosistema.fecharegistro.ToString();
            switch (usuariosistema.rol_idrol)
            {
                case 1:
                    cbRol.Text = "Asesor";
                    break;
                case 2:
                    cbRol.Text = "Analista";

                    break;
                case 3:
                    cbRol.Text = "Administardor";
                    break;
            }
        }
        
        private void btEditarUsuario_Click(object sender, RoutedEventArgs e)
        {

            if (txtnombre.Text != "" || txtApellidoMaterno.Text != "" || txtApellidoPaterno.Text != "" || txtClave.Text != "" || txtnoEmpleado.Text != ""
               || txtFechaRegistro.Text != "" || cbRol.Text != "")
            {
                usuariosistema usuariosistema = new usuariosistema();
                usuariosistema.idusuariosistema = usuarioSis.idusuariosistema;
                usuariosistema.nombre = txtnombre.Text;
                usuariosistema.apellidomaterno = txtApellidoMaterno.Text;
                usuariosistema.apellidopaterno = txtApellidoPaterno.Text;
                usuariosistema.numempleado = txtnoEmpleado.Text;
                usuariosistema.claveacceso = txtClave.Text;

                switch (cbRol.Text)
                {
                    case "Asesor":
                        usuariosistema.rol_idrol = 1;
                        break;
                    case "Analista":
                        usuariosistema.rol_idrol = 2;

                        break;
                    case "Administardor":
                        usuariosistema.rol_idrol = 3;
                        break;
                }

                usuariosistema.fecharegistro = DateTime.Parse(txtFechaRegistro.Text);


                UsuarioSistemaDAO.editarUsuario(usuariosistema);
                MessageBox.Show("Usuario guardado dentro del sistema");
                cargarPrincipalAdmin();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos para el usuario");
            }

        }

        public void cargarPrincipalAdmin()
        {
            GUIAdministradorPrincipal gUIAdministradorPrincipal = new GUIAdministradorPrincipal();
            gUIAdministradorPrincipal.Show();
            this.Close();
        }
    }
}
