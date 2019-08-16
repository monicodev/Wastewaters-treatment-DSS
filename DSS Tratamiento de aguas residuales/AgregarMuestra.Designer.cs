namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class AgregarMuestras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCaptador = new System.Windows.Forms.ComboBox();
            this.cbAnalista = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUbicacion = new System.Windows.Forms.ComboBox();
            this.btnAgregarDatosM = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbObservacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR MUESTRAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de la muestra:";
            //
            // textID
            //
            this.textID.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(326, 113);
            this.textID.MaxLength = 11;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(283, 34);
            this.textID.TabIndex = 1;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha:";
            //
            // dtpFecha
            //
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(326, 213);
            this.dtpFecha.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(283, 34);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2018, 12, 11, 0, 0, 0, 0);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hora:";
            //
            // cbHora
            //
            this.cbHora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHora.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "08:00",
            "12:00",
            "16:00"});
            this.cbHora.Location = new System.Drawing.Point(326, 262);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(283, 36);
            this.cbHora.TabIndex = 4;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Captador de la muestra";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Analista de la muestra";
            //
            // cbCaptador
            //
            this.cbCaptador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCaptador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCaptador.DropDownHeight = 145;
            this.cbCaptador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaptador.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaptador.FormattingEnabled = true;
            this.cbCaptador.IntegralHeight = false;
            this.cbCaptador.Location = new System.Drawing.Point(326, 313);
            this.cbCaptador.Name = "cbCaptador";
            this.cbCaptador.Size = new System.Drawing.Size(283, 36);
            this.cbCaptador.TabIndex = 5;
            //
            // cbAnalista
            //
            this.cbAnalista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAnalista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnalista.DropDownHeight = 145;
            this.cbAnalista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnalista.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnalista.FormattingEnabled = true;
            this.cbAnalista.IntegralHeight = false;
            this.cbAnalista.Location = new System.Drawing.Point(326, 364);
            this.cbAnalista.Name = "cbAnalista";
            this.cbAnalista.Size = new System.Drawing.Size(283, 36);
            this.cbAnalista.TabIndex = 6;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ubicacion de la muestra";
            //
            // cbUbicacion
            //
            this.cbUbicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUbicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUbicacion.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUbicacion.FormattingEnabled = true;
            this.cbUbicacion.Items.AddRange(new object[] {
            "1- Salida del vertedero",
            "2- Reactor de aireación",
            "3- Salida del reactor de aireación",
            "4- Entrada de la recirculación de lodos",
            "5- Salida del sedimentador secundario",
            "6- Salida de desinfección"});
            this.cbUbicacion.Location = new System.Drawing.Point(326, 415);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Size = new System.Drawing.Size(283, 36);
            this.cbUbicacion.TabIndex = 7;
            //
            // btnAgregarDatosM
            //
            this.btnAgregarDatosM.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatosM.Location = new System.Drawing.Point(242, 531);
            this.btnAgregarDatosM.Name = "btnAgregarDatosM";
            this.btnAgregarDatosM.Size = new System.Drawing.Size(180, 60);
            this.btnAgregarDatosM.TabIndex = 9;
            this.btnAgregarDatosM.Text = "Agregar datos";
            this.btnAgregarDatosM.UseVisualStyleBackColor = true;
            this.btnAgregarDatosM.Click += new System.EventHandler(this.BtnAgregarDatosM_Click);
            //
            // cbCliente
            //
            this.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(326, 162);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(283, 36);
            this.cbCliente.TabIndex = 2;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cliente:";
            //
            // tbObservacion
            //
            this.tbObservacion.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObservacion.Location = new System.Drawing.Point(326, 466);
            this.tbObservacion.MaxLength = 50;
            this.tbObservacion.Name = "tbObservacion";
            this.tbObservacion.Size = new System.Drawing.Size(283, 34);
            this.tbObservacion.TabIndex = 8;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Observación:";
            //
            // AgregarMuestras
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 612);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbObservacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnAgregarDatosM);
            this.Controls.Add(this.cbUbicacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbAnalista);
            this.Controls.Add(this.cbCaptador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(680, 650);
            this.MinimumSize = new System.Drawing.Size(680, 550);
            this.Name = "AgregarMuestras";
            this.Text = "Agregar muestras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCaptador;
        private System.Windows.Forms.ComboBox cbAnalista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.Button btnAgregarDatosM;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbObservacion;
        private System.Windows.Forms.Label label9;
    }
}
