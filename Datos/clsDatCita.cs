using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDatCita
    {
        SqlConnection objcon = new SqlConnection();
        SqlDataReader dtr;
        public DataTable ListarCitas()
        {
            DataTable dt = new DataTable();
            try
            {
                objcon = clsConexion.getIntancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("USP_listarCita", objcon);
                cmd.CommandType = CommandType.StoredProcedure;
                objcon.Open();
                dtr = cmd.ExecuteReader();
                dt.Load(dtr);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                objcon.Dispose();
            }
        }
        public void agregarCita(SqlParameter[] parParametros, String spNombre)
        {

            try
            {
                objcon = clsConexion.getIntancia().CrearConexion();
                //Instanciar Objetos
                SqlCommand cmd = new SqlCommand(spNombre,objcon);
                cmd.CommandType = CommandType.StoredProcedure;
                objcon.Open();
                cmd.Parameters.AddRange(parParametros);
                //Ejecutar el sp mediante cmd
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
