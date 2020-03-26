using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace archive_source
{
    class Conexion
    {
        static string cadena = "SERVER=127.0.0.1;PORT=3306;DATABASE=bdd_ads;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(cadena);

        public void abrirConexion()
        {
            cn.Open();
        }

        public void cerrarConexion()
        {
            cn.Close();
        }

        public void prueba()
        {
            cn.Open();
            string consulta = "Select * from main";
            
            MySqlCommand comando = new MySqlCommand(consulta,cn);
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                MessageBox.Show("-------------Resultados--------------\n" +
                                "id: "+lector.GetValue(0).ToString()+ "\n" +
                                "usuario: "+lector.GetValue(1) + " \n" +
                                "Nombre: "+lector.GetValue(2)+"\n" +
                                "Contra:"+lector.GetValue(3));
            }
            cn.Close();
        }
    }
}
