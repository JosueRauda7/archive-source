namespace archive_source.Formularios.Administrador
{
    partial class FormAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnNuevoAdministrador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvAdministradores = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministradores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevoAdministrador);
            this.panelForm.Controls.Add(this.txtBuscar);
            this.panelForm.Controls.Add(this.dgvAdministradores);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1244, 545);
            this.panelForm.TabIndex = 6;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // btnNuevoAdministrador
            // 
            this.btnNuevoAdministrador.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoAdministrador.BorderRadius = 0;
            this.btnNuevoAdministrador.ButtonText = "Nuevo Administrador";
            this.btnNuevoAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAdministrador.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoAdministrador.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoAdministrador.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoAdministrador.Iconimage")));
            this.btnNuevoAdministrador.Iconimage_right = null;
            this.btnNuevoAdministrador.Iconimage_right_Selected = null;
            this.btnNuevoAdministrador.Iconimage_Selected = null;
            this.btnNuevoAdministrador.IconMarginLeft = 0;
            this.btnNuevoAdministrador.IconMarginRight = 0;
            this.btnNuevoAdministrador.IconRightVisible = true;
            this.btnNuevoAdministrador.IconRightZoom = 0D;
            this.btnNuevoAdministrador.IconVisible = true;
            this.btnNuevoAdministrador.IconZoom = 90D;
            this.btnNuevoAdministrador.IsTab = false;
            this.btnNuevoAdministrador.Location = new System.Drawing.Point(63, 128);
            this.btnNuevoAdministrador.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoAdministrador.Name = "btnNuevoAdministrador";
            this.btnNuevoAdministrador.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoAdministrador.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevoAdministrador.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoAdministrador.selected = false;
            this.btnNuevoAdministrador.Size = new System.Drawing.Size(203, 59);
            this.btnNuevoAdministrador.TabIndex = 4;
            this.btnNuevoAdministrador.Text = "Nuevo Administrador";
            this.btnNuevoAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAdministrador.Textcolor = System.Drawing.Color.White;
            this.btnNuevoAdministrador.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAdministrador.Click += new System.EventHandler(this.btnNuevoAdministrador_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Snow;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(612, 135);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(333, 52);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.text = "";
            this.txtBuscar.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // dgvAdministradores
            // 
            this.dgvAdministradores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAdministradores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdministradores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAdministradores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdministradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdministradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdministradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdministradores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdministradores.DoubleBuffered = true;
            this.dgvAdministradores.EnableHeadersVisualStyles = false;
            this.dgvAdministradores.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvAdministradores.HeaderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAdministradores.Location = new System.Drawing.Point(63, 194);
            this.dgvAdministradores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAdministradores.Name = "dgvAdministradores";
            this.dgvAdministradores.ReadOnly = true;
            this.dgvAdministradores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAdministradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministradores.Size = new System.Drawing.Size(883, 310);
            this.dgvAdministradores.TabIndex = 2;
            this.dgvAdministradores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdministradores_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRADORES";
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 545);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoAdministrador;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAdministradores;
        private System.Windows.Forms.Label label1;
    }
}