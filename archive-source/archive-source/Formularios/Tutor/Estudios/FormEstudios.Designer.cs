namespace archive_source.Formularios.Tutor.Estudios
{
    partial class FormEstudios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudios));
            this.panelForm = new System.Windows.Forms.Panel();
            this.dgvEstudios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoEstudio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevoEstudio);
            this.panelForm.Controls.Add(this.txtBuscar);
            this.panelForm.Controls.Add(this.dgvEstudios);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(933, 443);
            this.panelForm.TabIndex = 8;
            // 
            // dgvEstudios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEstudios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEstudios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudios.DoubleBuffered = true;
            this.dgvEstudios.EnableHeadersVisualStyles = false;
            this.dgvEstudios.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEstudios.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEstudios.Location = new System.Drawing.Point(47, 158);
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstudios.Size = new System.Drawing.Size(662, 252);
            this.dgvEstudios.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudios";
            // 
            // btnNuevoEstudio
            // 
            this.btnNuevoEstudio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoEstudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoEstudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoEstudio.BorderRadius = 0;
            this.btnNuevoEstudio.ButtonText = "Nuevo Estudio";
            this.btnNuevoEstudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEstudio.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoEstudio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoEstudio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoEstudio.Iconimage")));
            this.btnNuevoEstudio.Iconimage_right = null;
            this.btnNuevoEstudio.Iconimage_right_Selected = null;
            this.btnNuevoEstudio.Iconimage_Selected = null;
            this.btnNuevoEstudio.IconMarginLeft = 0;
            this.btnNuevoEstudio.IconMarginRight = 0;
            this.btnNuevoEstudio.IconRightVisible = true;
            this.btnNuevoEstudio.IconRightZoom = 0D;
            this.btnNuevoEstudio.IconVisible = true;
            this.btnNuevoEstudio.IconZoom = 90D;
            this.btnNuevoEstudio.IsTab = false;
            this.btnNuevoEstudio.Location = new System.Drawing.Point(47, 104);
            this.btnNuevoEstudio.Name = "btnNuevoEstudio";
            this.btnNuevoEstudio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoEstudio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevoEstudio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoEstudio.selected = false;
            this.btnNuevoEstudio.Size = new System.Drawing.Size(152, 48);
            this.btnNuevoEstudio.TabIndex = 4;
            this.btnNuevoEstudio.Text = "Nuevo Estudio";
            this.btnNuevoEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEstudio.Textcolor = System.Drawing.Color.White;
            this.btnNuevoEstudio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstudio.Click += new System.EventHandler(this.btnNuevoEstudio_Click);
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
            // FormEstudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 443);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstudios";
            this.Text = "FormEstudios";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoEstudio;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEstudios;
        private System.Windows.Forms.Label label1;
    }
}