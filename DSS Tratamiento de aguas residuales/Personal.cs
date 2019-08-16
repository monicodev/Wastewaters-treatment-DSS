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
    public partial class Personal : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public Personal()
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
                string txtQuery = "Select * from Personal";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataSet DS = new DataSet();
                DataTable DT = new DataTable();
                DS.Reset();
                sqlite_dt.Fill(DS);
                DT = DS.Tables[0];
                tablaPersonal.DataSource = DT;
                sqlite_conn.Close();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Error [ActualizarTabla]\n" + e.Message);
                btnAgregarPers.Enabled = false;
                btnEditarPer.Enabled = false;
            }
        }

        private void BtnAgregarPers_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPersonal formulario = new AgregarPersonal();
                formulario.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnAgregarPers_Click]\n" + ex.Message);
            }
        }

        private void BtnEditarPer_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPersonal formulario = new AgregarPersonal(tablaPersonal.CurrentRow.Cells[0].Value.ToString(),
                    tablaPersonal.CurrentRow.Cells[1].Value.ToString(),tablaPersonal.CurrentRow.Cells[2].Value.ToString(), tablaPersonal.CurrentRow.Cells[3].Value.ToString());
                formulario.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnEditarPer_Click]\n" + ex.Message);
            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarTabla();
        }
    }
}
