using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.domain
{
    class DatosTrabajo
    {
        private int id;
        private string dependencia;
        private string num_empleado;
        private string direccion_trabajo;
        private int antiguedad_des;
        private string ocupacion;
        private string desempeno;
        private DateTime u_quincena;
        private DateTime p_quincena;

        public DatosTrabajo(string dependencia, string num_empleado, string direccion_trabajo, int antiguedad_des,
            string ocupacion, string desempeno, DateTime u_quincena, DateTime p_quincena)
        {
            Dependencia = dependencia;
            Num_empleado = num_empleado;
            Direccion_trabajo = direccion_trabajo;
            Antiguedad_des = antiguedad_des;
            Ocupacion = ocupacion;
            Desempeno = desempeno;
            U_quincena = u_quincena;
            P_quincena = p_quincena;

        }

        public int Id { get => id; set => id = value; }
        public string Dependencia { get => dependencia; set => dependencia = value; }
        public string Num_empleado { get => num_empleado; set => num_empleado = value; }
        public string Direccion_trabajo { get => direccion_trabajo; set => direccion_trabajo = value; }
        public int Antiguedad_des { get => antiguedad_des; set => antiguedad_des = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }
        public string Desempeno { get => desempeno; set => desempeno = value; }
        public DateTime U_quincena { get => u_quincena; set => u_quincena = value; }
        public DateTime P_quincena { get => p_quincena; set => p_quincena = value; }


    }
}
