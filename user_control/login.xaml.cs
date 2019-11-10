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

namespace SysCredito.user_control
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class login : UserControl
    {
        private Resultado res;
        public login()
        {
            InitializeComponent();
        }

        private void iniciarSesion(object sender, RoutedEventArgs e)
        {
            if (txt_Usuario.Text != null && txt_Password.Password != null)
            {
                String query = "SELECT * FROM dbo.usuariosistema WHERE idusuariosistema=" + this.txt_Usuario + "AND claveacceso=" + this.txt_Password;
                res = ConsultaDAO.ejecutarConsulta(query);
                if (res.Err)
                {
                    res.Numregistros = 0;
                    MessageBox.Show(res.MensajeError, "Error al iniciar sesion");
                }
                else if (res.Afectardatos)
                {

                    MessageBox.Show("Sesión iniciada");
                }
                
            } else
            {
                MessageBox.Show("Ingrese los datos para iniciar sesion");
            }
        }

    }
}
