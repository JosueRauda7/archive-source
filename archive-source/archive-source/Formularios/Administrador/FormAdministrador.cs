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
        }

        private void dgvAdministradores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvr = dgvAdministradores.CurrentRow;            

            admin.Id_admin = int.Parse(dgvr.Cells[0].Value.ToString());
            admin.Usuario = dgvr.Cells[1].Value.ToString();
            admin.Nombre = dgvr.Cells[2].Value.ToString();
            admin.Telefono = dgvr.Cells[3].Value.ToString();
            admin.Correo = dgvr.Cells[5].Value.ToString();

           // AgregarForm agregarForm = new AgregarForm();
           // agregarForm.abrirFormulario<EditarAdministrador>(panelForm);            

        }
    }
}
