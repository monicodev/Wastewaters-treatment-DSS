namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class AgregarDatosMuestra4
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarDatosM = new System.Windows.Forms.Button();
            this.textXw = new System.Windows.Forms.TextBox();
            this.textCaudal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label4
            //
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 60);
            this.label4.TabIndex = 41;
            this.label4.Text = "Agregar Muestra (Punto 4)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // btnAgregarDatosM
            //
            this.btnAgregarDatosM.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDatosM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarDatosM.Location = new System.Drawing.Point(146, 205);
            this.btnAgregarDatosM.Name = "btnAgregarDatosM";
            this.btnAgregarDatosM.Size = new System.Drawing.Size(142, 59);
            this.btnAgregarDatosM.TabIndex = 3;
            this.btnAgregarDatosM.Text = "Agregar";
            this.btnAgregarDatosM.UseVisualStyleBackColor = true;
            this.btnAgregarDatosM.Click += new System.EventHandler(this.BtnAgregarDatosM_Click);
            //
            // textXw
            //
            this.textXw.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textXw.Location = new System.Drawing.Point(226, 146);
            this.textXw.MaxLength = 8;
            this.textXw.Name = "textXw";
            this.textXw.Size = new System.Drawing.Size(190, 34);
            this.textXw.TabIndex = 2;
            this.textXw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // textCaudal
            //
            this.textCaudal.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCaudal.Location = new System.Drawing.Point(226, 91);
            this.textCaudal.MaxLength = 8;
            this.textCaudal.Name = "textCaudal";
            this.textCaudal.Size = new System.Drawing.Size(190, 34);
            this.textCaudal.TabIndex = 1;
            this.textCaudal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 52;
            this.label5.Text = "XW (mg/l)";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 51;
            this.label3.Text = "Caudal (m3/Día)";
            //
            // AgregarDatosMuestra4
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 285);
            this.Controls.Add(this.btnAgregarDatosM);
            this.Controls.Add(this.textXw);
            this.Controls.Add(this.textCaudal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(450, 323);
            this.MinimumSize = new System.Drawing.Size(450, 323);
            this.Name = "AgregarDatosMuestra4";
            this.Text = "Agregar Datos Muestra Punto 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarDatosM;
        private System.Windows.Forms.TextBox textXw;
        private System.Windows.Forms.TextBox textCaudal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}
