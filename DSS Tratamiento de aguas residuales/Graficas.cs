using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using System.Globalization;

namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
            btnTabla.Enabled = false;
            btnGenerarGrafica.Enabled = false;
            dtpFecha.Text = DateTime.Now.ToString();
            dtpFecha2.Text = DateTime.Now.ToString();
        }

        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        private void CbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView.DataSource = null;
                cbUbicacion.Enabled = false;
                dtpFecha.Enabled = false;
                dtpFecha2.Enabled = false;
                cbParametros.Enabled = false;
                chbtodos.Enabled = false;
                dtpFecha.Value = DateTime.Now;
                dtpFecha2.Value = DateTime.Now;
                cbUbicacion.Items.Clear();
                cbParametros.Items.Clear();
                switch (cbOpcion.Text[0])
                {
                    case '1':
                        dtpFecha.Enabled = true;
                        break;
                    case '2':
                        dtpFecha.Enabled = true;
                        break;
                    case '3':
                        cbUbicacion.Enabled = true;
                        cbParametros.Enabled = true;
                        chbtodos.Enabled = true;
                        chbtodos.Checked = true;
                        cbUbicacion.Items.AddRange(new object[] {
                        "1- Salida del vertedero",
                        "2- Reactor de aireación",
                        "3- Salida del reactor de aireación",
                        "4- Entrada de la recirculación de lodos",
                        "5- Salida del sedimentador secundario",
                        "6- Salida de desinfección"});
                        break;
                    case '4':
                        cbParametros.Enabled = true;
                        chbtodos.Enabled = true;
                        chbtodos.Checked = true;
                        cbParametros.Items.AddRange(new object[] {
                            /*"1- Conductividad(µS/Cm) versus SST(kg/m)",
                            "2- OD(mg/l) versus SSV(kg/m)",
                            "3- OD(mg/l) versus temperatura(°C)",
                            "4- turbiedad(NTU) versus OD(mg/l)",
                            "5- turbiedad(NTU) versus SST(kg/m)",
                            "6- pH(Unid de acid) versus  DBO(kg/m)",
                            "7- DBO(kg/m) versus OD(mg/l)"*/
                        "1- DBO(mg/l) versus OD(mg/l)",
                        "2- OD(mg/l) versus SSV(mg/l)"});
                        break;
                    case '5':
                        chbtodos.Enabled = true;
                        chbtodos.Checked = true;
                        break;
                    default: break;
                }
                btnTabla.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [CbOpcion_SelectedIndexChanged]\n" + ex.Message);
            }
        }

        ArrayList listaX = new ArrayList();
        ArrayList listaY = new ArrayList();

        private void EjecutarQuey(string query)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = query;
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataSet DS = new DataSet();
                DataTable DT = new DataTable();
                DS.Reset();
                sqlite_dt.Fill(DS);
                DT = DS.Tables[0];
                dataGridView.DataSource = DT;
                sqlite_conn.Close();
                if (dataGridView.Rows.Count > 0)
                {
                    if (cbOpcion.Text[0] == '1')
                    {
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            dataGridView.Rows[i].Cells[0].Value = Math.Pow(float.Parse(dataGridView.Rows[i].Cells[0].Value.ToString()), (1.0 / 3.0)).ToString("0.000");
                        }
                    }
                    else if (cbOpcion.Text[0] == '2')
                    {
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            int retencion = (i == 0 ? 1 : (i == 1 ? 3 : 5));
                            dataGridView.Rows[i].Cells[1].Value = (float.Parse(dataGridView.Rows[i].Cells[1].Value.ToString(), CultureInfo.InvariantCulture) * (1.0 / retencion)).ToString("0.000");
                            dataGridView.Rows[i].Cells[2].Value = (1.0 / retencion).ToString("0.000");
                        }
                    }
                    else if (cbOpcion.Text[0] == '3')
                    {
                        DateTime origen;
                        if (dtpFecha2.Enabled)
                        {
                            //origen = dtpFecha.Value.AddDays(-1);
                            origen = dtpFecha2.Value;
                        }
                        else
                        {
                            //origen = DateTime.ParseExact(dataGridView.Rows[0].Cells[0].Value.ToString(), "d/M/yyyy", CultureInfo.InvariantCulture);
                            origen = DateTime.Now;
                        }
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            DateTime mepegareuntiro = DateTime.ParseExact(dataGridView.Rows[i].Cells[0].Value.ToString(), "d-M-yyyy", CultureInfo.InvariantCulture);
                            dataGridView.Rows[i].Cells[1].Value = (mepegareuntiro - origen).Days;
                            dataGridView.Rows[i].Cells[2].Value = (float.Parse(dataGridView.Rows[i].Cells[2].Value.ToString(), CultureInfo.InvariantCulture));
                        }
                    }
                    else if (cbOpcion.Text[0] == '4')
                    {
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            dataGridView.Rows[i].Cells[1].Value = (float.Parse(dataGridView.Rows[i].Cells[1].Value.ToString(), CultureInfo.InvariantCulture));
                            dataGridView.Rows[i].Cells[2].Value = (float.Parse(dataGridView.Rows[i].Cells[2].Value.ToString(), CultureInfo.InvariantCulture));
                        }
                    }
                    else if (cbOpcion.Text[0] == '5')
                    {
                        DateTime origen;
                        if (dtpFecha2.Enabled)
                        {
                            //origen = dtpFecha.Value.AddDays(-1);
                            origen = dtpFecha2.Value;
                        }
                        else
                        {
                            //origen = DateTime.ParseExact(dataGridView.Rows[0].Cells[0].Value.ToString(), "d-M-yyyy", CultureInfo.InvariantCulture);
                            origen = DateTime.Now;
                        }
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            DateTime mepegareuntiro = DateTime.ParseExact(dataGridView.Rows[i].Cells[0].Value.ToString(), "d-M-yyyy", CultureInfo.InvariantCulture);
                            dataGridView.Rows[i].Cells[1].Value = (mepegareuntiro - origen).Days;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron muestras con información\n Consejo: Revisar que los parámetros de busqueda sean correctos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [EjecutarQuey]\n" + e.Message);
            }
        }

        private void BtnGenerarGrafica_Click(object sender, EventArgs e)
        {
            try
            {
                listaY.Clear();
                listaX.Clear();
                if (dataGridView.Rows.Count > 1)
                {
                    if (cbOpcion.Text[0] == '1' || cbOpcion.Text[0] == '2')
                    {
                        if (cbOpcion.Text[0] == '1')
                        {
                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                listaY.Add(dataGridView.Rows[i].Cells[0].Value);
                                listaX.Add(dataGridView.Rows[i].Cells[1].Value);
                            }
                        }
                        else if (cbOpcion.Text[0] == '2')
                        {
                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                listaX.Add(float.Parse(dataGridView.Rows[i].Cells[2].Value.ToString()));
                                listaY.Add(float.Parse(dataGridView.Rows[i].Cells[1].Value.ToString()));
                            }
                        }
                        ImprimirGraficas formulario = new ImprimirGraficas(int.Parse(cbOpcion.Text[0].ToString()), listaX, listaY, dtpFecha.Value);
                        formulario.ShowDialog();
                    }
                    else if (cbOpcion.Text[0] == '3')
                    {
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            listaX.Add(dataGridView.Rows[i].Cells[1].Value);
                            listaY.Add(dataGridView.Rows[i].Cells[2].Value);
                        }
                        ImprimirGraficas formulario = new ImprimirGraficas(listaX, listaY, dtpFecha.Value.ToString("dd-MM-yyyy"), dtpFecha2.Value.ToString("dd-MM-yyyy"), cbParametros.Text, LimitesMaxMin(cbParametros.Text));
                        formulario.ShowDialog();
                    }
                    else if (cbOpcion.Text[0] == '4')
                    {
                        string correl1 = string.Empty, correl2 = string.Empty;
                        switch (cbParametros.Text[0])
                        {/*
                            case '1':
                                correl1 = "Conductividad";
                                correl2 = "SST";
                                break;
                            case '2':
                                correl1 = "OD";
                                correl2 = "SSV";
                                break;
                            case '3':
                                correl1 = "OD";
                                correl2 = "Temperatura";
                                break;
                            case '4':
                                correl1 = "Turbiedad";
                                correl2 = "OD";
                                break;
                            case '5':
                                correl1 = "Turbiedad";
                                correl2 = "SST";
                                break;
                            case '6':
                                correl1 = "PH";
                                correl2 = "DBO";
                                break;
                            case '7':
                                correl1 = "DBO";
                                correl2 = "OD";
                                break;*/
                            case '1':
                                correl1 = "DBO";
                                correl2 = "OD";
                                break;
                            case '2':
                                correl1 = "OD";
                                correl2 = "SSV";
                                break;
                            default: break;
                        }
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            listaX.Add(float.Parse(dataGridView.Rows[i].Cells[1].Value.ToString()));
                            listaY.Add(float.Parse(dataGridView.Rows[i].Cells[2].Value.ToString()));
                        }
                        ImprimirGraficas formulario = new ImprimirGraficas(listaX, listaY, correl1, correl2, dtpFecha.Value.ToString("dd-MM-yyyy"), dtpFecha2.Value.ToString("dd-MM-yyyy"));
                        formulario.ShowDialog();
                    }
                    else if (cbOpcion.Text[0] == '5')
                    {
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            listaX.Add(dataGridView.Rows[i].Cells[1].Value);
                            listaY.Add(dataGridView.Rows[i].Cells[2].Value);
                        }
                        ImprimirGraficas formulario = new ImprimirGraficas(listaX, listaY, dtpFecha.Value.ToString("dd-MM-yyyy"), dtpFecha2.Value.ToString("dd-MM-yyyy"), LimitesMaxMin("F/M"));
                        formulario.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficientes datos\n(Generar una tabla)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnGenerarGrafica_Click]\n" + ex.Message);
            }
        }

        private DataRow LimitesMaxMin(string param)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "Select valor_min, valor_max FROM Limites " +
                                            "WHERE '" + param + "'  like indice || '%'";

                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                sqlite_dt.Fill(DS);
                if (DS.Tables[0].Select().Length > 0)
                    return DS.Tables[0].Rows[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [LimitesMaxMin]\n" + e.Message);
            }
            return null;
        }


        private void Keyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnTabla_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbUbicacion.Enabled && string.IsNullOrWhiteSpace(cbUbicacion.Text))
                {
                    MessageBox.Show("Seleccione una ubicación");
                    return;
                }

                if (cbParametros.Enabled && string.IsNullOrWhiteSpace(cbParametros.Text))
                {
                    MessageBox.Show("Seleccione un parámetro");
                    return;
                }

                dataGridView.DataSource = null;
                switch (cbOpcion.Text[0])
                {
                    case '1':
                        EjecutarQuey("SELECT RESULTADO as '(t/y)^1/3', Dia From" +
                                    "(SELECT (SELECT 1/avg(dbo1) FROM Muestra_punto1 WHERE fecha LIKE '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "%') AS RESULTADO, 1 AS 'Dia' WHERE RESULTADO IS NOT NULL  " +
                               "UNION SELECT (SELECT 2/avg(dbo2) FROM Muestra_punto1 WHERE fecha LIKE '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "%') AS RESULTADO, 2 AS 'Dia' WHERE RESULTADO IS NOT NULL  " +
                               "UNION SELECT (SELECT 3/avg(dbo3) FROM Muestra_punto1 WHERE fecha LIKE '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "%') AS RESULTADO, 3 AS 'Dia' WHERE RESULTADO IS NOT NULL  " +
                               "UNION SELECT (SELECT 4/avg(dbo4) FROM Muestra_punto1 WHERE fecha LIKE '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "%') AS RESULTADO, 4 AS 'Dia' WHERE RESULTADO IS NOT NULL  " +
                               "UNION SELECT (SELECT 5/avg(dbo5) FROM Muestra_punto1 WHERE fecha LIKE '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "%') AS RESULTADO, 5 AS 'Dia' WHERE RESULTADO IS NOT NULL  " +
                               "UNION SELECT (SELECT 6/avg(dbo6) FROM Muestra_punto1 WHERE fecha LIKE '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "%') AS RESULTADO, 6 AS 'Dia' WHERE RESULTADO IS NOT NULL  " +
                               "UNION SELECT (SELECT 7/avg(dbo7) FROM Muestra_punto1 WHERE fecha LIKE '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "%') AS RESULTADO, 7 AS 'Dia' WHERE RESULTADO IS NOT NULL  " +
                               "GROUP BY Dia " +
                               "ORDER BY Dia)");
                        break;
                    case '2':
                        EjecutarQuey("Select fechaXdia as 'Fecha (aaaa-mm-dd)', printf('%.3f',(So-S)/SSV) AS '(So-S)/ӨX', null AS '1/Өc' FROM(" +
                                                "SELECT  a.fecha as fechaXdia, avg(MP1.dbo5) as So, avg(MP5.dbo5) as S, avg(0.8 * MP5.SST) as SSV " +
                                                       "FROM (SELECT strftime('%Y-%m-%d',fecha) as fecha " +
                                                                    "FROM Muestra_punto1 WHERE  fecha between '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "' and '" + dtpFecha.Value.AddDays(7).ToString("yyyy-MM-dd") + "' " +
                                                         "UNION SELECT strftime('%Y-%m-%d', fecha) as fecha " +
                                                                    "FROM Muestra_punto5 WHERE  fecha between '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "' and '" + dtpFecha.Value.AddDays(7).ToString("yyyy-MM-dd") + "') AS a " +
                                                "LEFT JOIN Muestra_punto1 as MP1 on strftime('%Y-%m-%d', MP1.fecha) LIKE fechaXdia " +
                                                "LEFT JOIN Muestra_punto5 as MP5 on strftime('%Y-%m-%d', MP5.fecha) LIKE fechaXdia " +
                                            "GROUP BY fechaXdia) " +
                                    "WHERE So IS NOT NULL AND S IS NOT NULL AND SSV IS NOT NULL");
                        break;
                    case '3':
                        if (dtpFecha2.Value > dtpFecha.Value || chbtodos.Checked)
                        {
                            EjecutarQuey("SELECT fechaForm as 'Fecha', 0 AS Dia, printf('%.3f',promedio) as " + cbParametros.Text + " FROM( " +
                                                "SELECT strftime('%d-%m-%Y', fecha) AS fechaForm, avg(" + cbParametros.Text + ") AS promedio FROM Muestra_punto" + cbUbicacion.Text[0] +
                                                    Check_checkBox3() +
                                                " GROUP BY fechaForm ORDER BY fecha) " +
                                         "WHERE promedio IS NOT NULL");
                        }
                        else
                        {
                            MessageBox.Show("Fecha2 debe ser mayor a Fecha1");
                        }
                        break;
                    case '4':
                        if (dtpFecha2.Value > dtpFecha.Value || chbtodos.Checked)
                        {
                            switch (cbParametros.Text[0])
                            {
                                /*case '1':
                                    CorrelacionQuerySameTabla("conductividad","sst");
                                    break;
                                case '2':
                                    EjecutarQuey("Select T1.fechaForm as Fecha, T1.Oxigeno AS 'OD (mg/l)', T2.SST as 'SSV (Kg/m3)' FROM " +
		                                                "(select fechaForm, printf('%.3f', avg(odx)) as Oxigeno  FROM( " +
                                                                      "select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto1 " + Check_checkBox3() +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto2 " + Check_checkBox3() +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto5 " + Check_checkBox3() + ") " +
                                                        "WHERE odx IS NOT NULL " +
                                                        "group by fechaForm) as T1, " +
                                                        "(select fechaForm, printf('%.3f', avg(sstx*0.8)) as SST  FROM( " +
                                                                  "select strftime('%d-%m-%Y', fecha) AS fechaForm, sst as sstx FROM Muestra_punto1 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, sst as sstx FROM Muestra_punto2 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, sst as sstx FROM Muestra_punto3 ) " +
                                                        "WHERE sstx IS NOT NULL " +
                                                        "group by fechaForm) as T2 " +
                                                    "WHERE T1.fechaForm like T2.fechaForm ");
                                    break;
                                case '3':
                                    EjecutarQuey("Select T1.fechaForm as Fecha, T1.Oxigeno AS 'OD (mg/l)', T2.Tempx as 'Temperatura (ºC)' FROM " +
                                                        "(select fechaForm, printf('%.3f', avg(odx)) as Oxigeno  FROM( " +
                                                                    "select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto1 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto2  " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto5) " +
                                                        "WHERE odx IS NOT NULL " +
                                                        "group by fechaForm) as T1, " +
                                                        "(select fechaForm, printf('%.3f', avg(tempx)) as Tempx  FROM( " +
                                                                  "select strftime('%d-%m-%Y', fecha) AS fechaForm, temperatura as tempx FROM Muestra_punto2 " +
                                                            Check_checkBox3() + ") " +
                                                        "WHERE tempx IS NOT NULL " +
                                                        "group by fechaForm) as T2 " +
                                                    "WHERE T1.fechaForm like T2.fechaForm ");
                                    break;
                                case '4':
                                    EjecutarQuey("Select T1.fechaForm as Fecha, T2.Turbx as 'Turbiedad (NTU)', T1.Oxigeno AS 'OD (mg/l)' FROM " +
                                                        "(select fechaForm, printf('%.3f', avg(odx)) as Oxigeno  FROM( " +
                                                                    "select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto1 " + Check_checkBox3() +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto2  " + Check_checkBox3() +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto5 " + Check_checkBox3() + ") " +
                                                        "WHERE odx IS NOT NULL " +
                                                        "group by fechaForm) as T1, " +
                                                        "(select fechaForm, printf('%.3f', avg(turbx)) as Turbx  FROM( " +
                                                                  "select strftime('%d-%m-%Y', fecha) AS fechaForm, turbiedad as turbx FROM Muestra_punto1 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, turbiedad as turbx FROM Muestra_punto2 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, turbiedad as turbx FROM Muestra_punto3) " +
                                                        "WHERE turbx IS NOT NULL " +
                                                        "group by fechaForm) as T2 " +
                                                    "WHERE T1.fechaForm like T2.fechaForm ");
                                    break;
                                case '5':
                                    CorrelacionQuerySameTabla("turbiedad", "sst");
                                    break;
                                case '6':
                                    EjecutarQuey("Select T1.fechaForm as Fecha, T1.Ph AS PH, T2.DBOX as 'DBO (Kg/m3)' FROM " +
                                                        "(select fechaForm, printf('%.3f', avg(phx)) as Ph  FROM( " +
                                                             "SELECT strftime('%d-%m-%Y', fecha) AS fechaForm, ph as phx FROM Muestra_punto5 " + Check_checkBox3() + ") " +
                                                        "WHERE phx IS NOT NULL " +
                                                        "group by fechaForm) as T1, " +
                                                        "(select fechaForm, printf('%.3f', avg(dbox)) as DBOX  FROM( " +
                                                                      "select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo0 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo1 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo2 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo3 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo4 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo5 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo6 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo7 as dbox FROM Muestra_punto5) " +
                                                        "WHERE dbox IS NOT NULL " +
                                                        "group by fechaForm) as T2 " +
                                                    "WHERE T1.fechaForm like T2.fechaForm ");
                                    break;
                                case '7':
                                    EjecutarQuey("Select T1.fechaForm as Fecha, T2.DBOX as 'DBO (Kg/m3)', T1.Oxigeno AS 'OD (mg/l)' FROM " +
                                                        "(select fechaForm, printf('%.3f', avg(odx)) as Oxigeno  FROM( " +
                                                               "select strftime('%d-%m-%Y', fecha) AS fechaForm, od as odx FROM Muestra_punto5 " + Check_checkBox3() + ") " +
                                                        "WHERE odx IS NOT NULL " +
                                                        "group by fechaForm) as T1, " +
                                                        "(select fechaForm, printf('%.3f', avg(dbox)) as DBOX  FROM( " +
                                                                      "select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo0 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo1 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo2 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo3 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo4 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo5 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo6 as dbox FROM Muestra_punto5 " +
                                                            "union all select strftime('%d-%m-%Y', fecha) AS fechaForm, dbo7 as dbox FROM Muestra_punto5) " +
                                                        "WHERE dbox IS NOT NULL " +
                                                        "group by fechaForm) as T2 " +
                                                    "WHERE T1.fechaForm like T2.fechaForm ");
                                    */
                                case '1':
                                    EjecutarQuey("Select fechaForm as Fecha, printf('%.3f', Val1) as DBO5, printf('%.3f', Val2) as OD FROM(" +
                                                    "select fechaForm, avg(val1) as Val1, avg(val2) as Val2 FROM(" +
                                                                "SELECT strftime('%d-%m-%Y', fecha) AS fechaForm, dbo5 AS val1, od AS val2 FROM Muestra_punto5 " + Check_checkBox3() + ")" +
                                                    "GROUP BY fechaForm)" +
                                                "WHERE Val1 IS NOT NULL AND Val2 IS NOT NULL"
                                                );
                                    break;
                                case '2':
                                    EjecutarQuey("Select fechaForm AS Fecha, printf('%.3f', Val2) as OD, printf('%.3f', 0.8*Val1) as SSV FROM(" +
                                                    "select fechaForm, avg(val1) as Val1, avg(val2) as Val2 FROM(" +
                                                                "SELECT strftime('%d-%m-%Y', fecha) AS fechaForm, sst AS val1, od AS val2 FROM Muestra_punto5 " + Check_checkBox3() + ")" +
                                                    "GROUP BY fechaForm)" +
                                                "WHERE Val1 IS NOT NULL AND Val2 IS NOT NULL"
                                                );
                                    break;
                                default: break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fecha2 debe ser mayor a Fecha1");
                        }
                        break;
                    case '5':
                        if (dtpFecha2.Value > dtpFecha.Value || chbtodos.Checked)
                        {
                            EjecutarQuey("SELECT T1.fechaForm AS 'Fecha', 0 AS Dia,  printf('%.5f',((T2.Caudal*T3.DBO)/ (T1.SSV*T4.Vol))) AS 'F/M' FROM " +
                                                "(SELECT fechaForm, printf('%.3f',promSST*0.8) as SSV FROM( " +
                                                       "SELECT fechaF AS fechaForm, avg(sstx) AS promSST FROM  " +
                                                       "(select strftime('%d-%m-%Y', fecha) AS fechaF, sst as sstx FROM Muestra_punto5 " +
                                                             Check_checkBox3() + ") " +
                                                           "GROUP BY fechaF ORDER BY fechaF) " +
                                                   "WHERE promSST IS NOT NULL) AS T1, " +
                                                "(select fechaForm, printf('%.3f', avg(caudalx)) as Caudal  FROM( " +
                                                          "select strftime('%d-%m-%Y', fecha) AS fechaForm, caudal as caudalx FROM Muestra_punto5 ) " +
                                                "WHERE caudalx IS NOT NULL " +
                                                "group by fechaForm) as T2, " +
                                                "(SELECT fechaForm, printf('%.3f',promDBO) as DBO FROM( " +
                                                       "SELECT fechaF AS fechaForm, avg(dbox) AS promDBO FROM  " +
                                                       "(select strftime('%d-%m-%Y', fecha) AS fechaF, dbo5 as dbox FROM Muestra_punto5) " +
                                                           "GROUP BY fechaF ORDER BY fechaF) " +
                                                   "WHERE promDBO IS NOT NULL) AS T3, " +
                                                   "(Select valor_max as Vol FROM Limites " +
                                                            "WHERE parametros like 'Volumen%') AS T4 " +
                                            "WHERE T1.fechaForm like T2.fechaForm AND " +
                                                  "T1.fechaForm like T3.fechaForm");
                        }
                        else
                        {
                            MessageBox.Show("Fecha2 debe ser mayor a Fecha1");
                        }
                        break;
                    default: break;
                }
                btnGenerarGrafica.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnTabla_Click]\n" + ex.Message);
            }
        }

        /*private void CorrelacionQuerySameTabla(string val1, string val2)
        {
            EjecutarQuey("Select fechaForm, printf('%.3f', Val1) as " + val1 + ", printf('%.3f', Val2) as " + val2 + " FROM (" +
                                "select fechaForm, avg(val1) as Val1, avg(val2) as Val2 FROM(" +
                                                    FindVariablasSameTabla(val1,val2,1) + Check_checkBox3() +
                                              "union all " + FindVariablasSameTabla(val1, val2, 2) + Check_checkBox3() +
                                              "union all " + FindVariablasSameTabla(val1, val2, 3) + Check_checkBox3() + ")" +
                                "GROUP BY fechaForm)" +
                            "WHERE Val1 IS NOT NULL AND Val2 IS NOT NULL"
            );
        }

        private string FindVariablasSameTabla(string val1, string val2, int numTabla)
        {
            return "SELECT strftime('%d-%m-%Y', fecha) AS fechaForm, " + val1 + " AS val1, " + val2 + " AS val2 FROM Muestra_punto" + numTabla + " ";
        }*/

        private string Check_checkBox3()
        {
            if (!chbtodos.Checked)
            {
                return " WHERE fecha BETWEEN '" + dtpFecha.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFecha2.Value.AddDays(1).ToString("yyyy-MM-dd") + "'";
            }
            return null;
        }

        private void CbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView.DataSource = null;
                if (cbOpcion.Text[0] == '3')
                {
                    cbParametros.Items.Clear();
                    switch (cbUbicacion.Text[0])
                    {
                        case '1':
                            cbParametros.Items.AddRange(new object[] {
                                "temperatura",
                                "ph",
                                "turbiedad",
                                "conductividad",
                                "od",
                                "caudal",
                                "dbo0",
                                "dbo1",
                                "dbo2",
                                "dbo3",
                                "dbo4",
                                "dbo5",
                                "dbo6",
                                "dbo7",
                                "coli_tot",
                                "coli_fec"});
                            break;
                        case '2':
                            cbParametros.Items.AddRange(new object[] {
                                "temperatura",
                                "turbiedad",
                                "conductividad",
                                "od",
                                "dbo5",
                                "sst"});
                            break;
                        case '3':
                            cbParametros.Items.AddRange(new object[] {
                                "od",
                                "dbo5",
                                "sst",
                                "sv"});
                            break;
                        case '4':
                            cbParametros.Items.AddRange(new object[] {
                                "caudal",
                                "xw"});
                            break;
                        case '5':
                            cbParametros.Items.AddRange(new object[] {
                                "temperatura",
                                "turbiedad",
                                "conductividad",
                                "od",
                                "caudal",
                                "dbo5",
                                "sst"});
                            break;
                        case '6':
                            cbParametros.Items.AddRange(new object[] {
                                "temperatura",
                                "ph",
                                "turbiedad",
                                "conductividad",
                                "od",
                                "dbo5",
                                "sst",
                                "coli_tot",
                                "coli_fec",
                                "cloro"});
                            break;
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [cbUbicacion_SelectedIndexChanged]\n" + ex.Message);
            }
        }

        private void Chbtodos_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            if (cbOpcion.Text[0] == '3' || cbOpcion.Text[0] == '4' || cbOpcion.Text[0] == '5')
            {
                if (chbtodos.Checked)
                {
                    dtpFecha.Enabled = false;
                    dtpFecha2.Enabled = false;
                    dtpFecha.Value = DateTime.Now;
                    dtpFecha2.Value = DateTime.Now;
                }
                else
                {
                    dtpFecha.Enabled = true;
                    dtpFecha2.Enabled = true;
                }
            }
        }

        private void CbParametros_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
        }
    }
}
