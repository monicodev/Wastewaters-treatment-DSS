namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class Personal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPers = new System.Windows.Forms.Button();
            this.tablaPersonal = new System.Windows.Forms.DataGridView();
            this.btnEditarPer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAgregarPers
            // 
            this.btnAgregarPers.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPers.Location = new System.Drawing.Point(399, 430);
            this.btnAgregarPers.Name = "btnAgregarPers";
            this.btnAgregarPers.Size = new System.Drawing.Size(182, 61);
            this.btnAgregarPers.TabIndex = 1;
            this.btnAgregarPers.Text = "Agregar Personal";
            this.btnAgregarPers.UseVisualStyleBackColor = true;
            this.btnAgregarPers.Click += new System.EventHandler(this.BtnAgregarPers_Click);
            // 
            // tablaPersonal
            // 
            this.tablaPersonal.AllowUserToAddRows = false;
            this.tablaPersonal.AllowUserToDeleteRows = false;
            this.tablaPersonal.AllowUserToResizeColumns = false;
            this.tablaPersonal.AllowUserToResizeRows = false;
            this.tablaPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPersonal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaPersonal.BackgroundColor = System.Drawing.Color.White;
            this.tablaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPersonal.EnableHeadersVisualStyles = false;
            this.tablaPersonal.GridColor = System.Drawing.Color.Black;
            this.tablaPersonal.Location = new System.Drawing.Point(74, 122);
            this.tablaPersonal.MultiSelect = false;
            this.tablaPersonal.Name = "tablaPersonal";
            this.tablaPersonal.ReadOnly = true;
            this.tablaPersonal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaPersonal.RowHeadersVisible = false;
            this.tablaPersonal.RowHeadersWidth = 50;
            this.tablaPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPersonal.Size = new System.Drawing.Size(533, 275);
            this.tablaPersonal.TabIndex = 2;
            // 
            // btnEditarPer
            // 
            this.btnEditarPer.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPer.Location = new System.Drawing.Point(100, 430);
            this.btnEditarPer.Name = "btnEditarPer";
            this.btnEditarPer.Size = new System.Drawing.Size(182, 61);
            this.btnEditarPer.TabIndex = 3;
            this.btnEditarPer.Text = "Actualizar Personal";
            this.btnEditarPer.UseVisualStyleBackColor = true;
            this.btnEditarPer.Click += new System.EventHandler(this.BtnEditarPer_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 550);
            this.Controls.Add(this.btnEditarPer);
            this.Controls.Add(this.tablaPersonal);
            this.Controls.Add(this.btnAgregarPers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(680, 550);
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "Personal";
            this.Text = "Personal";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarPers;
        private System.Windows.Forms.DataGridView tablaPersonal;
        private System.Windows.Forms.Button btnEditarPer;
    }
}