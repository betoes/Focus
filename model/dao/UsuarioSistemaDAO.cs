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
                usuariosistema usuario = new usuariosistema();
                usuario = db.usuariosistema.Where(d => d.numempleado == user && d.claveacceso == pass).FirstOrDefault();
                return usuario;
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

        public static List<usuariosistema> getUsuarios()
        {
            using(FOCUSEntities db = new FOCUSEntities())
            {
                return db.usuariosistema.ToList();
            }
        }

        public static int getUsuariostotal()
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                return db.usuariosistema.ToList().Count;
            }
        }

        public static void editarUsuario(usuariosistema usuariosistema)
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                db.usuariosistema.Attach(usuariosistema);
                db.SaveChanges();
            }

        }

        public static usuariosistema GetUsuariosistema(String numEmpleado)
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                usuariosistema usuario = new usuariosistema();
                usuario = db.usuariosistema.Where(d => d.numempleado == numEmpleado).FirstOrDefault();
                return usuario;
            }
        } 
    }
}
