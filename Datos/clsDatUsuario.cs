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
    public class clsDatUsuario
    {
        SqlConnection objcon = new SqlConnection();
        clsUsuario objUsu = new clsUsuario();
        
        public DataTable validarUsuario(clsUsuario usuario)
        {
            SqlConnection SqlCon = clsConexion.getIntancia().CrearConexion();
            using (SqlCommand cmd = new SqlCommand("USP_validarUsuario", SqlCon))
            {
                DataTable tbl = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                    if (tbl.Rows.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return tbl;
                    }
                }
            }
        }
    }
}
