using SysCredito.domain;
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
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
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
                        Cliente cliente = new Cliente();
                        Console.WriteLine(reader.GetString(1));
                        cliente.Rfc = reader.GetString(0);
                        cliente.Nombre = reader.GetString(1);
                        cliente.Apellidos = reader.GetString(2);
                        clientes.Add(cliente);
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

            return clientes;
        }

        public static Cliente buscar_cliente(string rfc)
        {
            Cliente cliente = new Cliente();
            try
            {
                conn = ConnectionUtils.getConnection();
                query = "SELECT * FROM dbo.cliente WHERE rfc = @rfc";

                if (conn != null)
                {
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@rfc, rfc);
                    reader = command.ExecuteReader();

                    reader.Cast<Cliente>();

                    //cliente.Idcliente = reader.GetInt32(1);
                    cliente.Rfc = reader.GetString(2);
                    cliente.Nombre = reader.GetString(3);
                    cliente.Apellidos = reader.GetString(4);


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
            return cliente;
        }

    }
}