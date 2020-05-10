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

        public void abrirFormulario<FormularioAbrir>(System.Windows.Forms.Panel panelForm, int id, int moduloForm) where FormularioAbrir : System.Windows.Forms.Form, new()
        {
            //Ejemplo:
            //abrirFormulario<FormularioAbrir>(panelForm, id, qué formulario);
            //abrirFormulario<EditarTutor(panelForm, 1, 1);

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

                switch (moduloForm)
                {
                    //Administrador


                    case 1: //Editar Admin
                        formularios = new Formularios.Administrador.EditarTutor(id);
                        break;
                    case 2: //Editar Tutor
                        formularios = new Formularios.Administrador.EditarAdministrador(id);
                        break;
                    case 3: //Editar Rango Tutor
                        formularios = new Formularios.Administrador.EditarRangoTutor(id);
                        break;
                    case 4: //Editar TipoRegalo
                        formularios = new Formularios.Administrador.EditarTipoRegalo(id);
                        break;


                    //Tutor

                    case 5: //Editar Beneficiario
                        formularios = new Formularios.Tutor.Beneficiarios.EditarBeneficiario(id);
                        break;
                    case 6: //Editar 
                        formularios = new Formularios.Tutor.Familias.EditarFamilia(id);
                        break;
                    case 7:
                        formularios = new Formularios.Tutor.Historial.EditarHistorialMed(id);
                        break;
                    case 8:
                        formularios = new Formularios.Tutor.Estudios.EditarEstudio(id);
                        break;
                    case 9:
                        formularios = new Formularios.Tutor.Medicamentos.EditarMedicamento(id);
                        break;
                    case 10:
                        formularios = new Formularios.Tutor.Escuelas.EditarEscuela(id);
                        break;
                    case 11:
                        formularios = new Formularios.Tutor.Gift.Editar_Regalo(id);
                        break;
                    default:
                        break;
                }

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
