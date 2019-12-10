using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysCredito.EntiteFramework;

namespace SysCredito.model.dao
{
    class MunicipioDAO
    {
        public static List<municipio> getMunicipios()
        {
            using(FOCUSEntities db = new FOCUSEntities())
            {
                return db.municipio.ToList();
            }
        }
    }
}
