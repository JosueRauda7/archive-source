using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Clases
{
    class Administrador
    {
        private int id_admin;
        private string usuario;
        private string nombre;
        private string telefono;
        private string contra;
        private string correo;
        DataTable dt;

        public int Id_admin { get => id_admin; set => id_admin = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Correo { get => correo; set => correo = value; }

        Conexion conexion = new Conexion();

        public void insertarAdmin(string usuario, string nombre, string telefono, string correo)
        {
            conexion.abrirConexion();
            try
            {
                string query;
                //Contraseña por defecto temporal
                string contra = "12345";
                query = "INSERT into main VALUES (null,@usuario,@nombre,@telefono,@contra,@Correo)";
                MySqlCommand comando = new MySqlCommand(query, conexion.cn);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@contra", contra);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.ExecuteNonQuery();

                MessageBox.Show("Administrador agregado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el prestamo" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }

        public void listarAdmin(DataGridView dgv)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("Select * from main", conexion.cn);
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

        public void listarAdmin(DataGridView dgv, string filtro)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();
                MySqlCommand comando = new MySqlCommand("Select * from main Where Usuario like @filtro", conexion.cn);
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