using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsUsuario
    {
        private string nombre { get; set; }
        public string usuario  { get; set; }
        public string contraseña { get; set; }


        public clsUsuario(string usuario,string contrasena)
        {
            this.usuario = usuario;
            this.contraseña = contrasena;
        }
        public clsUsuario()
        {

        }
    }
}
