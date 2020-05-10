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
    public partial class NuevoRangoTutor : Form
    {
        Grado grado = new Grado();
        public NuevoRangoTutor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edadMin, edadMax;

            edadMin = int.Parse(txtEdadMinima.Text);
            edadMax = int.Parse(txtEdadMaxima.Text);

            grado.insertarGrado(txtNombreGrado.Text,edadMin,edadMax);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
