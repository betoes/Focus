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
    
    public partial class centrotrabajo
    {
        public int idcentrotrabajo { get; set; }
        public string nombreempresa { get; set; }
        public string numempleado { get; set; }
        public string direccion { get; set; }
        public int antiguedad { get; set; }
        public string ocupacion { get; set; }
        public string desempeño { get; set; }
        public System.DateTime quincenauno { get; set; }
        public System.DateTime quincenados { get; set; }
        public int municipio_idmunicipio { get; set; }
        public int cliente_idcliente { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual municipio municipio { get; set; }
    }
}