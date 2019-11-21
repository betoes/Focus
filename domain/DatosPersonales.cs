using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.domain
{
    class DatosPersonales
    {
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private DateTime fechaNacimiento;
        private string genero;
        private string curp;
        private string rfc;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Rfc { get => rfc; set => rfc = value; }
    }
}
