using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class clsNegCita
    {
        clsDatCita objdatCita = new clsDatCita();

        public DataTable listarCita()
        {
            DataTable dt = new DataTable();
            try
            {

                if (objdatCita.ListarCitas().Rows.Count > 0)
                {
                    dt = objdatCita.ListarCitas();
                    return dt;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void guardarCita(clsCita objCita)
        {

            try
            {
                SqlParameter[] parParametros = new SqlParameter[8];
                parParametros[0] = new SqlParameter();
                parParametros[0].ParameterName = "@nomEmp";
                parParametros[0].SqlDbType = SqlDbType.VarChar;
                parParametros[0].SqlValue = objCita.nomEmp;


                parParametros[1] = new SqlParameter();
                parParametros[1].ParameterName = "@tipoEmp";
                parParametros[1].SqlDbType = SqlDbType.VarChar;
                parParametros[1].SqlValue = objCita.tipoEmp;

                parParametros[2] = new SqlParameter();
                parParametros[2].ParameterName = "@nomCli";
                parParametros[2].SqlDbType = SqlDbType.VarChar;
                parParametros[2].SqlValue = objCita.nomCli;

                parParametros[3] = new SqlParameter();
                parParametros[3].ParameterName = "@apeCli";
                parParametros[3].SqlDbType = SqlDbType.VarChar;
                parParametros[3].SqlValue = objCita.apeCli;

                parParametros[4] = new SqlParameter();
                parParametros[4].ParameterName = "@nomAni";
                parParametros[4].SqlDbType = SqlDbType.VarChar;
                parParametros[4].SqlValue = objCita.nomAni;

                parParametros[5] = new SqlParameter();
                parParametros[5].ParameterName = "@tipoAni";
                parParametros[5].SqlDbType = SqlDbType.VarChar;
                parParametros[5].SqlValue = objCita.tipoAni;

                parParametros[6] = new SqlParameter();
                parParametros[6].ParameterName = "@razaAni";
                parParametros[6].SqlDbType = SqlDbType.VarChar;
                parParametros[6].SqlValue = objCita.razaAni;

                parParametros[7] = new SqlParameter();
                parParametros[7].ParameterName = "@fecCita";
                parParametros[7].SqlDbType = SqlDbType.VarChar;
                parParametros[7].SqlValue = objCita.fecCita;



                /*idProducto = */
                objdatCita.agregarCita(parParametros, "USP_AgregarCita");


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
