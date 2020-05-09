using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Gift
{
    public partial class FormGift : Form
    {
        public FormGift()
        {
            InitializeComponent();
        }

        private void btnNuevaFamilia_Click(object sender, EventArgs e)
        {
            AgregarForm form = new AgregarForm();
            form.abrirFormulario<NuevoRegalo>(panelForm);
        }
    }
}
