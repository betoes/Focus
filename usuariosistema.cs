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
    
    public partial class usuariosistema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuariosistema()
        {
            this.credito = new HashSet<credito>();
            this.solicitudcredito = new HashSet<solicitudcredito>();
            this.solicitudcredito1 = new HashSet<solicitudcredito>();
        }
    
        public int idusuariosistema { get; set; }
        public string numempleado { get; set; }
        public string claveacceso { get; set; }
        public System.DateTime fecharegistro { get; set; }
        public int rol_idrol { get; set; }
        public string apellidopaterno { get; set; }
        public string apellidomaterno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<credito> credito { get; set; }
        public virtual rol rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudcredito> solicitudcredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudcredito> solicitudcredito1 { get; set; }
    }
}
