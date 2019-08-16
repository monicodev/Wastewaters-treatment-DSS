namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class Graficas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbOpcion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUbicacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerarGrafica = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnTabla = new System.Windows.Forms.Button();
            this.cbParametros = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chbtodos = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // cbOpcion
            //
            this.cbOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcion.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpcion.FormattingEnabled = true;
            this.cbOpcion.Items.AddRange(new object[] {
            "1- Determinación de la constante de desoxigenación y DBOultimo",
            "2- Determinación del coeficiente de decantamiento y productividad",
            "3- Gráficas independientes con respecto al tiempo",
            "4- Correlación entre variables",
            "5- Determinación de F/M"});
            this.cbOpcion.Location = new System.Drawing.Point(160, 88);
            this.cbOpcion.Name = "cbOpcion";
            this.cbOpcion.Size = new System.Drawing.Size(471, 36);
            this.cbOpcion.TabIndex = 1;
            this.cbOpcion.SelectedIndexChanged += new System.EventHandler(this.CbOpcion_SelectedIndexChanged);
            //
            // label1
            //
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRAFICAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gráfica:";
            //
            // dtpFecha
            //
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(330, 174);
            this.dtpFecha.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(301, 34);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.Value = new System.DateTime(2018, 12, 11, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.CbParametros_SelectedIndexChanged);
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_KeyPress);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha 1:";
            //
            // cbUbicacion
            //
            this.cbUbicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUbicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUbicacion.Enabled = false;
            this.cbUbicacion.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.Location = new System.Drawing.Point(330, 280);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Size = new System.Drawing.Size(301, 36);
            this.cbUbicacion.TabIndex = 4;
            this.cbUbicacion.SelectedIndexChanged += new System.EventHandler(this.CbUbicacion_SelectedIndexChanged);
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ubicación de la muestra:";
            //
            // btnGenerarGrafica
            //
            this.btnGenerarGrafica.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrafica.Location = new System.Drawing.Point(268, 477);
            this.btnGenerarGrafica.Name = "btnGenerarGrafica";
            this.btnGenerarGrafica.Size = new System.Drawing.Size(144, 58);
            this.btnGenerarGrafica.TabIndex = 7;
            this.btnGenerarGrafica.Text = "Generar gráfica";
            this.btnGenerarGrafica.UseVisualStyleBackColor = true;
            this.btnGenerarGrafica.Click += new System.EventHandler(this.BtnGenerarGrafica_Click);
            //
            // dataGridView
            //
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(268, 369);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(363, 91);
            this.dataGridView.TabIndex = 0;
            //
            // btnTabla
            //
            this.btnTabla.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabla.Location = new System.Drawing.Point(78, 387);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(144, 54);
            this.btnTabla.TabIndex = 6;
            this.btnTabla.Text = "Generar tabla";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.BtnTabla_Click);
            //
            // cbParametros
            //
            this.cbParametros.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbParametros.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbParametros.DropDownHeight = 145;
            this.cbParametros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametros.Enabled = false;
            this.cbParametros.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametros.IntegralHeight = false;
            this.cbParametros.Location = new System.Drawing.Point(330, 323);
            this.cbParametros.Name = "cbParametros";
            this.cbParametros.Size = new System.Drawing.Size(301, 36);
            this.cbParametros.TabIndex = 5;
            this.cbParametros.SelectedIndexChanged += new System.EventHandler(this.CbParametros_SelectedIndexChanged);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Parámetro:";
            //
            // dtpFecha2
            //
            this.dtpFecha2.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha2.Enabled = false;
            this.dtpFecha2.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha2.Location = new System.Drawing.Point(330, 215);
            this.dtpFecha2.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFecha2.MinDate = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(301, 34);
            this.dtpFecha2.TabIndex = 3;
            this.dtpFecha2.Value = new System.DateTime(2018, 12, 11, 0, 0, 0, 0);
            this.dtpFecha2.ValueChanged += new System.EventHandler(this.CbParametros_SelectedIndexChanged);
            this.dtpFecha2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keyboard_KeyPress);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha 2:";
            //
            // chbtodos
            //
            this.chbtodos.AutoSize = true;
            this.chbtodos.Checked = true;
            this.chbtodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbtodos.Enabled = false;
            this.chbtodos.Location = new System.Drawing.Point(330, 256);
            this.chbtodos.Name = "chbtodos";
            this.chbtodos.Size = new System.Drawing.Size(56, 17);
            this.chbtodos.TabIndex = 23;
            this.chbtodos.Text = "Todos";
            this.chbtodos.UseVisualStyleBackColor = true;
            this.chbtodos.CheckedChanged += new System.EventHandler(this.Chbtodos_CheckedChanged);
            //
            // comboBox1
            //
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownHeight = 145;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(330, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 36);
            this.comboBox1.TabIndex = 24;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cliente:";
            //
            // Graficas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chbtodos);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbParametros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGenerarGrafica);
            this.Controls.Add(this.cbUbicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOpcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(680, 550);
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "Graficas";
            this.Text = "Graficas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOpcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerarGrafica;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.ComboBox cbParametros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbtodos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}
