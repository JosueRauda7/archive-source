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
    public partial class FormTutor : Form
    {
        Tutor tutor = new Tutor();
        public FormTutor()
        {
            InitializeComponent();
            tutor.listarTutor(dgvTutores);
        }

        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoTutor>(panelForm);
        }

        private void dgvTutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            tutor.listarTutor(dgvTutores, txtBuscar2.Text);
        }
    }
}
