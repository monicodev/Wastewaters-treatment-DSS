using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class Muestras : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public Muestras()
        {
            InitializeComponent();
        }

        private void ActualizarTabla(string Query)
        {
            try
            {
                dataGridView1.DataSource = null;
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = Query;
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DS);
                DT = DS.Tables[0];
                dataGridView1.DataSource = DT;
                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [ActualizarTabla]\n" + e.Message);
            }
        }

        private void Borrar_Muestra(string query1, string query2)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = query2;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = query1;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                MessageBox.Show("Eliminación exitosa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [Borrar_Muestra]\n" + ex.Message);
            }
        }

        private void BtnEliminarMuestra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una muestra");
                    return;
                }
                if (MessageBox.Show("Seguro que desea borrar la muestra " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Borrar_Muestra("DELETE FROM Muestra" +
                          " WHERE ID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'",
                                   "DELETE FROM Realizar_estudio" +
                          " WHERE id_muestra = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
                    ActualizarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnEliminarMuestra_Click]\n" + ex.Message);
            }

        }

        private void CbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            try
            {
                switch (cbUbicacion.Text[0])
                {
                    case '1':
                        ActualizarTabla("select M.ID as 'ID Muestra', " +
                                                "C.razon_social as 'Cliente',  " +
                                                "p1.nombre || ' ' || p1.apellido as Captador,   " +
                                                "p2.nombre || ' ' || p2.apellido as Analista,   " +
                                                "M.id_punto || '- ' || pde.descripcion as Ubicacion,  " +
                                                "m.fecha as 'Fecha',  " +
                                                "avg(case when RE.id_parametro like 1  then RE.resultado END) as 'Temperatura (°C)', " +
                                                "avg(case when RE.id_parametro like 2  then RE.resultado END) as 'Ph (Unid de acidez)', " +
                                                "avg(case when RE.id_parametro like 3  then RE.resultado END) as 'Turbiedad (NTU)', " +
                                                "avg(case when RE.id_parametro like 4  then RE.resultado END) as 'Conductividad (µS/Cm)', " +
                                                "avg(case when RE.id_parametro like 5  then RE.resultado END) as 'Oxigeno disuelto (mg/l)', " +
                                                "avg(case when RE.id_parametro like 6  then RE.resultado END) as 'Caudal (m3/día)', " +
                                                "avg(case when RE.id_parametro like 7  then RE.resultado END) as 'DBO(0) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 8  then RE.resultado END) as 'DBO(1) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 9  then RE.resultado END) as 'DBO(2) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 10 then RE.resultado END) as 'DBO(3) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 11 then RE.resultado END) as 'DBO(4) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 12 then RE.resultado END) as 'DBO(5) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 13 then RE.resultado END) as 'DBO(6) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 14 then RE.resultado END) as 'DBO(7) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 16 then RE.resultado END) as 'Coliformes totales (NMP/100ml)', " +
                                                "avg(case when RE.id_parametro like 17 then RE.resultado END) as 'Coliformes fecales (NMP/100ml)', " +
                                                "M.descripcion as Observacion " +
                                        "from Muestra as M, Cliente as C, Personal as p1, Personal as p2, Punto_de_estudio as pde, Realizar_estudio as RE " +
                                            "where M.id_cliente like C.codigo and " +
                                                    "RE.id_muestra like M.ID and " +
                                                    "M.analista like P1.CI and  " +
                                                    "M.captador like P2.CI and  " +
                                                    "M.id_punto like pde.codigo and " +
                                                    "M.id_punto like 1 " +
                                                    FiltroBusqueda() +
                                                " group by M.ID ");
                        break;
                    case '2':
                        ActualizarTabla("select M.ID as 'ID Muestra', " +
                                                "C.razon_social as 'Cliente',  " +
                                                "p1.nombre || ' ' || p1.apellido as Captador,   " +
                                                "p2.nombre || ' ' || p2.apellido as Analista,   " +
                                                "M.id_punto || '- ' || pde.descripcion as Ubicacion,  " +
                                                "m.fecha as 'Fecha',  " +
                                                "avg(case when RE.id_parametro like 1  then RE.resultado END) as 'Temperatura (°C)', " +
                                                "avg(case when RE.id_parametro like 3  then RE.resultado END) as 'Turbiedad (NTU)', " +
                                                "avg(case when RE.id_parametro like 4  then RE.resultado END) as 'Conductividad (µS/Cm)', " +
                                                "avg(case when RE.id_parametro like 5  then RE.resultado END) as 'Oxigeno disuelto (mg/l)', " +
                                                "avg(case when RE.id_parametro like 12 then RE.resultado END) as 'DBO(5) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 15 then RE.resultado END) as 'SST (mg/l)', " +
                                                "M.descripcion as Observacion " +
                                        "from Muestra as M, Cliente as C, Personal as p1, Personal as p2, Punto_de_estudio as pde, Realizar_estudio as RE " +
                                            "where M.id_cliente like C.codigo and " +
                                                    "RE.id_muestra like M.ID and " +
                                                    "M.analista like P1.CI and  " +
                                                    "M.captador like P2.CI and  " +
                                                    "M.id_punto like pde.codigo and " +
                                                    "M.id_punto like 2 " +
                                                    FiltroBusqueda() +
                                                " group by M.ID ");
                        break;
                    case '3':
                        ActualizarTabla("select M.ID as 'ID Muestra', " +
                                                "C.razon_social as 'Cliente',  " +
                                                "p1.nombre || ' ' || p1.apellido as Captador,   " +
                                                "p2.nombre || ' ' || p2.apellido as Analista,   " +
                                                "M.id_punto || '- ' || pde.descripcion as Ubicacion,  " +
                                                "m.fecha as 'Fecha',  " +
                                                "avg(case when RE.id_parametro like 5  then RE.resultado END) as 'Oxigeno disuelto (mg/l)', " +
                                                "avg(case when RE.id_parametro like 12 then RE.resultado END) as 'DBO(5) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 15 then RE.resultado END) as 'SST (mg/l)', " +
                                                "avg(case when RE.id_parametro like 19 then RE.resultado END) as 'Solidos Volumetricos (ml/l)', " +
                                                "M.descripcion as Observacion " +
                                        "from Muestra as M, Cliente as C, Personal as p1, Personal as p2, Punto_de_estudio as pde, Realizar_estudio as RE " +
                                            "where M.id_cliente like C.codigo and " +
                                                    "RE.id_muestra like M.ID and " +
                                                    "M.analista like P1.CI and  " +
                                                    "M.captador like P2.CI and  " +
                                                    "M.id_punto like pde.codigo and " +
                                                    "M.id_punto like 3 " +
                                                    FiltroBusqueda() +
                                                " group by M.ID ");
                        break;
                    case '4':
                        ActualizarTabla("select M.ID as 'ID Muestra', " +
                                                "C.razon_social as 'Cliente',  " +
                                                "p1.nombre || ' ' || p1.apellido as Captador,   " +
                                                "p2.nombre || ' ' || p2.apellido as Analista,   " +
                                                "M.id_punto || '- ' || pde.descripcion as Ubicacion,  " +
                                                "m.fecha as 'Fecha',  " +
                                                "avg(case when RE.id_parametro like 6  then RE.resultado END) as 'Caudal (m3/día)', " +
                                                "avg(case when RE.id_parametro like 20 then RE.resultado END) as 'SSV en el fondo de lodos (mg/l)', " +
                                                "M.descripcion as Observacion " +
                                        "from Muestra as M, Cliente as C, Personal as p1, Personal as p2, Punto_de_estudio as pde, Realizar_estudio as RE " +
                                            "where M.id_cliente like C.codigo and " +
                                                    "RE.id_muestra like M.ID and " +
                                                    "M.analista like P1.CI and  " +
                                                    "M.captador like P2.CI and  " +
                                                    "M.id_punto like pde.codigo and " +
                                                    "M.id_punto like 4 " +
                                                    FiltroBusqueda() +
                                                " group by M.ID ");
                        break;
                    case '5':
                        ActualizarTabla("select M.ID as 'ID Muestra', " +
                                                "C.razon_social as 'Cliente',  " +
                                                "p1.nombre || ' ' || p1.apellido as Captador,   " +
                                                "p2.nombre || ' ' || p2.apellido as Analista,   " +
                                                "M.id_punto || '- ' || pde.descripcion as Ubicacion,  " +
                                                "m.fecha as 'Fecha',  " +
                                                "avg(case when RE.id_parametro like 1  then RE.resultado END) as 'Temperatura (°C)', " +
                                                "avg(case when RE.id_parametro like 3  then RE.resultado END) as 'Turbiedad (NTU)', " +
                                                "avg(case when RE.id_parametro like 4  then RE.resultado END) as 'Conductividad (µS/Cm)', " +
                                                "avg(case when RE.id_parametro like 5  then RE.resultado END) as 'Oxigeno disuelto (mg/l)', " +
                                                "avg(case when RE.id_parametro like 6  then RE.resultado END) as 'Caudal (m3/día)', " +
                                                "avg(case when RE.id_parametro like 12 then RE.resultado END) as 'DBO(5) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 15 then RE.resultado END) as 'SST (mg/l)', " +
                                                "M.descripcion as Observacion " +
                                        "from Muestra as M, Cliente as C, Personal as p1, Personal as p2, Punto_de_estudio as pde, Realizar_estudio as RE " +
                                            "where M.id_cliente like C.codigo and " +
                                                    "RE.id_muestra like M.ID and " +
                                                    "M.analista like P1.CI and  " +
                                                    "M.captador like P2.CI and  " +
                                                    "M.id_punto like pde.codigo and " +
                                                    "M.id_punto like 5 " +
                                                    FiltroBusqueda() +
                                                " group by M.ID ");
                        break;
                    case '6':
                        ActualizarTabla("select M.ID as 'ID Muestra', " +
                                                "C.razon_social as 'Cliente',  " +
                                                "p1.nombre || ' ' || p1.apellido as Captador,   " +
                                                "p2.nombre || ' ' || p2.apellido as Analista,   " +
                                                "M.id_punto || '- ' || pde.descripcion as Ubicacion,  " +
                                                "m.fecha as 'Fecha',  " +
                                                "avg(case when RE.id_parametro like 1  then RE.resultado END) as 'Temperatura (°C)', " +
                                                "avg(case when RE.id_parametro like 2  then RE.resultado END) as 'Ph (Unid de acidez)', " +
                                                "avg(case when RE.id_parametro like 3  then RE.resultado END) as 'Turbiedad (NTU)', " +
                                                "avg(case when RE.id_parametro like 4  then RE.resultado END) as 'Conductividad (µS/Cm)', " +
                                                "avg(case when RE.id_parametro like 5  then RE.resultado END) as 'Oxigeno disuelto (mg/l)', " +
                                                "avg(case when RE.id_parametro like 12 then RE.resultado END) as 'DBO(5) (mg/l)', " +
                                                "avg(case when RE.id_parametro like 15 then RE.resultado END) as 'SST (mg/l)', " +
                                                "avg(case when RE.id_parametro like 16 then RE.resultado END) as 'Coliformes totales (NMP/100ml)', " +
                                                "avg(case when RE.id_parametro like 17 then RE.resultado END) as 'Coliformes fecales (NMP/100ml)', " +
                                                "avg(case when RE.id_parametro like 18 then RE.resultado END) as 'Cloro residual (mg/l)', " +
                                                "M.descripcion as Observacion " +
                                        "from Muestra as M, Cliente as C, Personal as p1, Personal as p2, Punto_de_estudio as pde, Realizar_estudio as RE " +
                                            "where M.id_cliente like C.codigo and " +
                                                    "RE.id_muestra like M.ID and " +
                                                    "M.analista like P1.CI and  " +
                                                    "M.captador like P2.CI and  " +
                                                    "M.id_punto like pde.codigo and " +
                                                    "M.id_punto like 6 " +
                                                    FiltroBusqueda() +
                                                " group by M.ID ");
                        break;
                    default:
                        ActualizarTabla("select M.ID as 'ID Muestra', " +
                                            "C.razon_social as 'Cliente',  " +
                                            "p1.nombre || ' ' || p1.apellido as Captador,   " +
                                            "p2.nombre || ' ' || p2.apellido as Analista,   " +
                                            "M.id_punto || '- ' || pde.descripcion as Ubicacion,  " +
                                            "m.fecha as 'Fecha',  " +
                                            "avg(case when RE.id_parametro like 1  then RE.resultado END) as 'Temperatura (°C)', " +
                                            "avg(case when RE.id_parametro like 2  then RE.resultado END) as 'Ph (Unid de acidez)', " +
                                            "avg(case when RE.id_parametro like 3  then RE.resultado END) as 'Turbiedad (NTU)', " +
                                            "avg(case when RE.id_parametro like 4  then RE.resultado END) as 'Conductividad (µS/Cm)', " +
                                            "avg(case when RE.id_parametro like 5  then RE.resultado END) as 'Oxigeno disuelto (mg/l)', " +
                                            "avg(case when RE.id_parametro like 6  then RE.resultado END) as 'Caudal (m3/día)', " +
                                            "avg(case when RE.id_parametro like 7  then RE.resultado END) as 'DBO(0) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 8  then RE.resultado END) as 'DBO(1) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 9  then RE.resultado END) as 'DBO(2) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 10 then RE.resultado END) as 'DBO(3) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 11 then RE.resultado END) as 'DBO(4) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 12 then RE.resultado END) as 'DBO(5) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 13 then RE.resultado END) as 'DBO(6) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 14 then RE.resultado END) as 'DBO(7) (mg/l)', " +
                                            "avg(case when RE.id_parametro like 15 then RE.resultado END) as 'SST (mg/l)', " +
                                            "avg(case when RE.id_parametro like 16 then RE.resultado END) as 'Coliformes totales (NMP/100ml)', " +
                                            "avg(case when RE.id_parametro like 17 then RE.resultado END) as 'Coliformes fecales (NMP/100ml)', " +
                                            "avg(case when RE.id_parametro like 18 then RE.resultado END) as 'Cloro residual (mg/l)', " +
                                            "avg(case when RE.id_parametro like 19 then RE.resultado END) as 'Solidos Volumetricos (ml/l)', " +
                                            "avg(case when RE.id_parametro like 20 then RE.resultado END) as 'SSV en el fondo de lodos (mg/l)', " +
                                            "M.descripcion as Observacion " +
                                    "from Muestra as M, Cliente as C, Personal as p1, Personal as p2, Punto_de_estudio as pde, Realizar_estudio as RE " +
                                        "where M.id_cliente like C.codigo and " +
                                                "RE.id_muestra like M.ID and " +
                                                "M.analista like P1.CI and  " +
                                                "M.captador like P2.CI and  " +
                                                "M.id_punto like pde.codigo " +
                                                 FiltroBusqueda() +
                                            " group by M.ID ");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [ActualizarTabla]\n" + ex.Message);
            }
        }

        private void BtnBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private string FiltroBusqueda()
        {
            if (!string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                return " AND (" +
                    "M.ID LIKE '%" + tbBuscar.Text + "%' OR " +
                    "C.razon_social LIKE '%" + tbBuscar.Text + "%' OR " +
                    "p1.nombre || ' ' || p1.apellido LIKE '%" + tbBuscar.Text + "%' OR " +
                    "p2.nombre || ' ' || p2.apellido LIKE '%" + tbBuscar.Text + "%' OR " +
                    "M.fecha LIKE '%" + tbBuscar.Text + "%' " +
                    ") ";
            }
            return null;
        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnActualizarMuestra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una muestra");
                    return;
                }
                switch (cbUbicacion.Text[0])
                {
                    case '1':
                        AgregarMuestras formulario1 = new AgregarMuestras(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[11].Value.ToString(), dataGridView1.CurrentRow.Cells[12].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[13].Value.ToString(), dataGridView1.CurrentRow.Cells[14].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[15].Value.ToString(), dataGridView1.CurrentRow.Cells[16].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[17].Value.ToString(), dataGridView1.CurrentRow.Cells[18].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[19].Value.ToString(), dataGridView1.CurrentRow.Cells[20].Value.ToString(),
                     dataGridView1.CurrentRow.Cells[21].Value.ToString(), dataGridView1.CurrentRow.Cells[22].Value.ToString());
                        formulario1.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario1.ShowDialog();
                        break;
                    case '2':
                        AgregarMuestras formulario2 = new AgregarMuestras(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[11].Value.ToString(), dataGridView1.CurrentRow.Cells[12].Value.ToString());
                        formulario2.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario2.ShowDialog();
                        break;
                    case '3':
                        AgregarMuestras formulario3 = new AgregarMuestras(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString());
                        formulario3.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario3.ShowDialog();
                        break;
                    case '4':
                        AgregarMuestras formulario4 = new AgregarMuestras(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString());
                        formulario4.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario4.ShowDialog();
                        break;
                    case '5':
                        AgregarMuestras formulario5 = new AgregarMuestras(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[11].Value.ToString(), dataGridView1.CurrentRow.Cells[12].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[13].Value.ToString());
                        formulario5.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario5.ShowDialog();
                        break;
                    case '6':
                        AgregarMuestras formulario6 = new AgregarMuestras(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[11].Value.ToString(), dataGridView1.CurrentRow.Cells[12].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[13].Value.ToString(), dataGridView1.CurrentRow.Cells[14].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[15].Value.ToString(), dataGridView1.CurrentRow.Cells[16].Value.ToString());
                        formulario6.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario6.ShowDialog();
                        break;
                    default: MessageBox.Show("HACER EL CODIGO D:<"); break;
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnActualizarMuestra_Click]\n" + ex.Message);
            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarTabla();
        }

        private void BtnAgregarMuestra_Click(object sender, EventArgs e)
        {
            AgregarMuestras formulario = new AgregarMuestras();
            formulario.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
            formulario.ShowDialog();
        }

        private DataSet Limites(string Query)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = Query;
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataSet DS = new DataSet();
                DS.Reset();
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DS);
                return DS;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [Limites]\n" + e.Message);
            }
            return null;
        }

        private void InsertExcel(Excel.Worksheet x, string parametro, string ubiParametro, string minimo, string maximo, string ubiLimites)
        {
            if (!String.IsNullOrWhiteSpace(parametro))
            {
                x.Range[ubiParametro].Value = parametro;
                if (!string.IsNullOrWhiteSpace(minimo))
                {
                    x.Range[ubiLimites].Value = minimo + " a " + maximo;
                }
                else
                {
                    x.Range[ubiLimites].Value = maximo;
                }
            }
        }

        private void ReporteUbicacion(string id, string razonSocial, string analista, string fecha, string temperatura,
            string ph, string turbiedad, string conductividad, string od, string dbo, string sst, string tot, string fec,
            string cloro, string observacion)
        {
            try
            {
                string fileTest = "C:\\DSS Tratamiento de aguas residuales\\PLANILLA DE RESULTADOS DE AGUAS RESIDUALES.xlsx";

                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                Excel.Workbook book = excel.Workbooks.Add(fileTest);
                Excel.Worksheet x = excel.ActiveSheet as Excel.Worksheet;

                x.Range["G6"].Value = DateTime.Now.Date.ToString("dd-MM-yyyy");
                x.Range["B9"].Value = id;
                x.Range["B10"].Value = DateTime.Parse(fecha);
                x.Range["B11"].Value = (DateTime.Parse(fecha)).ToString("HH:mm");
                x.Range["F9"].Value = "Planta de tratamiento " + razonSocial;
                x.Range["F10"].Value = "Salida del vertedero de la planta de tratamiento";
                x.Range["F11"].Value = observacion;

                DataSet DS = Limites("Select parametro, val_min, val_max FROM Parametro " +
                                        "WHERE parametro like 'Temperatura%' OR " +
                                              "parametro like 'Ph%' OR " +
                                              "parametro like 'Turbiedad%' OR " +
                                              "parametro like 'Conductividad%' OR " +
                                              "parametro like 'Oxigeno%' OR " +
                                              "parametro like 'Demanda bioquimica de oxigeno (DBO5,20)%' OR " +
                                              "parametro like 'Solidos suspendidos %' OR " +
                                              "parametro like 'Coliformes tot%' OR " +
                                              "parametro like 'Coliformes fec%' OR " +
                                              "parametro like 'Cloro%'"
                                    );

                InsertExcel(x, temperatura, "B15", DS.Tables[0].Rows[0]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[0]["val_max"].ToString(), "E15");
                InsertExcel(x, ph, "B17", DS.Tables[0].Rows[1]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[1]["val_max"].ToString(), "E17");
                InsertExcel(x, turbiedad, "B18", DS.Tables[0].Rows[2]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[2]["val_max"].ToString(), "E18");
                InsertExcel(x, conductividad, "B19", DS.Tables[0].Rows[3]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[3]["val_max"].ToString(), "E19");
                InsertExcel(x, od, "B25", DS.Tables[0].Rows[4]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[4]["val_max"].ToString(), "E25");
                InsertExcel(x, dbo, "B26", DS.Tables[0].Rows[5]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[5]["val_max"].ToString(), "E26");
                InsertExcel(x, sst, "B24", DS.Tables[0].Rows[5]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[5]["val_max"].ToString(), "E24");
                InsertExcel(x, tot, "B36", DS.Tables[0].Rows[6]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[6]["val_max"].ToString(), "E36");
                InsertExcel(x, fec, "B37", DS.Tables[0].Rows[7]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[7]["val_max"].ToString(), "E37");
                InsertExcel(x, cloro, "B29", DS.Tables[0].Rows[9]["val_min"].ToString(),
                                                    DS.Tables[0].Rows[9]["val_max"].ToString(), "E29");

                x.Range["A40"].Value = analista;
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reportes Sistema Tratamiento de aguas residuales"));
                book.SaveAs(".\\Reportes Sistema Tratamiento de aguas residuales\\Reporte muestra " + id + ".xlsx");
                book = excel.Workbooks.Open(fileTest);
                book.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [ReporteUbicacion]\n" + e.Message);
            }
        }

        private void BtnExportarExc_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una muestra");
                    return;
                }
                if (!string.IsNullOrWhiteSpace(cbUbicacion.Text))
                {
                    switch (cbUbicacion.Text[0])
                    {
                        case '1':
                            ReporteUbicacion(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[17].Value.ToString(), null, dataGridView1.CurrentRow.Cells[20].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[21].Value.ToString(), null,  dataGridView1.CurrentRow.Cells[22].Value.ToString());
                            break;

                        case '2':
                            ReporteUbicacion(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), null,
                        dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[11].Value.ToString(), null, null, null, dataGridView1.CurrentRow.Cells[12].Value.ToString());
                            break;

                        case '3':
                            ReporteUbicacion(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[5].Value.ToString(), null, null, null, null, dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                        null, null, null, dataGridView1.CurrentRow.Cells[10].Value.ToString());
                            break;

                        case '4':
                            ReporteUbicacion(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[5].Value.ToString(), null, null, null, null, null, null, null, null, null, null,
                        dataGridView1.CurrentRow.Cells[8].Value.ToString());
                            break;

                        case '5':
                            ReporteUbicacion(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), null,
                        dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[11].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[12].Value.ToString(), null, null, null,
                        dataGridView1.CurrentRow.Cells[13].Value.ToString());
                            break;

                        case '6':
                            ReporteUbicacion(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[11].Value.ToString(), dataGridView1.CurrentRow.Cells[12].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[13].Value.ToString(), dataGridView1.CurrentRow.Cells[14].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[15].Value.ToString(), dataGridView1.CurrentRow.Cells[16].Value.ToString());
                            break;

                        default:
                                ReporteUbicacion(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                       dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                       dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                       dataGridView1.CurrentRow.Cells[7].Value.ToString(), dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                       dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                       dataGridView1.CurrentRow.Cells[17].Value.ToString(), dataGridView1.CurrentRow.Cells[20].Value.ToString(),
                       dataGridView1.CurrentRow.Cells[21].Value.ToString(), dataGridView1.CurrentRow.Cells[22].Value.ToString(),
                       dataGridView1.CurrentRow.Cells[23].Value.ToString(), dataGridView1.CurrentRow.Cells[26].Value.ToString());
                           break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnExportarExc_Click]\n" + ex.Message);
            }
        }
    }
}
