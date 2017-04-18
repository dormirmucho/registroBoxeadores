using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    class Conexion
    {
        private Conexion() { }
        private static Conexion instance;
        public static Conexion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Conexion();

                }
                return instance;
            }
        }





        public static string getUser(string user)
        {
            string res = "error";
            string datoConexion = "Server=localhost;Database=combates;User ID=root;Password=agustito;Pooling=false;";
            MySqlConnection cliente = new MySqlConnection(datoConexion);
            cliente.Open();

            string consulta = "SELECT u_name FROM users WHERE u_name LIKE @user LIMIT 1;";

            MySqlCommand comando = new MySqlCommand(consulta, cliente);


            comando.Parameters.AddWithValue("@user", user);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                res = reader["u_name"].ToString();
            }

            cliente.Close();

            return res;

        }

        internal static string getPass(string pass)
        {
            string res = "error";
            string datoConexion = "Server=localhost;Database=combates;User ID=root;Password=agustito;Pooling=false;";
            MySqlConnection cliente = new MySqlConnection(datoConexion);
            cliente.Open();

            string consulta = "SELECT u_password FROM users WHERE u_password LIKE @pass LIMIT 1;";

            MySqlCommand comando = new MySqlCommand(consulta, cliente);


            comando.Parameters.AddWithValue("@pass", pass);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                res = reader["u_password"].ToString();
            }

            cliente.Close();

            return res;
        }

        public static  void crearUsuario(string user,string pass)
        {
            string datoConexion = "Server=localhost;Database=combates;User ID=root;Password=agustito;Pooling=false;";
            MySqlConnection cliente = new MySqlConnection(datoConexion);
            cliente.Open();

            string consulta = "INSERT INTO users(u_name,u_password) VALUES (@user,@pass)";

            MySqlCommand comando = new MySqlCommand(consulta, cliente);

            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.ExecuteNonQuery();

            cliente.Close();
        }
        public static void crearBoxeador(string nombre)
        {
            string datoConexion = "Server=localhost;Database=combates;User ID=root;Password=agustito;Pooling=false;";
            MySqlConnection cliente = new MySqlConnection(datoConexion);
            cliente.Open();

            string consulta = "INSERT INTO boxeadores(name_boxeador) VALUES (@nombre);";

            MySqlCommand comando = new MySqlCommand(consulta, cliente);

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();

            cliente.Close();

        }
    }
}
