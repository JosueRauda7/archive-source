namespace archive_source.Formularios.Tutor.Escuelas
{
    partial class FormEscuelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscuelas));
            this.panelForm = new System.Windows.Forms.Panel();
            this.dgvEscuelas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaEscuela = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevaEscuela);
            this.panelForm.Controls.Add(this.txtBuscar);
            this.panelForm.Controls.Add(this.dgvEscuelas);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(933, 443);
            this.panelForm.TabIndex = 8;
            // 
            // dgvEscuelas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEscuelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEscuelas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEscuelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEscuelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEscuelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscuelas.DoubleBuffered = true;
            this.dgvEscuelas.EnableHeadersVisualStyles = false;
            this.dgvEscuelas.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEscuelas.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEscuelas.Location = new System.Drawing.Point(47, 158);
            this.dgvEscuelas.Name = "dgvEscuelas";
            this.dgvEscuelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEscuelas.Size = new System.Drawing.Size(662, 252);
            this.dgvEscuelas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escuelas";
            // 
            // btnNuevaEscuela
            // 
            this.btnNuevaEscuela.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevaEscuela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevaEscuela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaEscuela.BorderRadius = 0;
            this.btnNuevaEscuela.ButtonText = "Nueva Escuela";
            this.btnNuevaEscuela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaEscuela.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevaEscuela.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevaEscuela.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevaEscuela.Iconimage")));
            this.btnNuevaEscuela.Iconimage_right = null;
            this.btnNuevaEscuela.Iconimage_right_Selected = null;
            this.btnNuevaEscuela.Iconimage_Selected = null;
            this.btnNuevaEscuela.IconMarginLeft = 0;
            this.btnNuevaEscuela.IconMarginRight = 0;
            this.btnNuevaEscuela.IconRightVisible = true;
            this.btnNuevaEscuela.IconRightZoom = 0D;
            this.btnNuevaEscuela.IconVisible = true;
            this.btnNuevaEscuela.IconZoom = 90D;
            this.btnNuevaEscuela.IsTab = false;
            this.btnNuevaEscuela.Location = new System.Drawing.Point(47, 104);
            this.btnNuevaEscuela.Name = "btnNuevaEscuela";
            this.btnNuevaEscuela.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevaEscuela.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevaEscuela.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevaEscuela.selected = false;
            this.btnNuevaEscuela.Size = new System.Drawing.Size(152, 48);
            this.btnNuevaEscuela.TabIndex = 4;
            this.btnNuevaEscuela.Text = "Nueva Escuela";
            this.btnNuevaEscuela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaEscuela.Textcolor = System.Drawing.Color.White;
            this.btnNuevaEscuela.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEscuela.Click += new System.EventHandler(this.btnNuevaEscuela_Click);
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
            // FormEscuelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 443);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEscuelas";
            this.Text = "FormEscuelas";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevaEscuela;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEscuelas;
        private System.Windows.Forms.Label label1;
    }
}