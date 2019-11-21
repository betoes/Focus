using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.model.poco
{
    //POCO (Plain Old CLR Object)

    public class Resultado
    {

        private int numcolumnas;
        private int numregistros;
        private List<string> columnas;
        private List<String[]> datos;
        private bool err;
        private String mensajeError;
        private bool afectardatos;
        private int filasafectadas;

        public int Numcolumnas { get => numcolumnas; set => numcolumnas = value; }
        public int Numregistros { get => numregistros; set => numregistros = value; }
        public List<string> Columnas { get => columnas; set => columnas = value; }
        public List<string[]> Datos { get => datos; set => datos = value; }
        public bool Err { get => err; set => err = value; }
        public string MensajeError { get => mensajeError; set => mensajeError = value; }
        public bool Afectardatos { get => afectardatos; set => afectardatos = value; }
        public int Filasafectadas { get => filasafectadas; set => filasafectadas = value; }
    }
}
