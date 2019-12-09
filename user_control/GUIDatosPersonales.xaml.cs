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

namespace SysCredito.user_control
{
    /// <summary>
    /// Lógica de interacción para GUIDatosPersonales.xaml
    /// </summary>
    public partial class GUIDatosPersonales : UserControl
    {
        public GUIDatosPersonales()
        {

            InitializeComponent();
            cbGenero.Items.Add("Masculino");
            cbGenero.Items.Add("Femenino");

        }

        public cliente guardarDatosPersonales()
        {

            if (txtRFC.Text == ""  || txtnombre.Text == "" || txtApellidoMaterno.Text == "" || txtApellidoPaterno.Text == ""
                || txtCURP.Text == "")
            {
                MessageBox.Show("Campos vacios, ingrese datos en todos los campos");
                return null;
            } else
            {
                cliente cliente = new cliente();
                cliente.idcliente = ClienteDAO.totalClientes() + 1;
                cliente.rfc = txtRFC.Text;
                cliente.nombres = txtnombre.Text;
                cliente.apellidos = txtApellidoMaterno.Text + " " + txtApellidoPaterno.Text;
                cliente.curp = txtCURP.Text;
                cliente.fecharegistro = DateTime.Parse(DateTime.Now.ToShortDateString());
                cliente.fechanac = DateTime.Parse(dpFechanac.Text);
                cliente.firmaelectronica = null;
                cliente.Genero = cbGenero.Text;
                return cliente;
            }



        }
       
    }
}
