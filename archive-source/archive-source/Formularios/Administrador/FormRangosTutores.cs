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
        }

        private void btnNuevoAdministrador_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoRangoTutor>(panelForm);
        }

        private void txtBuscar_OnTextChange(object sender, EventArgs e)
        {
            grado.listarGrado(dgvRangosTutores, txtBuscar.text);
        }
    }
}
