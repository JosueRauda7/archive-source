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
        }

        private void btnNuevoTipoRegalo_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoTipoRegalo>(panelForm);
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            regalo.listarTipoRegalo(dgvRegalo, txtBuscar.Text);
        }
    }
}
