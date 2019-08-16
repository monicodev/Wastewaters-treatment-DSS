namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class EditarLimites
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
            this.textValMax = new System.Windows.Forms.TextBox();
            this.textValMin = new System.Windows.Forms.TextBox();
            this.textParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label4
            //
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 69);
            this.label4.TabIndex = 10;
            this.label4.Text = "Actualizar Límites";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //
            // textValMax
            //
            this.textValMax.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValMax.Location = new System.Drawing.Point(215, 199);
            this.textValMax.MaxLength = 11;
            this.textValMax.Name = "textValMax";
            this.textValMax.Size = new System.Drawing.Size(158, 34);
            this.textValMax.TabIndex = 3;
            this.textValMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextValMax_KeyPress);
            //
            // textValMin
            //
            this.textValMin.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValMin.Location = new System.Drawing.Point(215, 149);
            this.textValMin.MaxLength = 11;
            this.textValMin.Name = "textValMin";
            this.textValMin.Size = new System.Drawing.Size(158, 34);
            this.textValMin.TabIndex = 2;
            this.textValMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextValMax_KeyPress);
            //
            // textParam
            //
            this.textParam.Enabled = false;
            this.textParam.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textParam.Location = new System.Drawing.Point(153, 97);
            this.textParam.MaxLength = 0;
            this.textParam.Name = "textParam";
            this.textParam.Size = new System.Drawing.Size(220, 34);
            this.textParam.TabIndex = 1;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 38);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor Máximo:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor Mínimo:";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parámetro:";
            //
            // btnEditarL
            //
            this.btnEditarL.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarL.Location = new System.Drawing.Point(124, 276);
            this.btnEditarL.Name = "btnEditarL";
            this.btnEditarL.Size = new System.Drawing.Size(148, 56);
            this.btnEditarL.TabIndex = 4;
            this.btnEditarL.Text = "Actualizar";
            this.btnEditarL.UseVisualStyleBackColor = true;
            this.btnEditarL.Click += new System.EventHandler(this.BtnEditarL_Click);
            //
            // EditarLimites
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 362);
            this.Controls.Add(this.btnEditarL);
            this.Controls.Add(this.textValMax);
            this.Controls.Add(this.textValMin);
            this.Controls.Add(this.textParam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(413, 400);
            this.MinimumSize = new System.Drawing.Size(413, 400);
            this.Name = "EditarLimites";
            this.Text = "Actualizar Límites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textValMax;
        private System.Windows.Forms.TextBox textValMin;
        private System.Windows.Forms.TextBox textParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarL;
    }
}
