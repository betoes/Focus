using SysCredito.EntiteFramework;
using SysCredito.model.dao;
using SysCredito.user_control;
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

namespace SysCredito.ventana
{
    /// <summary>
    /// Lógica de interacción para GUISolicitud.xaml
    /// </summary>
    public partial class GUISolicitud : Window
    {
        private cliente cliente;
        private solicitudcredito solicitud;
        private int page = 1;
        

        public GUISolicitud()
        {
            InitializeComponent();
            using (FOCUSEntities db = new FOCUSEntities())
            {
                this.cliente = db.cliente.Where(d => d.idcliente == 1).FirstOrDefault();
            }
            setPage(page);
            
        }
        
        private void setPage(int page)
        {
            switch (page)
            {

                case 1:

                    GUIRegistroMonto_Condiciones guiCondiciones = new GUIRegistroMonto_Condiciones(this.cliente);
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(guiCondiciones);
                    tbMontoCondiciones.Background = Brushes.Gray;
                    this.solicitud = guiCondiciones.GetSolicitudcredito();
                    break;

                case 2:
                    GUIAmortizacion guiAmortizacion = new GUIAmortizacion(this.solicitud);
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(guiAmortizacion);
                    tbAmortizacion.Background = Brushes.Gray;
                    tbMontoCondiciones.Background = Brushes.DarkBlue;

                    break;
                case 3:
                    GUIRegistroReferencias gUIRegistroReferencias = new GUIRegistroReferencias();
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(gUIRegistroReferencias);
                    tbReferenciasRegistro.Background = Brushes.Gray;
                    tbAmortizacion.Background = Brushes.DarkBlue;
                    break;
                case 4:
                    GUIAperturaContrato gUIApertura = new GUIAperturaContrato();
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(gUIApertura);
                    tbDocApertura.Background = Brushes.Gray;
                    tbReferenciasRegistro.Background = Brushes.DarkBlue;
                    this.Siguiente.Content = "Intpirmir y continuar";
                    break;
                case 5:
                    imprimirDocumentos(SPSolicitud, "DocumentoApertura");
                    GUICaratulaContrato gUICaratula = new GUICaratulaContrato();
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(gUICaratula);
                    tbDocCaratula.Background = Brushes.Gray;
                    tbDocApertura.Background = Brushes.DarkBlue;
                    this.Siguiente.Content = "Intpirmir y continuar";
                    break;
                case 6:
                    imprimirDocumentos(SPSolicitud, "DocumentoCaratula");
                    GUIPagare gui = new GUIPagare();
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(gui);
                    tbDocPAgare.Background = Brushes.Gray;
                    tbDocCaratula.Background = Brushes.DarkBlue;
                    this.Siguiente.Content = "Intpirmir y continuar";
                    break;
                case 7:
                    imprimirDocumentos(SPSolicitud, "DocumentoPagare");
                    GUIDomicializacion domicializacion = new GUIDomicializacion();
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(domicializacion);
                    tbDocDomicializacion.Background = Brushes.Gray;
                    tbDocPAgare.Background = Brushes.DarkBlue;
                    this.Siguiente.Content = "Intpirmir y continuar";
                    break;
                case 8:
                    imprimirDocumentos(SPSolicitud, "DocumentoDomicializacion");
                    GUISubirDocumentosSolicitud documentosSolicitud = new GUISubirDocumentosSolicitud();
                    SPSolicitud.Children.Clear();
                    SPSolicitud.Children.Add(documentosSolicitud);
                    tbSubirDocumentos.Background = Brushes.Gray;
                    tbDocDomicializacion.Background = Brushes.DarkBlue;
                    this.Siguiente.Content = "Finalizar";
                    break;
                case 9:
                    GUIAsesorprincipal guiAsesorprincipal = new GUIAsesorprincipal();
                    guiAsesorprincipal.Show();
                    this.Close();
                    break;
            }
        }

        private void  imprimirDocumentos(Visual v,String nombre)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(v, nombre);
            }
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            page++;
            setPage(page);
        }
    }
}
