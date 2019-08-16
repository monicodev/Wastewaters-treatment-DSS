using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class ImprimirGraficas : Form
    {

        public ImprimirGraficas(ArrayList X, ArrayList Y, string str1, string str2, string param, DataRow DR)
        {
            InitializeComponent();
            try
            {
                grafico.Series[0].Points.DataBindXY(X, Y);
                grafico.Series[0].Sort(PointSortOrder.Ascending, "X");
                grafico.DataManipulator.IsStartFromFirst = true;
                Titulo.Text = "Gráfica independiente en el tiempo de " + param + CompararFechas(str1, str2);
                grafico.ChartAreas[0].AxisX.Title = "Dia";
                grafico.ChartAreas[0].AxisY.Title = "prom";
                grafico.ChartAreas[0].AxisX.Maximum = 0;
                grafico.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, "Linear, 0, false, false", grafico.Series[0], grafico.Series["TrendLine"]);
                GetEcuacion3(grafico.Series["TrendLine"].Points[0], grafico.Series["TrendLine"].Points[1]);

                if (DR != null)
                {
                    grafico.Series.Add("Valor Máximo");
                    grafico.Series["Valor Máximo"].ChartType = SeriesChartType.Line;
                    grafico.Series["Valor Máximo"].BorderWidth = 4;
                    grafico.Series["Valor Máximo"].Color = Color.FromArgb(12, 84, 38);
                    //251, 204, 0
                    //28, 161, 220
                    //12,84,38
                    if (!string.IsNullOrWhiteSpace(DR[0].ToString()))
                    {
                        grafico.Series.Add("Valor Minimo");
                        grafico.Series["Valor Mínimo"].ChartType = SeriesChartType.Line;
                        grafico.Series["Valor Mínimo"].BorderWidth = 4;
                        grafico.Series["Valor Mínimo"].Color = Color.OrangeRed;
                        for (int i = 0; i < X.Count; i++)
                        {
                            grafico.Series["Valor Mínimo"].Points.AddXY(X[i], DR[0]);
                            grafico.Series["Valor Máximo"].Points.AddXY(X[i], DR[1]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < X.Count; i++)
                        {
                            grafico.Series["Valor Máximo"].Points.AddXY(X[i], DR[1]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [ImprimirGraficas]\n" + e.Message);
            }
        }

        public ImprimirGraficas(ArrayList X, ArrayList Y, string param1, string param2, string str1, string str2)
        {
            InitializeComponent();
            try
            {
                grafico.Series[0].Points.DataBindXY(X, Y);
                grafico.Series[0].Sort(PointSortOrder.Ascending, "X");
                grafico.Series[0].ChartType = SeriesChartType.Point;
                grafico.Series[0].Color = Color.White;
                grafico.Series[0].MarkerBorderColor = Color.Blue;
                grafico.Series[0].MarkerSize = 11;
                grafico.Series[0].MarkerBorderWidth = 3;
                grafico.Series["TrendLine"].BorderWidth = 3;
                grafico.DataManipulator.IsStartFromFirst = true;
                Titulo.Text = "Correlación de variables " + param1 + " Versus " + param2 + CompararFechas(str1, str2);
                grafico.ChartAreas[0].AxisX.Title = param1;
                grafico.ChartAreas[0].AxisY.Title = param2;
                grafico.ChartAreas[0].AxisX.Minimum = 0;
                grafico.ChartAreas[0].AxisY.Minimum = 0;
                grafico.ChartAreas[0].AxisX.Crossing = 0;
                grafico.ChartAreas[0].AxisY.Crossing = 0;
                grafico.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, "Linear, 0, false, false", grafico.Series[0], grafico.Series["TrendLine"]);
                GetEcuacion4(grafico.Series["TrendLine"].Points[0], grafico.Series["TrendLine"].Points[1], param1, param2);
                Correlacion(X, Y);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [ImprimirGraficas]\n" + e.Message);
            }
        }

        public ImprimirGraficas(ArrayList X, ArrayList Y, string str1, string str2, DataRow DR)
        {
            InitializeComponent();
            try
            {
                grafico.Series[0].Points.DataBindXY(X, Y);
                grafico.Series[0].Sort(PointSortOrder.Ascending, "X");
                grafico.DataManipulator.IsStartFromFirst = true;
                Titulo.Text = "Determinación de F/M " + CompararFechas(str1, str2);
                grafico.ChartAreas[0].AxisX.Title = "Dia";
                grafico.ChartAreas[0].AxisY.Title = "F/M";
                grafico.ChartAreas[0].AxisX.Maximum = 0;
                grafico.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, "Linear, 0, false, false", grafico.Series[0], grafico.Series["TrendLine"]);
                GetEcuacion3(grafico.Series["TrendLine"].Points[0], grafico.Series["TrendLine"].Points[1]);

                if (DR != null)
                {
                    grafico.Series.Add("Valor Máximo");
                    grafico.Series["Valor Máximo"].ChartType = SeriesChartType.Line;
                    grafico.Series["Valor Máximo"].BorderWidth = 4;
                    grafico.Series["Valor Máximo"].Color = Color.FromArgb(12, 84, 38);
                    if (!string.IsNullOrWhiteSpace(DR[0].ToString()))
                    {
                        grafico.Series.Add("Valor Mínimo");
                        grafico.Series["Valor Mínimo"].ChartType = SeriesChartType.Line;
                        grafico.Series["Valor Mínimo"].BorderWidth = 4;
                        grafico.Series["Valor Mínimo"].Color = Color.OrangeRed;
                        for (int i = 0; i < X.Count; i++)
                        {
                            grafico.Series["Valor Mínimo"].Points.AddXY(X[i], DR[0]);
                            grafico.Series["Valor Máximo"].Points.AddXY(X[i], DR[1]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < X.Count; i++)
                        {
                            grafico.Series["Valor Máximo"].Points.AddXY(X[i], DR[1]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [ImprimirGraficas]\n" + e.Message);
            }
        }

        private string CompararFechas(string s1, string s2)
        {
            if (string.Compare(s1, s2) != 0)
            {
                return "\n  Desde " + s1 + " Hasta " + s2;
            }
            return null;
        }

        public ImprimirGraficas(int numero, ArrayList X, ArrayList Y, DateTime fecha)
        {
            InitializeComponent();
            try
            {
                grafico.Series[0].Points.DataBindXY(X, Y);
                grafico.Series[0].Sort(PointSortOrder.Ascending, "X");
                grafico.DataManipulator.IsStartFromFirst = true;
                if (numero == 1)
                {
                    Titulo.Text = "Determinación de la constante de desoxigenacion y DBOultimo " + fecha.ToString("dd-MM-yyyy");
                    grafico.ChartAreas[0].AxisX.Title = "Dia";
                    grafico.ChartAreas[0].AxisY.Title = "(t/y)1/3";
                    grafico.ChartAreas[0].AxisX.Minimum = 0;
                    grafico.ChartAreas[0].AxisY.Minimum = 0;
                    grafico.ChartAreas[0].AxisX.Interval = 1;
                    grafico.ChartAreas[0].AxisX.Maximum = 8;
                    grafico.ChartAreas[0].AxisY.Interval = 0.1;
                    grafico.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, "Linear, 0, false, false", grafico.Series[0], grafico.Series["TrendLine"]);
                    GetEcuacion1(grafico.Series["TrendLine"].Points[0], grafico.Series["TrendLine"].Points[1]);
                }
                else if (numero == 2)
                {
                    Titulo.Text = "Determinación del coeficiente de decantamiento y productividad\nDesde " + fecha.ToString("dd-MM-yyyy") + " Hasta " + fecha.AddDays(6).ToString("dd-MM-yyyy");
                    grafico.ChartAreas[0].AxisX.Title = "1/Өc";
                    grafico.ChartAreas[0].AxisY.Title = "(So-S)/ӨX";
                    grafico.ChartAreas[0].AxisY.Minimum = 0;
                    grafico.ChartAreas[0].AxisX.Minimum = 0;
                    grafico.ChartAreas[0].AxisX.Interval = 0.2;
                    grafico.ChartAreas[0].AxisX.Maximum = 1.2;
                    grafico.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, "Linear, 0, false, false", grafico.Series[0], grafico.Series["TrendLine"]);
                    GetEcuacion2(grafico.Series["TrendLine"].Points[0], grafico.Series["TrendLine"].Points[1]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [ImprimirGraficas]\n" + e.Message);
            }
        }

        private void Correlacion(ArrayList X, ArrayList Y)
        {
            float sumaX = 0, sumaY = 0, sumaX2 = 0, sumaY2 = 0, sumaXY = 0;
            int N = X.Count;
            for (int i = 0; i < N; i++)
            {
                sumaX += (float)X[i];
                sumaY += (float)Y[i];
                sumaX2 += (float)X[i] * (float)X[i];
                sumaY2 += (float)Y[i] * (float)Y[i];
                sumaXY += (float)X[i] * (float)Y[i];
            }
            float promX = sumaX / N;
            float promY = sumaY / N;
            float Sx = (float)Math.Sqrt((sumaX2 / N) - (promX * promX));
            float Sy = (float)Math.Sqrt((sumaY2 / N) - (promY * promY));
            labelK.Text = "Correlación: " + (((sumaXY / N) - (promX * promY)) / (Sx * Sy)).ToString("0.#####");
        }

        private void GetEcuacion1(DataPoint pt1, DataPoint pt2)
        {
            double pendiente = GetPendiente(pt1, pt2);
            double intercepcion = GetIntercepcion(pendiente, pt1);
            double k = 2.61 * pendiente / intercepcion;
            double lo = 1 / (2.3 * k * intercepcion * intercepcion * intercepcion);
            labelPendiente.Text += pendiente.ToString("0.####");
            labelIntercepcion.Text += intercepcion.ToString("0.###");
            labelK.Text += k.ToString("0.##");
            labelLo.Text += lo.ToString("0.##");
            labelEcuacion.Text = "Y = " + pendiente.ToString("0.####") + " X + " + intercepcion.ToString("0.####");
        }

        private void GetEcuacion2(DataPoint pt1, DataPoint pt2)
        {
            double pendiente = GetPendiente(pt1, pt2);
            double intercepcion = GetIntercepcion(pendiente, pt1);
            double k = -intercepcion;
            double lo = pendiente;
            labelPendiente.Text += pendiente.ToString("0.####");
            labelIntercepcion.Text += intercepcion.ToString("0.####");
            labelK.Text = "Kd: " + k.ToString("0.##");
            labelLo.Text = "Y: " + lo.ToString("0.##");
            labelEcuacion.Text = "Y = " + pendiente.ToString("0.####") + " X + " + intercepcion.ToString("0.####");
        }

        private void GetEcuacion4(DataPoint pt1, DataPoint pt2, string co1, string co2)
        {
            double pendiente = GetPendiente(pt1, pt2);
            double intercepcion = GetIntercepcion(pendiente, pt1);
            labelPendiente.Text += pendiente.ToString("0.####");
            labelIntercepcion.Text += intercepcion.ToString("0.###");
            labelEcuacion.Text = co2 + " = " + pendiente.ToString("0.####") + " " + co1 + " + " + intercepcion.ToString("0.###");
            labelLo.Text = "";
        }

        private void GetEcuacion3(DataPoint pt1, DataPoint pt2)
        {
            double pendiente = GetPendiente(pt1, pt2);
            double intercepcion = GetIntercepcion(pendiente, pt1);
            labelPendiente.Text += pendiente.ToString("0.####");
            labelIntercepcion.Text += intercepcion.ToString("0.###");
            labelK.Text = "";
            labelLo.Text = "";
            labelEcuacion.Text = "Y = " + pendiente.ToString("0.####") + " X + " + intercepcion.ToString("0.###");
        }

        private double GetPendiente(DataPoint pt1, DataPoint pt2)
        {
            return GetPendiente(pt1.XValue, pt1.YValues[0], pt2.XValue, pt2.YValues[0]);
        }

        private double GetPendiente(double x1, double y1, double x2, double y2)
        {
            return (y2 - y1) / (x2 - x1);
        }

        private double GetIntercepcion(double pendiente, DataPoint pt1)
        {
            double y = pt1.YValues[0];
            double x = pt1.XValue;
            return y - (pendiente * x);
        }
    }
}

