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
    public partial class FormTipoRegalo : Form
    {
        TipoRegalo regalo = new TipoRegalo();
        public FormTipoRegalo()
        {
            InitializeComponent();
            regalo.listarTipoRegalo(dgvRegalo);
            this.dgvRegalo.Columns[0].Visible = false;
        }

        private void btnNuevoTipoRegalo_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoTipoRegalo>(panelForm);
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            regalo.listarTipoRegalo(dgvRegalo, txtBuscar.Text);
            this.dgvRegalo.Columns[0].Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvRegalo.CurrentRow;
            int id_TipoRegalo;
            id_TipoRegalo = int.Parse(dgvr.Cells[0].Value.ToString());

            AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario(panelForm, id_TipoRegalo, 4);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvRegalo.CurrentRow;
            int id_TipoRegalo;
            id_TipoRegalo = int.Parse(dgvr.Cells[0].Value.ToString());

            regalo.eliminarTipoRegalo(id_TipoRegalo);
            btnEliminar.Visible = false;
            btnModificar.Visible = false;

            regalo.listarTipoRegalo(dgvRegalo);
            this.dgvRegalo.Columns[0].Visible = false;
        }

        private void dgvRegalo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvRegalo.CurrentRow;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
        }
    }
}
