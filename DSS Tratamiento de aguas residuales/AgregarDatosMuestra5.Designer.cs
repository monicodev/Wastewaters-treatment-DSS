namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class AgregarDatosMuestra5
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
            this.btnAgregarDatosM = new System.Windows.Forms.Button();
            this.textTemperatura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDbo5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textTurbiedad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textCaudal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textConductividad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // btnAgregarDatosM
            //
            this.btnAgregarDatosM.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatosM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarDatosM.Location = new System.Drawing.Point(152, 447);
            this.btnAgregarDatosM.Name = "btnAgregarDatosM";
            this.btnAgregarDatosM.Size = new System.Drawing.Size(142, 59);
            this.btnAgregarDatosM.TabIndex = 8;
            this.btnAgregarDatosM.Text = "Agregar";
            this.btnAgregarDatosM.UseVisualStyleBackColor = true;
            this.btnAgregarDatosM.Click += new System.EventHandler(this.BtnAgregarDatosM_Click);
            //
            // textTemperatura
            //
            this.textTemperatura.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTemperatura.Location = new System.Drawing.Point(256, 78);
            this.textTemperatura.MaxLength = 8;
            this.textTemperatura.Name = "textTemperatura";
            this.textTemperatura.Size = new System.Drawing.Size(158, 34);
            this.textTemperatura.TabIndex = 1;
            this.textTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 32);
            this.label7.TabIndex = 56;
            this.label7.Text = "Turbiedad (NTU)";
            //
            // label4
            //
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 57);
            this.label4.TabIndex = 52;
            this.label4.Text = "Agregar Muestra (Punto 5)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // textDbo5
            //
            this.textDbo5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDbo5.Location = new System.Drawing.Point(255, 343);
            this.textDbo5.MaxLength = 8;
            this.textDbo5.Name = "textDbo5";
            this.textDbo5.Size = new System.Drawing.Size(158, 34);
            this.textDbo5.TabIndex = 6;
            this.textDbo5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 32);
            this.label14.TabIndex = 68;
            this.label14.Text = "DBO(5) (mg/l)";
            //
            // textTurbiedad
            //
            this.textTurbiedad.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTurbiedad.Location = new System.Drawing.Point(255, 131);
            this.textTurbiedad.MaxLength = 8;
            this.textTurbiedad.Name = "textTurbiedad";
            this.textTurbiedad.Size = new System.Drawing.Size(158, 34);
            this.textTurbiedad.TabIndex = 2;
            this.textTurbiedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 32);
            this.label12.TabIndex = 64;
            this.label12.Text = "Caudal (m3/día)";
            //
            // textCaudal
            //
            this.textCaudal.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCaudal.Location = new System.Drawing.Point(256, 290);
            this.textCaudal.MaxLength = 8;
            this.textCaudal.Name = "textCaudal";
            this.textCaudal.Size = new System.Drawing.Size(157, 34);
            this.textCaudal.TabIndex = 5;
            this.textCaudal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 32);
            this.label11.TabIndex = 62;
            this.label11.Text = "Conductividad (µS/Cm)";
            //
            // textConductividad
            //
            this.textConductividad.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConductividad.Location = new System.Drawing.Point(256, 184);
            this.textConductividad.MaxLength = 8;
            this.textConductividad.Name = "textConductividad";
            this.textConductividad.Size = new System.Drawing.Size(158, 34);
            this.textConductividad.TabIndex = 3;
            this.textConductividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "Temperatura (Cº)";
            //
            // textOd
            //
            this.textOd.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOd.Location = new System.Drawing.Point(256, 237);
            this.textOd.MaxLength = 8;
            this.textOd.Name = "textOd";
            this.textOd.Size = new System.Drawing.Size(158, 34);
            this.textOd.TabIndex = 4;
            this.textOd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 78;
            this.label2.Text = "Oxigeno disuelto (mg/l)";
            //
            // textSst
            //
            this.textSst.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSst.Location = new System.Drawing.Point(256, 396);
            this.textSst.MaxLength = 8;
            this.textSst.Name = "textSst";
            this.textSst.Size = new System.Drawing.Size(158, 34);
            this.textSst.TabIndex = 7;
            this.textSst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 77;
            this.label3.Text = "SST (mg/l)";
            //
            // AgregarDatosMuestra5
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 522);
            this.Controls.Add(this.textOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textConductividad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDbo5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textTurbiedad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textCaudal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAgregarDatosM);
            this.Controls.Add(this.textTemperatura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(455, 560);
            this.MinimumSize = new System.Drawing.Size(455, 560);
            this.Name = "AgregarDatosMuestra5";
            this.Text = "Agregar Datos Muestra Punto 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDatosM;
        private System.Windows.Forms.TextBox textTemperatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDbo5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textTurbiedad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCaudal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textConductividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSst;
        private System.Windows.Forms.Label label3;
    }
}
