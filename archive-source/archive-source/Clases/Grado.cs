using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Clases
{
    class Grado
    {
        private int id_grado;
        private string nombreGrado;
        private int rangoMin;
        private int rangoMax;

        public int Id_grado { get => id_grado; set => id_grado = value; }
        public string NombreGrado { get => nombreGrado; set => nombreGrado = value; }
        public int RangoMin { get => rangoMin; set => rangoMin = value; }
        public int RangoMax { get => rangoMax; set => rangoMax = value; }

        Conexion conexion = new Conexion();
        DataTable dt;
        public DataTable llenarcmbGrado()
        {
            string consulta = "Select id_grado, CONCAT(NombreGrado,'(' ,RangoMinimo, ' - ' , RangoMaximo,' años)') AS Rango from grado";
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void insertarGrado(string nombregrado, int edadmin, int edadmax)
        {
            conexion.abrirConexion();
            try
            {
                string query;

                query = "INSERT into grado VALUES (null,@nombre,@edadmin,@edadmax)";
                MySqlCommand comando = new MySqlCommand(query, conexion.cn);
                comando.Parameters.AddWithValue("@nombre", nombregrado);
                comando.Parameters.AddWithValue("@edadmin", edadmin);
                comando.Parameters.AddWithValue("@edadmax", edadmax);
                comando.ExecuteNonQuery();

                MessageBox.Show("Grado agregado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el grado" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }

        public void eliminarGrado(int id_grado)
        {
            conexion.abrirConexion();
            try
            {
                string query;
                query = "DELETE FROM grado Where id_grado= @id";
                MySqlCommand comando = new MySqlCommand(query, conexion.cn);
                comando.Parameters.AddWithValue("@id", id_grado);
                comando.ExecuteNonQuery();

                MessageBox.Show("Se ha eliminado al administrador");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar al administrador" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }

        public void listarGrado(DataGridView dgv)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("Select * from grado", conexion.cn);
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }

        public void listarGrado(DataGridView dgv, string filtro)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();

                MySqlCommand comando = new MySqlCommand("Select * from grado where NombreGrado like @filtro", conexion.cn);
                comando.Parameters.AddWithValue("@filtro", filtro + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }
    }
}
