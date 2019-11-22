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
        private String Login_query = "SELECT * FROM dbo.usuariosistema WHERE numempleado = @usuario AND claveacceso = @pass";

        public UsuarioSistemaDAO() { }        

        public int login(String user, String pass)
        {
            SqlConnection conn = null;
            int res = 0;

            try
            {
               
                    conn = ConnectionUtils.getConnection();

                    SqlCommand command = new SqlCommand(Login_query, conn);

                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    res = command.ExecuteNonQuery();
                
                    
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

            return res;

        }


    }
}
