using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class Limites : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public Limites()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "SELECT parametro, " +
                "CASE WHEN (val_min is null) THEN null ELSE printf('%.2f',val_min) END AS 'Valor Mínimo', " +
                "CASE WHEN (val_max is null) THEN null ELSE printf('%.2f',val_max) END AS 'Valor Máximo' " +
                                  "FROM Parametro";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataSet DS = new DataSet();
                DataTable DT = new DataTable();
                DS.Reset();
                sqlite_dt.Fill(DS);
                DT = DS.Tables[0];
                dataGridView1.DataSource = DT;
                sqlite_conn.Close();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Seleccione un parámetro");
            }
        }

        private void BtnEditarLim_Click(object sender, EventArgs e)
        {
            try
            {
                EditarLimites formulario = new EditarLimites(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString());
                formulario.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnEditarLim_Click]\n" + ex.Message);
            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarTabla();
        }
    }
}
