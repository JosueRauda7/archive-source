using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Beneficiarios
{
    public partial class EditarBeneficiario : Form
    {
        int idBeneficiario = 0;

        public EditarBeneficiario()
        {
            InitializeComponent();
        }

        public EditarBeneficiario(int id)
        {
            InitializeComponent();
            idBeneficiario = id;
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
