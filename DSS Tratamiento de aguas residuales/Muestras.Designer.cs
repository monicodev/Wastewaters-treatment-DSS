namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class Muestras
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbUbicacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarMuestra = new System.Windows.Forms.Button();
            this.btnActualizarMuestra = new System.Windows.Forms.Button();
            this.btnAgregarMuestra = new System.Windows.Forms.Button();
            this.btnExportarExc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "MUESTRAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // cbUbicacion
            //
            this.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUbicacion.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbUbicacion.IntegralHeight = false;
            this.cbUbicacion.Items.AddRange(new object[] {
            "Todas las muestras",
            "1- Salida del vertedero",
            "2- Reactor de aireación",
            "3- Salida del reactor de aireación",
            "4- Entrada de la recirculación de lodos",
            "5- Salida del sedimentador secundario",
            "6- Salida de desinfección"});
            this.cbUbicacion.Location = new System.Drawing.Point(314, 104);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Size = new System.Drawing.Size(330, 36);
            this.cbUbicacion.TabIndex = 14;
            this.cbUbicacion.SelectedIndexChanged += new System.EventHandler(this.CbUbicacion_SelectedIndexChanged);
            this.cbUbicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ubicacion de la muestra";
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(43, 208);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 232);
            this.dataGridView1.TabIndex = 0;
            //
            // btnEliminarMuestra
            //
            this.btnEliminarMuestra.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMuestra.Location = new System.Drawing.Point(354, 461);
            this.btnEliminarMuestra.Name = "btnEliminarMuestra";
            this.btnEliminarMuestra.Size = new System.Drawing.Size(113, 59);
            this.btnEliminarMuestra.TabIndex = 16;
            this.btnEliminarMuestra.Text = "Eliminar";
            this.btnEliminarMuestra.UseVisualStyleBackColor = true;
            this.btnEliminarMuestra.Click += new System.EventHandler(this.BtnEliminarMuestra_Click);
            //
            // btnActualizarMuestra
            //
            this.btnActualizarMuestra.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMuestra.Location = new System.Drawing.Point(190, 461);
            this.btnActualizarMuestra.Name = "btnActualizarMuestra";
            this.btnActualizarMuestra.Size = new System.Drawing.Size(127, 59);
            this.btnActualizarMuestra.TabIndex = 17;
            this.btnActualizarMuestra.Text = "Actualizar";
            this.btnActualizarMuestra.UseVisualStyleBackColor = true;
            this.btnActualizarMuestra.Click += new System.EventHandler(this.BtnActualizarMuestra_Click);
            //
            // btnAgregarMuestra
            //
            this.btnAgregarMuestra.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMuestra.Location = new System.Drawing.Point(43, 461);
            this.btnAgregarMuestra.Name = "btnAgregarMuestra";
            this.btnAgregarMuestra.Size = new System.Drawing.Size(110, 59);
            this.btnAgregarMuestra.TabIndex = 18;
            this.btnAgregarMuestra.Text = "Agregar";
            this.btnAgregarMuestra.UseVisualStyleBackColor = true;
            this.btnAgregarMuestra.Click += new System.EventHandler(this.BtnAgregarMuestra_Click);
            //
            // btnExportarExc
            //
            this.btnExportarExc.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExc.Image = global::DSS_Tratamiento_de_aguas_residuales.Properties.Resources.Excel_logo;
            this.btnExportarExc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarExc.Location = new System.Drawing.Point(504, 461);
            this.btnExportarExc.Name = "btnExportarExc";
            this.btnExportarExc.Size = new System.Drawing.Size(140, 59);
            this.btnExportarExc.TabIndex = 20;
            this.btnExportarExc.Text = "Exportar";
            this.btnExportarExc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarExc.UseVisualStyleBackColor = true;
            this.btnExportarExc.Click += new System.EventHandler(this.BtnExportarExc_Click);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buscar:";
            //
            // tbBuscar
            //
            this.tbBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBuscar.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.Color.Black;
            this.tbBuscar.Location = new System.Drawing.Point(314, 152);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(296, 34);
            this.tbBuscar.TabIndex = 23;
            //
            // pictureBox2
            //
            this.pictureBox2.Image = global::DSS_Tratamiento_de_aguas_residuales.Properties.Resources.magnifier;
            this.pictureBox2.Location = new System.Drawing.Point(618, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BtnBuscar_TextChanged);
            //
            // Muestras
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportarExc);
            this.Controls.Add(this.btnAgregarMuestra);
            this.Controls.Add(this.btnActualizarMuestra);
            this.Controls.Add(this.btnEliminarMuestra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbUbicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(680, 550);
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "Muestras";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarMuestra;
        private System.Windows.Forms.Button btnActualizarMuestra;
        private System.Windows.Forms.Button btnAgregarMuestra;
        private System.Windows.Forms.Button btnExportarExc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
