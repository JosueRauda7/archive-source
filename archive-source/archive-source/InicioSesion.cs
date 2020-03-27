using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using archive_source.Clases;
using archive_source.Formularios.Administrador;
using archive_source.Formularios.Tutor;

namespace archive_source
{
    public partial class InicioSesion : Form
    {
        Login login = new Login();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user, contra;

            user = txtUser.Text.Trim();
            contra = txtContra.Text.Trim();

            if (user != "" && contra != "")
            {
                if (login.logeoAdmin(user, contra))
                {
                    this.Hide();
                    administradorGUI admin = new administradorGUI();
                    admin.Show();
                }
                else if (login.logeoTutor(user, contra))
                {
                    this.Hide();
                    tutorGUI tutor = new tutorGUI();
                    tutor.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos!");
                return;
            }

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
