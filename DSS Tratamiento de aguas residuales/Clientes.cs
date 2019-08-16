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
    public partial class Clientes : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public Clientes()
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
                string txtQuery = "Select RIF, razon_social, direccion, telefono  from Cliente";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataSet DS = new DataSet();
                DataTable DT = new DataTable();
                DS.Reset();
                sqlite_dt.Fill(DS);
                DT = DS.Tables[0];
                dataGridView1.DataSource = DT;
                sqlite_conn.Close();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Error [ActualizarTabla]\n" + e.Message);
                btnAgregarCli.Enabled = false;
            }
        }

        private void BtnAgregarCli_Click(object sender, EventArgs e)
        {
            AgregarCliente formulario = new AgregarCliente();
            formulario.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
            formulario.ShowDialog();
        }

        private void BtnEditarCli_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarCliente formulario = new AgregarCliente(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    dataGridView1.CurrentRow.Cells[3].Value.ToString());
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