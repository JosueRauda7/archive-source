using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Administrador
{
    using archive_source.Clases;
    public partial class EditarAdministrador : Form
    {
        Administrador admin = new Administrador();
        int id_admin;
        public EditarAdministrador()
        {
            InitializeComponent();
        }

        public EditarAdministrador(int id)
        {
            InitializeComponent();
            id_admin = id;
            MessageBox.Show("ID: " + id);

            admin.recuperarAdmin(id, txtUsuario, txtNombres, txtTelefono, txtCorreo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + txtNombres.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
