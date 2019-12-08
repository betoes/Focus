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

        public ClienteDAO()
        {

        }
        public static void ObtenerClientes()
        {
            
            try
            {
                conn = ConnectionUtils.getConnection();
                query = "SELECT rfc,nombres,apellidos FROM dbo.cliente";

                if (conn != null)
                {
                    command = new SqlCommand(query, conn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

           
        }

       
        }

    }
