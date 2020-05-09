namespace archive_source.Formularios.Tutor.Beneficiarios
{
    partial class FormMiembroFamiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiembroFamiliar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnNuevoBeneficiario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvBeneficiario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevoBeneficiario);
            this.panelForm.Controls.Add(this.txtBuscar);
            this.panelForm.Controls.Add(this.dgvBeneficiario);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(933, 443);
            this.panelForm.TabIndex = 7;
            // 
            // btnNuevoBeneficiario
            // 
            this.btnNuevoBeneficiario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoBeneficiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoBeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoBeneficiario.BorderRadius = 0;
            this.btnNuevoBeneficiario.ButtonText = "Nuevo Beneficiario";
            this.btnNuevoBeneficiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoBeneficiario.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevoBeneficiario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoBeneficiario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoBeneficiario.Iconimage")));
            this.btnNuevoBeneficiario.Iconimage_right = null;
            this.btnNuevoBeneficiario.Iconimage_right_Selected = null;
            this.btnNuevoBeneficiario.Iconimage_Selected = null;
            this.btnNuevoBeneficiario.IconMarginLeft = 0;
            this.btnNuevoBeneficiario.IconMarginRight = 0;
            this.btnNuevoBeneficiario.IconRightVisible = true;
            this.btnNuevoBeneficiario.IconRightZoom = 0D;
            this.btnNuevoBeneficiario.IconVisible = true;
            this.btnNuevoBeneficiario.IconZoom = 90D;
            this.btnNuevoBeneficiario.IsTab = false;
            this.btnNuevoBeneficiario.Location = new System.Drawing.Point(47, 104);
            this.btnNuevoBeneficiario.Name = "btnNuevoBeneficiario";
            this.btnNuevoBeneficiario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevoBeneficiario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevoBeneficiario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoBeneficiario.selected = false;
            this.btnNuevoBeneficiario.Size = new System.Drawing.Size(152, 48);
            this.btnNuevoBeneficiario.TabIndex = 4;
            this.btnNuevoBeneficiario.Text = "Nuevo Beneficiario";
            this.btnNuevoBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoBeneficiario.Textcolor = System.Drawing.Color.White;
            this.btnNuevoBeneficiario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoBeneficiario.Click += new System.EventHandler(this.btnNuevoBeneficiario_Click);
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
            // dgvBeneficiario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBeneficiario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeneficiario.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBeneficiario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBeneficiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeneficiario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiario.DoubleBuffered = true;
            this.dgvBeneficiario.EnableHeadersVisualStyles = false;
            this.dgvBeneficiario.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvBeneficiario.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvBeneficiario.Location = new System.Drawing.Point(47, 158);
            this.dgvBeneficiario.Name = "dgvBeneficiario";
            this.dgvBeneficiario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBeneficiario.Size = new System.Drawing.Size(662, 252);
            this.dgvBeneficiario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beneficiarios";
            // 
            // FormMiembroFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 443);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMiembroFamiliar";
            this.Text = "FormMiembroFamiliar";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoBeneficiario;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBeneficiario;
        private System.Windows.Forms.Label label1;
    }
}