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
    public partial class NuevoAdministrador : Form
    {
        Administrador admin = new Administrador();
        public NuevoAdministrador()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            admin.insertarAdmin(txtUsuario.Text,txtNombres.Text,txtTelefono.Text,txtCorreo.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
