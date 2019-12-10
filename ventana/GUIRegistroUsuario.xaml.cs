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
    /// Lógica de interacción para GUIRegistroUsuario.xaml
    /// </summary>
    public partial class GUIRegistroUsuario : Window
    {
        public GUIRegistroUsuario()
        {
            InitializeComponent();

            cbRol.Items.Add("Asesor");
            cbRol.Items.Add("Analista");
            cbRol.Items.Add("Administardor");

        }

        private void AgregarUsuario_Click(object sender, RoutedEventArgs e)
        {

            if (txtnombre.Text!="" || txtApellidoMaterno.Text!= ""  || txtApellidoPaterno.Text!= "" || txtClave.Text!="" || txtnoEmpleado.Text!=""
               || txtFechaRegistro.Text!="" || cbRol.Text != "") 
            {
                usuariosistema usuariosistema = new usuariosistema();
                usuariosistema.idusuariosistema = UsuarioSistemaDAO.getUsuariostotal() + 1;
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


                UsuarioSistemaDAO.registrarUsuario(usuariosistema);
                MessageBox.Show("Usuario guardado dentro del sistema");
                cargarPrincipalAdmin();
            } else
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
