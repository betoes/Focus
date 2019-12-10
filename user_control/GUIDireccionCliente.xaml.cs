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
    /// Lógica de interacción para GUIDireccionCliente.xaml
    /// </summary>
    public partial class GUIDireccionCliente : UserControl
    {
        public GUIDireccionCliente()
        {
            InitializeComponent();
            cbMunicipio.ItemsSource = MunicipioDAO.getMunicipios();

        }

        public direccioncliente GetDireccioncliente()
        {
            direccioncliente direccioncliente = new direccioncliente();
            direccioncliente.calle = txtCalle.Text;
            direccioncliente.colonia = txtcolonia.Text;
            direccioncliente.numexterior = txtnoExt.Text;
            direccioncliente.numinterior = txtnoInt.Text;
            switch (cbMunicipio.Text)
            {
                case "Xalapa":
                    direccioncliente.municipio_idmunicipio = 1;
                    break;

            }
            return direccioncliente;
        }

    }
}
