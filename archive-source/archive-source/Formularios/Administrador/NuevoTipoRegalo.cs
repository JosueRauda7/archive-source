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
    using archive_source.Clases;
    public partial class NuevoTipoRegalo : Form
    {
        TipoRegalo regalo = new TipoRegalo();
        public NuevoTipoRegalo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            regalo.insertarTipoRegalo(txtTipoRegalo.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
