//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysCredito
{
    using System;
    using System.Collections.Generic;
    
    public partial class solicitudcreditohaspolitica
    {
        public int solicitudcredito_idsolicitudcredito { get; set; }
        public int politica_idpolitica { get; set; }
        public Nullable<byte> cumplida { get; set; }
        public Nullable<byte> obligatoria { get; set; }
    
        public virtual politica politica { get; set; }
        public virtual solicitudcredito solicitudcredito { get; set; }
    }
}