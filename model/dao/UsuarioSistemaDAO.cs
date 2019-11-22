using SysCredito.model.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCredito.model.dao
{
    class UsuarioSistemaDAO
    {
        private static String login_query = "SELECT * FROM dbo.usuariosistema WHERE numempleado = @usuario AND claveacceso = @pass";
        private static int registros;

        public UsuarioSistemaDAO() { }        

        public static int login(String user, String pass)
        {
            SqlConnection conn = null;
            SqlCommand command;
            SqlDataReader reader = null;

            try
            {

                conn = ConnectionUtils.getConnection();

                command = new SqlCommand(login_query, conn);

                command.Parameters.AddWithValue("@usuario", user);
                command.Parameters.AddWithValue("@pass", pass);


                reader = command.ExecuteReader();

                List<String[]> datos = new List<string[]>();
                while (reader.Read())
                {
                    registros++;
                }

                return registros;


            } catch (Exception ex)
            {
                String err = ex.Message;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return registros;

        }


    }
}
