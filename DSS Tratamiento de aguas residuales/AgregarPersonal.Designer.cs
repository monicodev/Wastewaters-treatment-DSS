namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class AgregarPersonal
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            //
            // cbCargo
            //
            this.cbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Tecnico de Laboratorio",
            "Coordinador de laboratorio",
            "Auxiliar de laboratorio"});
            this.cbCargo.Location = new System.Drawing.Point(167, 269);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(196, 36);
            this.cbCargo.TabIndex = 4;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cargo:";
            //
            // textCedula
            //
            this.textCedula.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCedula.Location = new System.Drawing.Point(167, 114);
            this.textCedula.MaxLength = 9;
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(196, 34);
            this.textCedula.TabIndex = 1;
            this.textCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCedula_KeyPress);
            //
            // textNombre
            //
            this.textNombre.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(167, 166);
            this.textNombre.MaxLength = 15;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(196, 34);
            this.textNombre.TabIndex = 2;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            //
            // textApellido
            //
            this.textApellido.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(167, 218);
            this.textApellido.MaxLength = 15;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(196, 34);
            this.textApellido.TabIndex = 3;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            //
            // btnAgregarP
            //
            this.btnAgregarP.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.Location = new System.Drawing.Point(123, 339);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(148, 56);
            this.btnAgregarP.TabIndex = 5;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.BtnAgregarP_Click);
            //
            // label5
            //
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 77);
            this.label5.TabIndex = 9;
            this.label5.Text = "Formulario personal";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // AgregarPersonal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 417);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(411, 455);
            this.MinimumSize = new System.Drawing.Size(411, 455);
            this.Name = "AgregarPersonal";
            this.Text = "Agregar Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Label label5;
    }
}
