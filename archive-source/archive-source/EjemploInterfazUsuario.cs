using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive_source
{
    public partial class EjemploInterfazUsuario : Form
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

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            rectangulogrid = new Rectangle(ClientRectangle.Width - sizegrid, ClientRectangle.Height - sizegrid, sizegrid, sizegrid);

            region.Exclude(rectangulogrid);

            panelPrincipal.Region = region;

            panelForm.Width = ClientRectangle.Width - panelMenu.Width - 12;

            panelForm.Height = ClientRectangle.Height - panelSuperior.Height - PanelInferior.Height - 12;
            
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

        public EjemploInterfazUsuario()
        {
            InitializeComponent();
        }

        int locationX, locationY;
        int formWidth, formHeight;

        private bool maximizado = false;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de Cerrar el Programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(formWidth, formHeight);
            Location = new Point(locationX, locationY);

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(menuContraido)
            {
                btnOpcionMenu.IconMarginRight = 0;
                panelMenu.Width = sizePanelMenuX;
                panelForm.Left = panelMenu.Width + 3;
                panelForm.Width = panelPrincipal.Width - panelMenu.Width - 12;
                menuContraido = false;
            }
            else
            {
                btnOpcionMenu.IconMarginRight = 10;
                panelMenu.Width = sizePanelMenuX - 150;
                panelForm.Left = panelMenu.Width + 3;
                panelForm.Width = panelPrincipal.Width - panelMenu.Width - 12;
                menuContraido = true;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Formularios.Administrador.administradorGUI formAdmin = new Formularios.Administrador.administradorGUI("");
            formAdmin.Show();
            this.Hide();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            Formularios.Tutor.tutorGUI formTutor = new Formularios.Tutor.tutorGUI("");
            formTutor.Show();
            this.Hide();
        }

        private void btnOpcionMenu_Click(object sender, EventArgs e)
        {
            AgregarForm agregarForm = new AgregarForm();
            agregarForm.abrirFormulario<FrmOpcionEjemplo>(panelForm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
