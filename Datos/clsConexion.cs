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
    public class clsConexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static clsConexion Con = null;

        private clsConexion()
        {
            this.Base = "BD_SistemaVeterinario";
            this.Servidor = ".";
            this.Usuario = "";
            this.Clave = "";
            this.Seguridad = true;
        }
        public SqlConnection CrearConexion()
        {

            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server = " + this.Servidor + ";Database = " + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id" + this.Usuario + ";Password" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static clsConexion getIntancia()
        {
            if (Con == null)
            {
                Con = new clsConexion();
            }
            return Con;
        }

    }
}
