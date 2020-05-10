namespace archive_source.Formularios.Administrador
{
    partial class FormTipoRegalo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoRegalo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnNuevoTipoRegalo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvRegalo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevoTipoRegalo);
            this.panelForm.Controls.Add(this.txtBuscar);
            this.panelForm.Controls.Add(this.dgvRegalo);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1244, 545);
            this.panelForm.TabIndex = 6;
            // 
            // btnNuevoTipoRegalo
            // 
            this.btnNuevoTipoRegalo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoTipoRegalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoTipoRegalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoTipoRegalo.BorderRadius = 0;
            this.btnNuevoTipoRegalo.ButtonText = "Nuevo Tipo de Regalo";
            this.btnNuevoTipoRegalo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTipoRegalo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoTipoRegalo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoTipoRegalo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoTipoRegalo.Iconimage")));
            this.btnNuevoTipoRegalo.Iconimage_right = null;
            this.btnNuevoTipoRegalo.Iconimage_right_Selected = null;
            this.btnNuevoTipoRegalo.Iconimage_Selected = null;
            this.btnNuevoTipoRegalo.IconMarginLeft = 0;
            this.btnNuevoTipoRegalo.IconMarginRight = 0;
            this.btnNuevoTipoRegalo.IconRightVisible = true;
            this.btnNuevoTipoRegalo.IconRightZoom = 0D;
            this.btnNuevoTipoRegalo.IconVisible = true;
            this.btnNuevoTipoRegalo.IconZoom = 90D;
            this.btnNuevoTipoRegalo.IsTab = false;
            this.btnNuevoTipoRegalo.Location = new System.Drawing.Point(63, 128);
            this.btnNuevoTipoRegalo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNuevoTipoRegalo.Name = "btnNuevoTipoRegalo";
            this.btnNuevoTipoRegalo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoTipoRegalo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevoTipoRegalo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoTipoRegalo.selected = false;
            this.btnNuevoTipoRegalo.Size = new System.Drawing.Size(203, 59);
            this.btnNuevoTipoRegalo.TabIndex = 4;
            this.btnNuevoTipoRegalo.Text = "Nuevo Tipo de Regalo";
            this.btnNuevoTipoRegalo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoTipoRegalo.Textcolor = System.Drawing.Color.White;
            this.btnNuevoTipoRegalo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTipoRegalo.Click += new System.EventHandler(this.btnNuevoTipoRegalo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Snow;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.txtBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.Icon")));
            this.txtBuscar.Location = new System.Drawing.Point(612, 135);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(333, 52);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.text = "";
            this.txtBuscar.OnTextChange += new System.EventHandler(this.txtBuscar_OnTextChange);
            // 
            // dgvRegalo
            // 
            this.dgvRegalo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRegalo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegalo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRegalo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegalo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegalo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegalo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegalo.DoubleBuffered = true;
            this.dgvRegalo.EnableHeadersVisualStyles = false;
            this.dgvRegalo.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvRegalo.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.dgvRegalo.Location = new System.Drawing.Point(63, 194);
            this.dgvRegalo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegalo.Name = "dgvRegalo";
            this.dgvRegalo.ReadOnly = true;
            this.dgvRegalo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegalo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegalo.Size = new System.Drawing.Size(883, 310);
            this.dgvRegalo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPOS DE REGALO";
            // 
            // FormTipoRegalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 545);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTipoRegalo";
            this.Text = "FormTipoRegalo";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoTipoRegalo;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRegalo;
        private System.Windows.Forms.Label label1;
    }
}