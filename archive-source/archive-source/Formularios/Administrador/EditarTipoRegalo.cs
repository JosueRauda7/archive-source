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
    public partial class EditarTipoRegalo : Form
    {
        TipoRegalo regalo = new TipoRegalo();
        int idTipoRegalo = 0;

        public EditarTipoRegalo()
        {
            InitializeComponent();
        }

        public EditarTipoRegalo(int id)
        {
            InitializeComponent();
            idTipoRegalo = id;
            regalo.recuperarTipoRegalo(idTipoRegalo,txtTipoRegalo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            regalo.modificarTIpoRegalo(idTipoRegalo, txtTipoRegalo.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
