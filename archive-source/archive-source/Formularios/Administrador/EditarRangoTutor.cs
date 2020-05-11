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
    public partial class EditarRangoTutor : Form
    {
        Grado grado = new Grado();
        int idRangoTutor = 0;
        public EditarRangoTutor()
        {
            InitializeComponent();
        }

        public EditarRangoTutor(int id)
        {
            InitializeComponent();
            idRangoTutor = id;
            grado.recuperarGrado(idRangoTutor,txtNombreGrado,txtEdadMinima,txtEdadMaxima);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edadMin, edadMax;

            edadMin = int.Parse(txtEdadMinima.Text);
            edadMax = int.Parse(txtEdadMaxima.Text);
            grado.modificarGrado(idRangoTutor, txtNombreGrado.Text, edadMin, edadMax);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
