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
    public partial class FormAdministrador : Form
    {
        Administrador admin = new Administrador();
        public FormAdministrador()
        {
            InitializeComponent();
            admin.listarAdmin(dgvAdministradores);
            this.dgvAdministradores.Columns[0].Visible = false;
        }

        private void btnNuevoAdministrador_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoAdministrador>(panelForm);
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            admin.listarAdmin(dgvAdministradores, txtBuscar.text);
            this.dgvAdministradores.Columns[0].Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }

        private void dgvAdministradores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvr = dgvAdministradores.CurrentRow;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvAdministradores.CurrentRow;
            int id_admin;
            id_admin = int.Parse(dgvr.Cells[0].Value.ToString());

            admin.eliminarAdmin(id_admin);
            btnEliminar.Visible = false;
            btnModificar.Visible = false;

            admin.listarAdmin(dgvAdministradores);
            this.dgvAdministradores.Columns[0].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = dgvAdministradores.CurrentRow;
            int id_admin;
            id_admin = int.Parse(dgvr.Cells[0].Value.ToString());

            AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario<EditarAdministrador>(panelForm, id_admin, 2);
        }
    }
}
