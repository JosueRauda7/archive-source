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

        public void abrirFormulario(System.Windows.Forms.Panel panelForm, int id, int moduloForm)
        {
            //Ejemplo:
            //abrirFormulario<FormularioAbrir>(panelForm, id, qué formulario);
            //abrirFormulario<EditarTutor(panelForm, 1, 1);

            System.Windows.Forms.Form formularios; //Contenedor de formularios (panelForm)

            //formularios = panelForm.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            formularios = null; //Cerrar los formularios dentro del panel

            if (formularios == null)
            {
                /*formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = System.Windows.Forms.DockStyle.Fill
                };*/

                switch (moduloForm)
                {
                    //Administrador


                    case 1: //Editar Admin
                        formularios = new Formularios.Administrador.EditarTutor(id){
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 2: //Editar Tutor
                        formularios = new Formularios.Administrador.EditarAdministrador(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 3: //Editar Rango Tutor
                        formularios = new Formularios.Administrador.EditarRangoTutor(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 4: //Editar TipoRegalo
                        formularios = new Formularios.Administrador.EditarTipoRegalo(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;


                    //Tutor

                    case 5: //Editar Beneficiario
                        formularios = new Formularios.Tutor.Beneficiarios.EditarBeneficiario(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 6: //Editar Familia
                        formularios = new Formularios.Tutor.Familias.EditarFamilia(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 7: //Editar Historial Médico
                        formularios = new Formularios.Tutor.Historial.EditarHistorialMed(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 8: //Editar Estudio
                        formularios = new Formularios.Tutor.Estudios.EditarEstudio(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 9: //Editar Medicamento
                        formularios = new Formularios.Tutor.Medicamentos.EditarMedicamento(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 10: //Editar Escuela
                        formularios = new Formularios.Tutor.Escuelas.EditarEscuela(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
                        break;
                    case 11: //Editar Regalo
                        formularios = new Formularios.Tutor.Gift.Editar_Regalo(id)
                        {
                            TopLevel = false,
                            Dock = System.Windows.Forms.DockStyle.Fill
                        };
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
