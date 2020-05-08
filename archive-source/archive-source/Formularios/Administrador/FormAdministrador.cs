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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void btnNuevoAdministrador_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoAdministrador>(panelForm);
        }
    }
}
