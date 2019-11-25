using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.domain
{
    class UsuarioSistema
    {
        private String usuario;
        private String password;
        private DateTime fecharegistro;
        private int rol;



        public string Usuario 
        { 
          get { return usuario;  }
          set { usuario = value; } 
        }
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }
        public DateTime Fecharegistro 
        {
            get { return fecharegistro; }
            set { fecharegistro = value; }
        }
        public int Rol 
        {
            get { return rol; }
            set { rol = value; }
        }
    }
}
