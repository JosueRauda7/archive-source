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
            this.dgvTutores.Columns[0].Visible = false;
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
            this.dgvTutores.Columns[0].Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvTutores.CurrentRow;
            int id_tutor;
            id_tutor = int.Parse(dgvr.Cells[0].Value.ToString());

            tutor.eliminarTutor(id_tutor);
            btnEliminar.Visible = false;
            btnModificar.Visible = false;

            tutor.listarTutor(dgvTutores);
            this.dgvTutores.Columns[0].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvTutores.CurrentRow;
            int id_tutor;
            id_tutor = int.Parse(dgvr.Cells[0].Value.ToString());

            AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario(panelForm, id_tutor, 1);
        }

        private void dgvTutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvTutores.CurrentRow;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
        }
    }
}
