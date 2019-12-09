using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysCredito.EntiteFramework;

namespace SysCredito.model.dao
{
    class DireccionDAO
    {
        public static void addDireccion(direccioncliente direccioncliente) 
        {
            using(FOCUSEntities db = new FOCUSEntities())
            {
                direccioncliente.iddireccioncliente = totalDirecciones() + 1;
                db.direccioncliente.Add(direccioncliente);
                db.SaveChanges();
            }
        }

        public static int totalDirecciones()
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                return db.direccioncliente.ToList().Count;
            }
        }
    }
}
