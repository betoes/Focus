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
        private static String query;
        private static SqlConnection conn = null;
        private static SqlCommand command;
        private static SqlDataReader reader = null;

        private static FOCUSEntities entities = new FOCUSEntities();

        public ClienteDAO()
        {

        }
        public static List<cliente> ObtenerClientes()
        {
            Console.WriteLine(entities.cliente.ToList().Count());
            return entities.cliente.ToList();


        }

        public static List<cliente> buscarCliente(String rfc)
        {
            return entities.cliente.Where(d => d.rfc == rfc).ToList();
        }

       
        }

    }
