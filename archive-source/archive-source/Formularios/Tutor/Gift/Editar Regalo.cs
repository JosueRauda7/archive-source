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
    public partial class Editar_Regalo : Form
    {
        int idRegalo = 0;

        public Editar_Regalo()
        {
            InitializeComponent();
        }

        public Editar_Regalo(int id)
        {
            InitializeComponent();
            idRegalo = id;
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
