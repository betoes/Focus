using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using SysCredito.EntiteFramework;
using System.IO;

namespace SysCredito.model.dao
{
    class DocumentosDAO
    {
        public static Boolean saveDocuments(String ruta, String nombre,int idCliente)
        {
            byte[] file;
            using (var stream = new FileStream(ruta, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }

            using (FOCUSEntities db = new FOCUSEntities())
            {
                identificacion cd = new identificacion();
                cd.cliente = idCliente;
                cd.nombre = nombre;
                cd.tipo = "pdf";
                cd.archivobinario = file;
                cd.id_identificaion = totalDocuments() + 1;
                db.identificacion.Add(cd);
                db.SaveChanges();
                return true;
            }
        }

        public static int totalDocuments()
        {
            using(FOCUSEntities db = new FOCUSEntities())
            {
                return db.identificacion.ToList().Count;
            }
        }
    }
}
