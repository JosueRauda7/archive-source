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
    public partial class administradorGUI : Form
    {

        private const int sizePanelFormX = 951;
        private const int sizePanelFormY = 482;
        private const int sizePanelMenuX = 232;
        private const int sizePanelMenuY = 700;
        private const int sizegrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;
        private bool menuContraido = false;
        private Color colorSeleccionado;
        private Color colorNoSeleccionado;

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            rectangulogrid = new Rectangle(ClientRectangle.Width - sizegrid, ClientRectangle.Height - sizegrid, sizegrid, sizegrid);

            region.Exclude(rectangulogrid);

            panelPrincipal.Region = region;

            panelInicio.Width = panelForm.Width = ClientRectangle.Width - panelMenu.Width - 12;

            panelInicio.Height = panelForm.Height = ClientRectangle.Height - panelSuperior.Height - PanelInferior.Height - 12;

            if (btnRestaurar.Visible)
            {
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
            }

            Invalidate();

        }

        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);

                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));

                    if (!rectangulogrid.Contains(RefPoint))
                    {
                        break;
                    }

                    sms.Result = new IntPtr(botonizquierdo);
                    break;

                default:
                    base.WndProc(ref sms);
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(12, 31, 38));

            e.Graphics.FillRectangle(solidBrush, rectangulogrid);

            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);
        }

        private void cambiarColoresBotones(Color color)
        {
            btnInicio.Normalcolor = color;
            btnTutores.Normalcolor = color;
            btnAdministradores.Normalcolor = color;
            btnRangos.Normalcolor = color;
            btnRegalos.Normalcolor = color;

        }

        public administradorGUI()
        {
            InitializeComponent();
            colorSeleccionado = btnInicio.BackColor;
            colorNoSeleccionado = btnAdministradores.BackColor;
            panelInicio.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuContraido)
            {
                btnInicio.IconMarginRight = 0;
                btnTutores.IconMarginRight = 0;
                btnAdministradores.IconMarginRight = 0;
                btnRangos.IconMarginRight = 0;
                btnRegalos.IconMarginRight = 0;

                panelMenu.Width = sizePanelMenuX;
                panelForm.Left = panelMenu.Width + 3;
                panelForm.Width = panelPrincipal.Width - panelMenu.Width - 12;
                menuContraido = false;
            }
            else
            {
                btnInicio.IconMarginRight = 10;
                btnTutores.IconMarginRight = 10;
                btnAdministradores.IconMarginRight = 10;
                btnRangos.IconMarginRight = 10;
                btnRegalos.IconMarginRight = 10;

                panelMenu.Width = sizePanelMenuX - 150;
                panelForm.Left = panelMenu.Width + 3;
                panelForm.Width = panelPrincipal.Width - panelMenu.Width - 12;
                menuContraido = true;
            }
        }

        int locationX, locationY;
        int formWidth, formHeight;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de Cerrar el Programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                InicioSesion login = new InicioSesion();
                login.Show();
                this.Close();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            locationX = Location.X;
            locationY = Location.Y;

            formWidth = Size.Width;
            formHeight = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(formWidth, formHeight);
            Location = new Point(locationX, locationY);

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if(btnInicio.Normalcolor != colorSeleccionado)
            {
                cambiarColoresBotones(colorNoSeleccionado);
                btnInicio.Normalcolor = colorSeleccionado;
            }
            panelInicio.BringToFront();
        }

        //Función llamar forms tutores
        private void verTutores()
        {
            if (btnTutores.Normalcolor != colorSeleccionado)
            {
                cambiarColoresBotones(colorNoSeleccionado);
                btnTutores.Normalcolor = colorSeleccionado;
            }

            AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario<FormTutor>(panelForm);
        }

        private void btnTutores_Click(object sender, EventArgs e)
        {
            verTutores();
        }

        private void btnAbritTutor_Click(object sender, EventArgs e)
        {
            verTutores();
        }

        //Función llamar forms administradores

        private void verAdministradores()
        {
            if (btnAdministradores.Normalcolor != colorSeleccionado)
            {
                cambiarColoresBotones(colorNoSeleccionado);
                btnAdministradores.Normalcolor = colorSeleccionado;
            }

            //Agregar formulario aquí
            /*
             AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario<NombreFormulario>(panelForm);
             */
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            verAdministradores();
        }

        private void btnAbrirAdmin_Click(object sender, EventArgs e)
        {
            verAdministradores();
        }

        //Función llamar forms tipos de rango
        private void verRangos()
        {
            if (btnRangos.Normalcolor != colorSeleccionado)
            {
                cambiarColoresBotones(colorNoSeleccionado);
                btnRangos.Normalcolor = colorSeleccionado;
            }

            //Agregar formulario aquí
            /*
             AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario<NombreFormulario>(panelForm);
             */
        }

        private void btnRangos_Click(object sender, EventArgs e)
        {
            verRangos();
        }

        private void btnAbrirRango_Click(object sender, EventArgs e)
        {
            verRangos();
        }

        //Función llamar tipos de regalo
        private void verRegalos()
        {
            if (btnRegalos.Normalcolor != colorSeleccionado)
            {
                cambiarColoresBotones(colorNoSeleccionado);
                btnRegalos.Normalcolor = colorSeleccionado;
            }

            //Agregar formulario aquí
            /*
             AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario<NombreFormulario>(panelForm);
             */
        }

        private void btnRegalos_Click(object sender, EventArgs e)
        {
            verRegalos();
        }

        private void btnAbrirRegalo_Click(object sender, EventArgs e)
        {
            verRegalos();
        }
    }
}
