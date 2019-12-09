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
using SysCredito.user_control;
using SysCredito.EntiteFramework;
using SysCredito.model.dao;


namespace SysCredito.ventana
{
    /// <summary>
    /// Lógica de interacción para GUImenu.xaml
    /// </summary>
    public partial class GUIcliente : Window
    {
        private int page = 1;
        private static int idCliente;
        private cliente cliente;
        private GUIDatosPersonales datosPersonales = new GUIDatosPersonales();
        private GUIDocumentos datosdocumentos = new GUIDocumentos();
        private GUIDireccionCliente direccionCliente = new GUIDireccionCliente();
        private GUIDatosTrabajo datosTrabajo = new GUIDatosTrabajo();
        private GUIDatosBancarios datosBancarios = new GUIDatosBancarios();
        private GUIDatosContacto datosContacto = new GUIDatosContacto();


        public GUIcliente()
        {

            InitializeComponent();
            setPage(page);
        }

        public void setPage(int page)
        {
            switch (page)
            {

                case 1:
                    SPpage.Children.Clear();
                    SPpage.Children.Add(datosPersonales);
                    tbDatosPersonales.Background = Brushes.White;
                    tblockDatosPersonales.Foreground = Brushes.Black;
                  break;
                case 2:
                    cliente = datosPersonales.guardarDatosPersonales();
                    bool res = ClienteDAO.agregarCliente(cliente);
                    cliente client = ClienteDAO.buscarCliente(cliente.rfc);
                    idCliente = client.idcliente;
                    SPpage.Children.Clear();
                    SPpage.Children.Add(datosdocumentos);
                    tbDatosIdentificacion.Background = Brushes.White;
                    tblockDatosidentificacion.Foreground = Brushes.Black;
                    break;
                case 3:
                    datosdocumentos.guardarDocumentos(idCliente);
                    SPpage.Children.Clear();
                    SPpage.Children.Add(direccionCliente);
                    tbDatosDireccion.Background = Brushes.White;
                    tblockDatosDireccion.Foreground = Brushes.Black; break;
                case 4:
                    saveDireccion(idCliente);
                    SPpage.Children.Clear();
                    SPpage.Children.Add(datosTrabajo);
                    tbDatosTrabajo.Background = Brushes.White;
                    tblockDatosTrabajo.Foreground = Brushes.Black;
                    break;
                 case 5:
                    saveDatosTrabajo(idCliente);
                    SPpage.Children.Clear();
                    SPpage.Children.Add(datosBancarios);
                    tbDatosBancarios.Background = Brushes.White;
                    tblockDatosBancarios.Foreground = Brushes.Black;
                    break;
                case 6:
                    saveDatosBancarios(idCliente);
                    SPpage.Children.Clear();
                    SPpage.Children.Add(datosContacto);
                    tbDatosContacto.Background = Brushes.White;
                    tblockDatosContacto.Foreground = Brushes.Black;
                    break;
                case 7:
                    saveDatosContacto(idCliente);
                    MessageBox.Show("Guardado");
                    GUIAsesorprincipal guiAsesorprincipal = new GUIAsesorprincipal();
                    guiAsesorprincipal.Show();
                    this.Close();
                    break;

            }
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            page++;
            setPage(page);
            setColorDefault(page);
        }

        public void setColorDefault(int page)
        {
         
            switch (page)
            {

                case 2:
                    tbDatosPersonales.Background = Brushes.DarkBlue;
                    tblockDatosPersonales.Foreground = Brushes.White;
                    break;
                case 3:
                    
                    tbDatosIdentificacion.Background = Brushes.DarkBlue;
                    tblockDatosidentificacion.Foreground = Brushes.White;
                    break;
                case 4:
                   
                    tbDatosDireccion.Background = Brushes.DarkBlue;
                    tblockDatosDireccion.Foreground = Brushes.White; 
                    break;
                case 5:
                   
                    tbDatosTrabajo.Background = Brushes.DarkBlue;
                    tblockDatosTrabajo.Foreground = Brushes.White;
                    break;
                case 6:
                    tbDatosBancarios.Background = Brushes.DarkBlue;
                    tblockDatosBancarios.Foreground = Brushes.White;
                    break;


            }
        }

        public void saveDireccion(int idCliente)
        {
            direccioncliente direccioncliente = direccionCliente.GetDireccioncliente();
            direccioncliente.cliente_idcliente = idCliente;

            DireccionDAO.addDireccion(direccioncliente);
        }

        public void saveDatosTrabajo(int idCliente)
        {
            centrotrabajo centrotrabajo = datosTrabajo.GetCentrotrabajo();
            centrotrabajo.cliente_idcliente = idCliente;

            DatosTrabajoDAO.addTrabajo(centrotrabajo);
        }

        public void SaveDatosTrabajo(int idCliente)
        {
            centrotrabajo centrotrabajo = datosTrabajo.GetCentrotrabajo();
            centrotrabajo.cliente_idcliente = idCliente;

            DatosTrabajoDAO.addTrabajo(centrotrabajo);
        }

        public void saveDatosBancarios(int idCliente)
        {
            cuentacliente cuentaclienteC = datosBancarios.getcuentaclienteCobro();
            cuentacliente cuentaclienteD = datosBancarios.getcuentaclienteDeposito();

            cuentaclienteC.cliente_idcliente = idCliente;
            cuentaclienteD.cliente_idcliente = idCliente;
            
            CuentaBancoDAO.addCuenta(cuentaclienteC);
            CuentaBancoDAO.addCuenta(cuentaclienteD);
        }

        public void saveDatosContacto(int idCliente)
        {
            datoscontacto datoscontacto = datosContacto.GetDatoscontacto();
            datoscontacto.id_Cliente = idCliente;

            ContactosDAO.saveContactos(datoscontacto);
        }


    }
}
