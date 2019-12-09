using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysCredito.EntiteFramework;

namespace SysCredito.model.dao
{
    class ContactosDAO
    {
        public static int totalContactos()
        {
            using(FOCUSEntities fOCUSEntities = new FOCUSEntities())
            {
                return fOCUSEntities.datoscontacto.ToList().Count;
            }
        }

        public static void saveContactos(datoscontacto datoscontacto)
        {
            using (FOCUSEntities fOCUSEntities = new FOCUSEntities())
            {
                fOCUSEntities.datoscontacto.Add(datoscontacto);
                fOCUSEntities.SaveChanges();
            }
        }
    }
}
