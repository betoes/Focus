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
    /// Lógica de interacción para GUIDatosTrabajo.xaml
    /// </summary>
    public partial class GUIDatosTrabajo : UserControl
    {
        public GUIDatosTrabajo()
        {
            InitializeComponent();
        }

        public centrotrabajo GetCentrotrabajo()
        {
            centrotrabajo centrotrabajo = new centrotrabajo();
            centrotrabajo.nombreempresa = txtEmpresa.Text;
            centrotrabajo.numempleado = noEmpleado.Text;
            centrotrabajo.direccion = txtDireccion.Text;
            centrotrabajo.antiguedad = System.Convert.ToInt32(txtAntiguedad.Text);
            centrotrabajo.ocupacion = txtOcupacion.Text;
            centrotrabajo.desempeño = txtDesempeño.Text;
            centrotrabajo.quincenauno = DateTime.Parse(txtUltimaq.Text);
            centrotrabajo.quincenados = DateTime.Parse(txtPenultimaq.Text);
            centrotrabajo.municipio_idmunicipio = 1;


            return centrotrabajo;
        }

    }
}
