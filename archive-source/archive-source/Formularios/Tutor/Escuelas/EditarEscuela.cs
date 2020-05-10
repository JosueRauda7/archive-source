using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Escuelas
{
    public partial class EditarEscuela : Form
    {
        int idEscuela = 0;

        public EditarEscuela()
        {
            InitializeComponent();
        }

        public EditarEscuela(int id)
        {
            InitializeComponent();
            idEscuela = id;
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
