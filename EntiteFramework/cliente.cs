//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysCredito.EntiteFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            this.centrotrabajo = new HashSet<centrotrabajo>();
            this.cuentacliente = new HashSet<cuentacliente>();
            this.direccioncliente = new HashSet<direccioncliente>();
            this.solicitudcredito = new HashSet<solicitudcredito>();
            this.referenciacliente = new HashSet<referenciacliente>();
            this.identificacion = new HashSet<identificacion>();
            this.datoscontacto = new HashSet<datoscontacto>();
        }
    
        public int idcliente { get; set; }
        public string rfc { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string curp { get; set; }
        public Nullable<System.DateTime> fechanac { get; set; }
        public Nullable<System.DateTime> fecharegistro { get; set; }
        public string firmaelectronica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<centrotrabajo> centrotrabajo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuentacliente> cuentacliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<direccioncliente> direccioncliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudcredito> solicitudcredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<referenciacliente> referenciacliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<identificacion> identificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<datoscontacto> datoscontacto { get; set; }
    }
}
