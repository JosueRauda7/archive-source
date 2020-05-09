using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Estudios
{
    public partial class FormEstudios : Form
    {
        public FormEstudios()
        {
            InitializeComponent();
        }

        private void btnNuevoEstudio_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoEstudio>(panelForm);
        }
    }
}
