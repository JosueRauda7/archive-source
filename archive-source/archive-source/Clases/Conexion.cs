using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace archive_source.Clases
{
    class Conexion
    {
        //Cadena de conexión con la bdd
        static string cadena = "SERVER=127.0.0.1;PORT=3306;DATABASE=archive-source;UID=root;PASSWORDS=;";
        public MySqlConnection cn;

        public Conexion()
        {
            cn = new MySqlConnection(cadena);
        }

        public void abrirConexion()
        {
            cn.Open();
        }

        public void cerrarConexion()
        {
            cn.Close();
        }

        //Función para probar que puedo seleccionar administradores de la bdd
        public void prueba()
        {
            cn.Open();
            string consulta = "Select * from main";

            MySqlCommand comando = new MySqlCommand(consulta, cn);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                MessageBox.Show("-------------Resultados--------------\n" +
                                "id: " + lector.GetValue(0) + "\n" +
                                "usuario: " + lector.GetValue(1) + " \n" +
                                "Nombre: " + lector.GetValue(2) + "\n" +
                                "Contra:" + lector.GetValue(3));
            }
            cn.Close();
        }
    }
}
