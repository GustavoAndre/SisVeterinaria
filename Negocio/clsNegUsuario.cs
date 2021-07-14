using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidad;
using Datos;

namespace Negocio
{
    public class clsNegUsuario
    {
        clsDatUsuario objDatUsu = new clsDatUsuario();
        DataTable dt;
        public DataTable validarUsuario(clsUsuario objUsu)
        {
            try
            {
                
                if (objDatUsu.validarUsuario(objUsu).Rows.Count==1)
                {
                    dt = objDatUsu.validarUsuario(objUsu);
                    return dt;
                }
                else
                {
                   return dt = null;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
    }
}
