using SysCredito.model.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using SysCredito.EntiteFramework;

namespace SysCredito.model.dao
{
    class UsuarioSistemaDAO
    {


        public static usuariosistema login(String user, String pass)
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                var usuario = db.usuariosistema.Where(d => d.numempleado == user && d.claveacceso == pass);
                return (usuariosistema)usuario;
            }

        }

        public static Boolean registrarUsuario(usuariosistema usuario)
        {
            bool registrado = false;
            using (FOCUSEntities db = new FOCUSEntities())
            {
                db.usuariosistema.Add(usuario);
                db.SaveChanges();
                registrado = true;
            }

            return registrado;
        }
    
    }
}
