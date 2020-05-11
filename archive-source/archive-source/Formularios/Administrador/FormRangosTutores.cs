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
    public partial class FormRangosTutores : Form
    {
        Grado grado = new Grado();
        public FormRangosTutores()
        {
            InitializeComponent();
            grado.listarGrado(dgvRangosTutores);
            this.dgvRangosTutores.Columns[0].Visible = false;
        }

        private void btnNuevoAdministrador_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoRangoTutor>(panelForm);
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            grado.listarGrado(dgvRangosTutores, txtBuscar.text);
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            this.dgvRangosTutores.Columns[0].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvRangosTutores.CurrentRow;
            int id_grado;
            id_grado = int.Parse(dgvr.Cells[0].Value.ToString());

            grado.eliminarGrado(id_grado);
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            grado.listarGrado(dgvRangosTutores);
            this.dgvRangosTutores.Columns[0].Visible = false;
        }

        private void dgvRangosTutores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvRangosTutores.CurrentRow;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvRangosTutores.CurrentRow;
            int id_grado;
            id_grado= int.Parse(dgvr.Cells[0].Value.ToString());

            AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario(panelForm, id_grado, 3);
        }
    }
}
