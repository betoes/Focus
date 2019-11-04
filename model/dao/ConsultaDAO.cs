using SysCredito.model.db;
using SysCredito.model.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCredito.model.dao
{
    class ConsultaDAO
    {
        public static String[] DML_SQL ={"INSERT", "UPDATE", "DELETE",
            "ALTER", "DROP", "CREATE"};

        public static Resultado ejecutarConsulta(String query)
        {
            Resultado res = new Resultado();
            SqlConnection conn = null;
            res.Afectardatos = false;

            foreach (String dml in DML_SQL)
            {
                if (query.ToUpper().Contains(dml))
                {
                    res.Afectardatos = true;
                    break;
                }
            }
            try
            {
                conn = ConnectionUtils.getConnection();
                SqlCommand command;

                if (res.Afectardatos)
                {
                    if (conn != null)
                    {
                        command = new SqlCommand(query, conn);
                        res.Filasafectadas = command.ExecuteNonQuery();
                        command.Dispose();
                    }
                }
                else
                {
                    SqlDataReader rd;
                    if (conn != null)
                    {
                        command = new SqlCommand(query, conn);
                        rd = command.ExecuteReader();
                        //---------Obtener columnas----------//
                        res.Numcolumnas = rd.FieldCount;
                        List<string> columnas = new List<string>();
                        for (int i = 0; i < res.Numcolumnas; i++)
                        {
                            columnas.Add(rd.GetName(i));
                        }
                        res.Columnas = columnas;
                        //-------obtener datos--------//
                        List<String[]> datos = new List<string[]>();
                        int registros = 0;
                        while (rd.Read())
                        {
                            String[] fila = new String[res.Numcolumnas];
                            for (int i = 0; i < res.Numcolumnas; i++)
                            {
                                fila[i] = (!rd.IsDBNull(i)) ? rd[i].ToString() : "";
                            }
                            datos.Add(fila);
                            registros++;
                        }
                        res.Numregistros = registros;
                        res.Datos = datos;

                        rd.Close();
                        command.Dispose();
                    }
                }


            }
            catch (Exception ex)
            {
                res.Err = true;
                res.MensajeError = ex.Message;
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