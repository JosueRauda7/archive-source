using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Historial
{
    public partial class EditarHistorialMed : Form
    {
        int idHistorialMed = 0;

        public EditarHistorialMed()
        {
            InitializeComponent();
        }

        public EditarHistorialMed(int id)
        {
            InitializeComponent();
            idHistorialMed = id;
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
