namespace archive_source
{
    partial class EjemploInterfazUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjemploInterfazUsuario));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOpcionMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTutor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelPrincipal.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelForm);
            this.panelPrincipal.Controls.Add(this.PanelInferior);
            this.panelPrincipal.Controls.Add(this.panelSuperior);
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1200, 700);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Location = new System.Drawing.Point(238, 106);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(949, 482);
            this.panelForm.TabIndex = 3;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(232, 594);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(968, 106);
            this.PanelInferior.TabIndex = 2;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.panelSuperior.Controls.Add(this.panelBotones);
            this.panelSuperior.Controls.Add(this.btnMenu);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(232, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(968, 100);
            this.panelSuperior.TabIndex = 1;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Controls.Add(this.btnMinimizar);
            this.panelBotones.Controls.Add(this.btnRestaurar);
            this.panelBotones.Controls.Add(this.btnMaximizar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(687, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(281, 100);
            this.panelBotones.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(197, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 67);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(13, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(71, 67);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.InitialImage")));
            this.btnRestaurar.Location = new System.Drawing.Point(102, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(71, 67);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.InitialImage")));
            this.btnMaximizar.Location = new System.Drawing.Point(102, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(71, 67);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(24, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(71, 67);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnTutor);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.btnOpcionMenu);
            this.panelMenu.Controls.Add(this.bunifuSeparator1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(232, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOpcionMenu
            // 
            this.btnOpcionMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOpcionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOpcionMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcionMenu.BorderRadius = 0;
            this.btnOpcionMenu.ButtonText = "Opción Ejemplo";
            this.btnOpcionMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcionMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpcionMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpcionMenu.Iconimage = global::archive_source.Properties.Resources.guardar;
            this.btnOpcionMenu.Iconimage_right = null;
            this.btnOpcionMenu.Iconimage_right_Selected = null;
            this.btnOpcionMenu.Iconimage_Selected = null;
            this.btnOpcionMenu.IconMarginLeft = 20;
            this.btnOpcionMenu.IconMarginRight = 0;
            this.btnOpcionMenu.IconRightVisible = true;
            this.btnOpcionMenu.IconRightZoom = 0D;
            this.btnOpcionMenu.IconVisible = true;
            this.btnOpcionMenu.IconZoom = 90D;
            this.btnOpcionMenu.IsTab = false;
            this.btnOpcionMenu.Location = new System.Drawing.Point(0, 190);
            this.btnOpcionMenu.Name = "btnOpcionMenu";
            this.btnOpcionMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOpcionMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOpcionMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpcionMenu.selected = false;
            this.btnOpcionMenu.Size = new System.Drawing.Size(232, 48);
            this.btnOpcionMenu.TabIndex = 0;
            this.btnOpcionMenu.Text = "Opción Ejemplo";
            this.btnOpcionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcionMenu.Textcolor = System.Drawing.Color.White;
            this.btnOpcionMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionMenu.Click += new System.EventHandler(this.btnOpcionMenu_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(24, 157);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(172, 8);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelSuperior;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = "GUI Admin";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = global::archive_source.Properties.Resources.guardar;
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 20;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 90D;
            this.btnAdmin.IsTab = false;
            this.btnAdmin.Location = new System.Drawing.Point(0, 257);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(232, 48);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "GUI Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Textcolor = System.Drawing.Color.White;
            this.btnAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTutor.BorderRadius = 0;
            this.btnTutor.ButtonText = "GUI Tutor";
            this.btnTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutor.DisabledColor = System.Drawing.Color.Gray;
            this.btnTutor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTutor.Iconimage = global::archive_source.Properties.Resources.guardar;
            this.btnTutor.Iconimage_right = null;
            this.btnTutor.Iconimage_right_Selected = null;
            this.btnTutor.Iconimage_Selected = null;
            this.btnTutor.IconMarginLeft = 20;
            this.btnTutor.IconMarginRight = 0;
            this.btnTutor.IconRightVisible = true;
            this.btnTutor.IconRightZoom = 0D;
            this.btnTutor.IconVisible = true;
            this.btnTutor.IconZoom = 90D;
            this.btnTutor.IsTab = false;
            this.btnTutor.Location = new System.Drawing.Point(0, 326);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTutor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTutor.selected = false;
            this.btnTutor.Size = new System.Drawing.Size(232, 48);
            this.btnTutor.TabIndex = 2;
            this.btnTutor.Text = "GUI Tutor";
            this.btnTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutor.Textcolor = System.Drawing.Color.White;
            this.btnTutor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // EjemploInterfazUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 700);
            this.Name = "EjemploInterfazUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelPrincipal.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpcionMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnTutor;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
    }
}

