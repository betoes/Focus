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
    /// Lógica de interacción para GUIDatosBancarios.xaml
    /// </summary>
    public partial class GUIDatosBancarios : UserControl
    {
        public GUIDatosBancarios()
        {
            InitializeComponent();
        }

        public cuentacliente getcuentaclienteDeposito()
        {
            cuentacliente cuentacliente = new cuentacliente();
            cuentacliente.numerotarjeta = txtNoTarjetaD.Text;
            cuentacliente.tipotarjeta = "Deposito";
            cuentacliente.movilasociado = txtCelularD.Text;
            cuentacliente.claveinterbancaria = txtClaveD.Text;
            cuentacliente.banco_idbanco = 1;

            return cuentacliente;

        }

        public cuentacliente getcuentaclienteCobro()
        {
            cuentacliente cuentacliente = new cuentacliente();
            cuentacliente.numerotarjeta = txtNoTarjetaC.Text;
            cuentacliente.tipotarjeta = "Cobro";
            cuentacliente.movilasociado = txtCelularC.Text;
            cuentacliente.claveinterbancaria = txtClaveC.Text;
            cuentacliente.banco_idbanco = 1;


            return cuentacliente;

        }


        private bool validarClaveBancaria()
        {
            if(txtClaveC.Text.Length != 18 || txtClaveD.Text.Length != 18 )
            {
               MessageBox.Show("Ingrese una clave correcta");
                return false;
            }

            return true;
        } 

        private bool validarTelefoono()
        {
            if(txtCelularC.Text.Length != 10 || txtCelularD.Text.Length != 10)
            {
                MessageBox.Show("Ingrese un numero de celular correcto");
                return false;
            }

            return true;
        }
    }
}
