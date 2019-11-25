using SysCredito.model.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysCredito.domain;
using System.Globalization;

namespace SysCredito.model.dao
{
    class UsuarioSistemaDAO
    {
        private static String login_query = "SELECT * FROM dbo.usuariosistema WHERE numempleado = @usuario AND claveacceso = @pass";

        public static UsuarioSistema login(String user, String pass)
        {
            SqlConnection conn = null;
            SqlCommand command;
            SqlDataReader reader = null;
            UsuarioSistema usuarioSistema = new UsuarioSistema();


            try
            {

                conn = ConnectionUtils.getConnection();

                command = new SqlCommand(login_query, conn);

                command.Parameters.AddWithValue("@usuario", user);
                command.Parameters.AddWithValue("@pass", pass);


                reader = command.ExecuteReader();

                if (reader.Read())
                {


                    usuarioSistema.Usuario = reader["numempleado"].ToString();
                    usuarioSistema.Password = reader["claveacceso"].ToString();
                    usuarioSistema.Fecharegistro = (DateTime) reader["fecharegistro"];
                    usuarioSistema.Rol = (int) reader["rol_idrol"];

                    return usuarioSistema;


                }
                reader.NextResult();
                usuarioSistema = null;

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

            return usuarioSistema;

        }


    }
}
