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
    public partial class EditarTipoRegalo : Form
    {
        int idTipoRegalo = 0;

        public EditarTipoRegalo()
        {
            InitializeComponent();
        }

        public EditarTipoRegalo(int id)
        {
            InitializeComponent();
            idTipoRegalo = id;
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
