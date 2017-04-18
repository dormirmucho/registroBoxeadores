using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class ControlUsuario
    {
        public string usuario;
        public string contrasenya;
        private ControlUsuario() { }
        private static ControlUsuario instance;
        public static ControlUsuario Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ControlUsuario();

                }
                return instance;
            }
        }
        public bool Comprobasion(string tb1, string tb2)
        {
            usuario = Conexion.getUser(tb1);
            contrasenya = Conexion.getPass(tb2);

            return usuario.Equals(tb1) && contrasenya.Equals(tb2);
        }


    }
}
