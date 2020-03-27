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
    public partial class FormTutor : Form
    {
        public FormTutor()
        {
            InitializeComponent();
        }

        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoTutor>(panelForm);
        }
    }
}
