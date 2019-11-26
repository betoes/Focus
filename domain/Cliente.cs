using System;

namespace SysCredito.domain
{
  
        class Cliente
        {
            private int idcliente;
            private string rfc;
            private string nombre;
            private string apellidos;
            private string curp;
            private string genero;
            private DateTime fechadenacimiento;

            public int Idcliente { get => idcliente; set => idcliente = value; }
            public string Rfc { get => rfc; set => rfc = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellidos { get => apellidos; set => apellidos = value; }
            public string Curp { get => curp; set => curp = value; }
            public string Genero { get => genero; set => genero = value; }
            public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        }
    
}
