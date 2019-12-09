using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysCredito.EntiteFramework;

namespace SysCredito.model.dao
{
    class CuentaBancoDAO
    {
        public static int totalCuentas()
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                return db.cuentacliente.ToList().Count;
            }
        }

        public static void addCuenta(cuentacliente cuentacliente)
        {
            using(FOCUSEntities db = new FOCUSEntities())
            {
                cuentacliente.idcuentacliente = totalCuentas() + 1;
                
                db.cuentacliente.Add(cuentacliente);
                
                db.SaveChanges();
            }
        }
    }
}
