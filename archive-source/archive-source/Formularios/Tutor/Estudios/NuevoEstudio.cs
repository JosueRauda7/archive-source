using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source.Formularios.Tutor.Estudios
{
    public partial class NuevoEstudio : Form
    {
        public NuevoEstudio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscadorArchivos = new OpenFileDialog();
            buscadorArchivos.Title = "Seleccione una imagen";
            buscadorArchivos.Filter = "*.jpg|*.jpg";
            buscadorArchivos.InitialDirectory = "C:\\";
            if (buscadorArchivos.ShowDialog() == DialogResult.OK)
            {
                string imagen = buscadorArchivos.FileName;
                MessageBox.Show(imagen);
            }
        }
    }
}
