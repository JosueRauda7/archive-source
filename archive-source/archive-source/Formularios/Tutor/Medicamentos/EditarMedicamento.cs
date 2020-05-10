using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Medicamentos
{
    public partial class EditarMedicamento : Form
    {
        int idMedicamento = 0;

        public EditarMedicamento()
        {
            InitializeComponent();
        }

        public EditarMedicamento(int id)
        {
            InitializeComponent();
            idMedicamento = id;
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
