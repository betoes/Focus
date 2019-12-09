using SysCredito.EntiteFramework;
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
    /// Lógica de interacción para GUIRegistroMonto _Condiciones.xaml
    /// </summary>
    public partial class GUIRegistroMonto_Condiciones : UserControl
    {
        private cliente cliente;
        private static FOCUSEntities db = new FOCUSEntities();
        solicitudcredito solicitud = new solicitudcredito();
        public GUIRegistroMonto_Condiciones(cliente cli)
        {
            agregarSolicitud(cli);

        } 

        private void agregarSolicitud(cliente cli)
        {
            this.cliente = cli;
            InitializeComponent();
            String monto = tc_Monto.Text;
            String pagos = cb_pagos.Text;
            String interes = cb_interes.Text;
            String iva = cb_iva.Text;
            String periodos = tc_Periocidad.Text;
            String diasPAgo = tc_diasPagos.Text;

            condiciones con = new condiciones();
            Calendar calendario = new Calendar();
            List<credito> creditos = db.credito.ToList();

            con.idcondiciones = creditos.Count.ToString();
            con.tasadeinteres = Convert.ToInt32(interes);
            con.iva = Convert.ToDouble(interes);
            con.plazo = Convert.ToInt32(pagos);
            db.condiciones.Add(con);

            solicitud.cliente_idcliente = cliente.idcliente;
            solicitud.FK_condiciones = con.idcondiciones;
            solicitud.diaspago = diasPAgo;
            solicitud.periodocidad = periodos;
            solicitud.analista_idusuariosistema = 3;
            solicitud.asesor_idusuariosistema = 2;
            solicitud.status = 1;

            using (FOCUSEntities db = new FOCUSEntities())
            {
                db.solicitudcredito.Add(solicitud);
            }
        }

        public solicitudcredito GetSolicitudcredito()
        {
            return this.solicitud;
        }
        
    }
}
