using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace archive_source.Clases
{
    class Login
    {
        public bool logeoAdmin(string user, string contra)
        {
            Conexion conexion = new Conexion();

            conexion.abrirConexion();
            string cadena = "Select * from main where Usuario=@user and Contra=@contra";
            MySqlCommand comando = new MySqlCommand(cadena, conexion.cn);
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@contra", contra);

            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                MessageBox.Show("Bienvenido admin");
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool logeoTutor(string user, string contra)
        {
            Conexion conexion = new Conexion();

            conexion.abrirConexion();
            string cadena = "Select * from sub where Usuario=@user and Contra=@contra";
            MySqlCommand comando = new MySqlCommand(cadena, conexion.cn);
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@contra", contra);

            MySqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                MessageBox.Show("Bienvenido Tutor");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
