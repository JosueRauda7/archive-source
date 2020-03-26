using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archive_source
{
    class AgregarForm
    {
        public void abrirFormulario<FormularioAbrir>(System.Windows.Forms.Panel panelForm) where FormularioAbrir : System.Windows.Forms.Form, new()
        {
            System.Windows.Forms.Form formularios; //Contenedor de formularios (panelForm)

            formularios = panelForm.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            formularios = null; //Cerrar los formularios dentro del panel

            if (formularios == null)
            {
                formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = System.Windows.Forms.DockStyle.Fill
                };

                panelForm.Controls.Add(formularios);

                panelForm.Tag = formularios;

                formularios.Show();

                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }

        }

    }
}
