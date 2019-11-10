using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.domain
{
    class SolicitudDeCredito
    {
        private int folio;
        private DateTime fechaSolicitud;
        private double montoSolicitado;
        private String destinoCredito;
        private Cliente cliente;
        private Asesor asesor;

        public int Folio { get => folio; set => folio = value; }
        public DateTime FechaSolicitud { get => fechaSolicitud; set => fechaSolicitud = value; }
        public double MontoSolicitado { get => montoSolicitado; set => montoSolicitado = value; }
        public string DestinoCredito { get => destinoCredito; set => destinoCredito = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Asesor Asesor { get => asesor; set => asesor = value; }
    }
}
