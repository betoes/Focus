//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysCredito.model.dao
{
    using System;
    using System.Collections.Generic;
    
    public partial class catalogobanco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public catalogobanco()
        {
            this.cuentacliente = new HashSet<cuentacliente>();
        }
    
        public int idbanco { get; set; }
        public string nombrebanco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuentacliente> cuentacliente { get; set; }
    }
}
