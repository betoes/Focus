
using SysCredito.model.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.model.dao
{
    class DatosTrabajoDAO
    {
        private static String query;
        private static SqlConnection conn = null;
        private static SqlCommand command;
        //private static SqlDataReader reader = null;


        public DatosTrabajoDAO() { }

        public static void guardarDatosTrabajo()
        {
            try
            {
                conn = ConnectionUtils.getConnection();
                query = "ISERT INSERT INTO dbo.centrotrabajo(idcentrotrabajo, nombreempresa, numempleado, direccion, antiguedad, " +
                    "ocupacion,desempeño,quincenados,quincenauno,municipio_idmunicipio, cliente_idcliente) " +
                    "VALUES(@id, @nombre_e, @num_empledo, @direccion, @antiguedas, @desempeno, @ocupacion, @p_quincena, @u_quincena, @cliente, @municipio); ";

                if (conn != null)
                {
                    

                    command.ExecuteNonQuery();


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
