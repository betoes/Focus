using SysCredito.EntiteFramework;
using SysCredito.model.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.model.dao
{
    class ClienteDAO
    {

        public static List<cliente> ObtenerClientes()
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                List<cliente> lista = db.cliente.ToList();
                Console.WriteLine(lista.Count);
                return lista;

            }
        }

        public static int totalClientes()
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                List<cliente> lista = db.cliente.ToList();
                return lista.Count;

            }
        }

        public static cliente buscarCliente(String rfc)
        {
            using (FOCUSEntities db = new FOCUSEntities())
            {
                return db.cliente.Where(d => d.rfc == rfc).FirstOrDefault();
            }

        }

        public static Boolean agregarCliente(cliente cliente)
        {

            using (FOCUSEntities db = new FOCUSEntities())
            {
                db.cliente.Add(cliente);
                db.SaveChanges();
                return true;
            }
        }

    }
}
