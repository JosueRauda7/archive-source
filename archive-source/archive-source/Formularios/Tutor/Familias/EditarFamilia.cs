using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Familias
{
    public partial class EditarFamilia : Form
    {
        int idFamilia = 0;

        public EditarFamilia()
        {
            InitializeComponent();
        }

        public EditarFamilia(int id)
        {
            InitializeComponent();
            idFamilia = id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
