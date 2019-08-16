namespace DSS_Tratamiento_de_aguas_residuales
{
    partial class ImprimirGraficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPendiente = new System.Windows.Forms.Label();
            this.labelIntercepcion = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelLo = new System.Windows.Forms.Label();
            this.labelEcuacion = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            //
            // grafico
            //
            this.grafico.BackColor = System.Drawing.Color.Transparent;
            this.grafico.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold);
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderWidth = 6;
            legend1.Font = new System.Drawing.Font("Simplified Arabic", 12F);
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.Title = "Leyenda";
            legend1.TitleFont = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Bold);
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(0, 11);
            this.grafico.MaximumSize = new System.Drawing.Size(835, 460);
            this.grafico.MinimumSize = new System.Drawing.Size(835, 460);
            this.grafico.Name = "grafico";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Font = null;
            series1.Legend = "Legend1";
            series1.MarkerSize = 14;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Resultados";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "TrendLine";
            this.grafico.Series.Add(series1);
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(835, 460);
            this.grafico.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Simplified Arabic", 14F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            this.grafico.Titles.Add(title1);
            //
            // labelPendiente
            //
            this.labelPendiente.AutoSize = true;
            this.labelPendiente.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendiente.Location = new System.Drawing.Point(670, 267);
            this.labelPendiente.Name = "labelPendiente";
            this.labelPendiente.Size = new System.Drawing.Size(87, 28);
            this.labelPendiente.TabIndex = 2;
            this.labelPendiente.Text = "Pendiente: ";
            //
            // labelIntercepcion
            //
            this.labelIntercepcion.AutoSize = true;
            this.labelIntercepcion.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntercepcion.Location = new System.Drawing.Point(670, 310);
            this.labelIntercepcion.Name = "labelIntercepcion";
            this.labelIntercepcion.Size = new System.Drawing.Size(99, 28);
            this.labelIntercepcion.TabIndex = 3;
            this.labelIntercepcion.Text = "Intersección: ";
            //
            // labelK
            //
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelK.Location = new System.Drawing.Point(670, 353);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(32, 28);
            this.labelK.TabIndex = 4;
            this.labelK.Text = "K: ";
            //
            // labelLo
            //
            this.labelLo.AutoSize = true;
            this.labelLo.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLo.Location = new System.Drawing.Point(670, 396);
            this.labelLo.Name = "labelLo";
            this.labelLo.Size = new System.Drawing.Size(38, 28);
            this.labelLo.TabIndex = 5;
            this.labelLo.Text = "Lo: ";
            //
            // labelEcuacion
            //
            this.labelEcuacion.AutoSize = true;
            this.labelEcuacion.Font = new System.Drawing.Font("Simplified Arabic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEcuacion.Location = new System.Drawing.Point(670, 227);
            this.labelEcuacion.Name = "labelEcuacion";
            this.labelEcuacion.Size = new System.Drawing.Size(46, 25);
            this.labelEcuacion.TabIndex = 6;
            this.labelEcuacion.Text = "label1";
            //
            // Titulo
            //
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(914, 70);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "label1";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ImprimirGraficas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 472);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.labelEcuacion);
            this.Controls.Add(this.labelLo);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelIntercepcion);
            this.Controls.Add(this.labelPendiente);
            this.Controls.Add(this.grafico);
            this.MaximumSize = new System.Drawing.Size(930, 510);
            this.MinimumSize = new System.Drawing.Size(930, 510);
            this.Name = "ImprimirGraficas";
            this.Text = "Graficos";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Label labelPendiente;
        private System.Windows.Forms.Label labelIntercepcion;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelLo;
        private System.Windows.Forms.Label labelEcuacion;
        private System.Windows.Forms.Label Titulo;
    }
}
