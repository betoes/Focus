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
using SysCredito.model.dao;
using SysCredito.EntiteFramework;

namespace SysCredito.user_control
{
    /// <summary>
    /// Lógica de interacción para GUIDatosContacto.xaml
    /// </summary>
    public partial class GUIDatosContacto : UserControl
    {
        public GUIDatosContacto()
        {
            InitializeComponent();
        }


        public datoscontacto GetDatoscontacto()
        {
            datoscontacto datoscontacto = new datoscontacto();
            datoscontacto.id_contacto = ContactosDAO.totalContactos() + 1;
            datoscontacto.correo = txtCorreo.Text;
            datoscontacto.celular = txtCelular.Text;
            datoscontacto.telefono = txtTelefono.Text;

            return datoscontacto;
        }

        private bool validarTelefoono()
        {
            if (txtCelular.Text.Length != 10 || txtTelefono.Text.Length != 7)
            {
                MessageBox.Show("Ingrese un numero de celular o telefono correcto");
                return false;
            }

            return true;
        }
    }
}
