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
    class TipoRegalo
    {
        private int id_tipoRegalo;
        private string nombre;

        public int Id_tipoRegalo { get => id_tipoRegalo; set => id_tipoRegalo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        Conexion conexion = new Conexion();
        DataTable dt;

        public void insertarTipoRegalo(string nombre)
        {
            conexion.abrirConexion();
            try
            {
                string query;
                query = "INSERT into tiporegalo VALUES (null,@nombre)";
                MySqlCommand comando = new MySqlCommand(query, conexion.cn);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.ExecuteNonQuery();

                MessageBox.Show("Tipo de regalo agregado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el tipo de regalo" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }


        public void eliminarTipoRegalo(int id_tiporegalo)
        {
            conexion.abrirConexion();
            try
            {
                string query;
                query = "DELETE FROM tiporegalo Where id_tipoRegalo = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion.cn);
                comando.Parameters.AddWithValue("@id", id_tiporegalo);
                comando.ExecuteNonQuery();

                MessageBox.Show("Se ha eliminado el tipo de regalo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el tipo de regalo" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }

        public void listarTipoRegalo(DataGridView dgv)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("Select * from tiporegalo", conexion.cn);
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

        public void listarTipoRegalo(DataGridView dgv, string filtro)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();
                MySqlCommand comando = new MySqlCommand("Select * from tipoRegalo Where nombre like @filtro", conexion.cn);
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
