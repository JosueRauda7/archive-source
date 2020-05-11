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
    public partial class EditarTutor : Form
    {
        Grado grado = new Grado();
        Tutor tutor = new Tutor();
        int idTutor = 0, idGrado=0;
        public EditarTutor()
        {
            InitializeComponent();
        }

        public EditarTutor(int id)
        {
            InitializeComponent();
            idTutor = id;
            tutor.recuperarTutor(idTutor,txtUsuario,txtNombres,txtApellidos,txtTelefono,txtCorreo,ref idGrado);
            cmbRango.DataSource = grado.llenarcmbGrado();
            cmbRango.DisplayMember = "Rango";
            cmbRango.ValueMember = "id_grado";
            cmbRango.SelectedValue = idGrado;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tutor.modificarTutor(idTutor,txtUsuario.Text,txtNombres.Text,txtApellidos.Text,txtTelefono.Text,txtCorreo.Text,(int)cmbRango.SelectedValue);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
