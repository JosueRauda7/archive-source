namespace archive_source.Formularios.Tutor.Familias
{
    partial class FormFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamilia));
            this.panelForm = new System.Windows.Forms.Panel();
            this.dgvFamilias = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaFamilia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuTextbox();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.panelForm.Controls.Add(this.btnNuevaFamilia);
            this.panelForm.Controls.Add(this.txtBuscar);
            this.panelForm.Controls.Add(this.dgvFamilias);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(933, 443);
            this.panelForm.TabIndex = 6;
            // 
            // dgvFamilias
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFamilias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFamilias.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFamilias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFamilias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilias.DoubleBuffered = true;
            this.dgvFamilias.EnableHeadersVisualStyles = false;
            this.dgvFamilias.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvFamilias.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvFamilias.Location = new System.Drawing.Point(47, 158);
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFamilias.Size = new System.Drawing.Size(662, 252);
            this.dgvFamilias.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAMILIAS";
            // 
            // btnNuevaFamilia
            // 
            this.btnNuevaFamilia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevaFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevaFamilia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaFamilia.BorderRadius = 0;
            this.btnNuevaFamilia.ButtonText = "Nueva Familia";
            this.btnNuevaFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaFamilia.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevaFamilia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevaFamilia.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevaFamilia.Iconimage")));
            this.btnNuevaFamilia.Iconimage_right = null;
            this.btnNuevaFamilia.Iconimage_right_Selected = null;
            this.btnNuevaFamilia.Iconimage_Selected = null;
            this.btnNuevaFamilia.IconMarginLeft = 0;
            this.btnNuevaFamilia.IconMarginRight = 0;
            this.btnNuevaFamilia.IconRightVisible = true;
            this.btnNuevaFamilia.IconRightZoom = 0D;
            this.btnNuevaFamilia.IconVisible = true;
            this.btnNuevaFamilia.IconZoom = 90D;
            this.btnNuevaFamilia.IsTab = false;
            this.btnNuevaFamilia.Location = new System.Drawing.Point(47, 104);
            this.btnNuevaFamilia.Name = "btnNuevaFamilia";
            this.btnNuevaFamilia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnNuevaFamilia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(128)))));
            this.btnNuevaFamilia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevaFamilia.selected = false;
            this.btnNuevaFamilia.Size = new System.Drawing.Size(152, 48);
            this.btnNuevaFamilia.TabIndex = 4;
            this.btnNuevaFamilia.Text = "Nueva Familia";
            this.btnNuevaFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFamilia.Textcolor = System.Drawing.Color.White;
            this.btnNuevaFamilia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFamilia.Click += new System.EventHandler(this.btnNuevaFamilia_Click);
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
            // FormFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 443);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFamilia";
            this.Text = "FormFamilia";
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevaFamilia;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvFamilias;
        private System.Windows.Forms.Label label1;
    }
}