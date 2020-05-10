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
    class Tutor
    {
        private int id_Tutor;
        private string usuario;
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo;
        private string contra;
        private int id_admin;
        private int id_grado;

        public int Id_Tutor { get => id_Tutor; set => id_Tutor = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Id_admin { get => id_admin; set => id_admin = value; }
        public int Id_grado { get => id_grado; set => id_grado = value; }

        Conexion conexion = new Conexion();
        DataTable dt;

        public void ingresarTutor(string usuario, string nombre, string apellido, string telefono, string correo, int id_grado)
        {
            conexion.abrirConexion();
            try
            {
                string query;
                //Contraseña por defecto temporal
                string contra = "12345";
                query = "INSERT into sub VALUES (null,@usuario,@nombre,@apellido,@telefono,@correo,@contra,@id_admin,@id_grado)";
                MySqlCommand comando = new MySqlCommand(query, conexion.cn);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contra", contra);
                comando.Parameters.AddWithValue("@id_admin", 1);
                comando.Parameters.AddWithValue("@id_grado", id_grado);
                comando.ExecuteNonQuery();

                MessageBox.Show("Tutor agregado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar al tutor" + ex);
                conexion.cerrarConexion();
                return;
            }
            conexion.cerrarConexion();
        }

        public void listarTutor(DataGridView dgv)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("Select s.Usuario,s.Nombre,s.Telefono,s.Correo,s.Contra, CONCAT(g.NombreGrado,'(' ,g.RangoMinimo, ' - ' , g.RangoMaximo,' años)') AS Rango from Sub s inner join grado g on s.id_grado=g.id_grado", conexion.cn);
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
        public void listarTutor(DataGridView dgv, string filtro)
        {
            conexion.abrirConexion();
            try
            {
                dt = new DataTable();
                MySqlCommand comando = new MySqlCommand("Select s.Usuario, s.Nombre, s.Telefono, s.Correo, s.Contra, CONCAT(g.NombreGrado, '(', g.RangoMinimo, ' - ', g.RangoMaximo, ' años)') AS Rango from Sub s inner join grado g on s.id_grado = g.id_grado where s.Usuario like @filtro", conexion.cn);
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
