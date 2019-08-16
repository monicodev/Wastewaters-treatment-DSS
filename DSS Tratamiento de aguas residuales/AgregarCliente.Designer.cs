namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class AgregarCliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textRazonSocial = new System.Windows.Forms.TextBox();
            this.textRIF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label5
            //
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 77);
            this.label5.TabIndex = 10;
            this.label5.Text = "Formulario cliente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // textDireccion
            //
            this.textDireccion.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.Location = new System.Drawing.Point(198, 220);
            this.textDireccion.MaxLength = 200;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(196, 34);
            this.textDireccion.TabIndex = 3;
            //
            // textRazonSocial
            //
            this.textRazonSocial.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRazonSocial.Location = new System.Drawing.Point(198, 168);
            this.textRazonSocial.MaxLength = 80;
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(196, 34);
            this.textRazonSocial.TabIndex = 2;
            //
            // textRIF
            //
            this.textRIF.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRIF.Location = new System.Drawing.Point(198, 116);
            this.textRIF.MaxLength = 15;
            this.textRIF.Name = "textRIF";
            this.textRIF.Size = new System.Drawing.Size(196, 34);
            this.textRIF.TabIndex = 1;
            this.textRIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNum_KeyPress);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dirección:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "Razón social:";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "RIF:";
            //
            // textTelefono
            //
            this.textTelefono.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(198, 272);
            this.textTelefono.MaxLength = 15;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(196, 34);
            this.textTelefono.TabIndex = 4;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNum_KeyPress);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teléfono:";
            //
            // btnAgregarC
            //
            this.btnAgregarC.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.Location = new System.Drawing.Point(141, 335);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(148, 56);
            this.btnAgregarC.TabIndex = 5;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.BtnAgregarC_Click);
            //
            // AgregarCliente
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 412);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textRazonSocial);
            this.Controls.Add(this.textRIF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "AgregarCliente";
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textRazonSocial;
        private System.Windows.Forms.TextBox textRIF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarC;
    }
}
