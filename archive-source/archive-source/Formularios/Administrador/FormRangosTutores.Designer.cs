namespace archive_source.Formularios.Administrador
{
    partial class FormRangosTutores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRangosTutores));
            this.panelForm = new System.Windows.Forms.Panel();
            this.dgvRangosTutores = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoAdministrador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangosTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevoAdministrador);
            this.panelForm.Controls.Add(this.txtBuscar);
            this.panelForm.Controls.Add(this.dgvRangosTutores);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(933, 443);
            this.panelForm.TabIndex = 7;
            // 
            // dgvRangosTutores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRangosTutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRangosTutores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRangosTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRangosTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRangosTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRangosTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangosTutores.DoubleBuffered = true;
            this.dgvRangosTutores.EnableHeadersVisualStyles = false;
            this.dgvRangosTutores.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvRangosTutores.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvRangosTutores.Location = new System.Drawing.Point(47, 158);
            this.dgvRangosTutores.Name = "dgvRangosTutores";
            this.dgvRangosTutores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRangosTutores.Size = new System.Drawing.Size(662, 252);
            this.dgvRangosTutores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "RANGOS DE TUTORES";
            // 
            // btnNuevoAdministrador
            // 
            this.btnNuevoAdministrador.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoAdministrador.BorderRadius = 0;
            this.btnNuevoAdministrador.ButtonText = "Nuevo Rango";
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
            this.btnNuevoAdministrador.Location = new System.Drawing.Point(47, 104);
            this.btnNuevoAdministrador.Name = "btnNuevoAdministrador";
            this.btnNuevoAdministrador.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoAdministrador.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevoAdministrador.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoAdministrador.selected = false;
            this.btnNuevoAdministrador.Size = new System.Drawing.Size(152, 48);
            this.btnNuevoAdministrador.TabIndex = 4;
            this.btnNuevoAdministrador.Text = "Nuevo Rango";
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
            this.txtBuscar.Location = new System.Drawing.Point(459, 110);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 42);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.text = "";
            // 
            // FormRangosTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 443);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRangosTutores";
            this.Text = "FormRangosTutores";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangosTutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoAdministrador;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRangosTutores;
        private System.Windows.Forms.Label label1;
    }
}