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
    public partial class AgregarDatosMuestra3 : Form
    {
        public AgregarDatosMuestra3(string ID, string Cliente, string Fecha, string Captador, string Analista, string Observacion)
        {
            InitializeComponent();
            id = ID;
            cliente = Cliente;
            fecha = Fecha;
            captador = Captador;
            analista = Analista;
            observacion = Observacion;
        }

        public AgregarDatosMuestra3(string ID, string Captador, string Analista, string Observacion,
            string od, string dbo5, string sst, string sv)
        {
            InitializeComponent();
            id = ID;
            captador = Captador;
            analista = Analista;
            observacion = Observacion;
            textOd.Text = od;
            textDbo5.Text = dbo5;
            textSst.Text = sst;
            textSv.Text = sv;
            btnAgregarDatosM.Text = "Actualizar";
            this.Text = "Actualizar muestra " + ID;
            btnAgregarDatosM.Click -= new EventHandler(BtnAgregarDatosM_Click);
            btnAgregarDatosM.Click += new EventHandler(BtnActualizarDatosM_Click);
            label4.Text = "Actualizar muestra " + ID;
        }

        private string id, cliente, fecha, captador, analista, observacion;
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        private void EjecutarQuery(string txtQuery)
        {
            try
            {
                sqlite_conn = new SQLiteConnection
                    ("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = txtQuery;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [EjecutarQuery]\n" + e.Message);
            }
        }

        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)) || (e.KeyChar == 46));
        }

        private string BuscarCI(String persona)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "SELECT CI  FROM Personal Where (nombre || ' ' || apellido)  like '" + persona + "'";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DT);
                sqlite_conn.Close();
                return DT.Rows[0]["CI"].ToString();
            }
            catch (SQLiteException)
            {
                throw;
            }
        }

        private string BuscarCodigoCliente(String persona)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "SELECT codigo FROM Cliente Where razon_social  like '" + persona + "'";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DT);
                sqlite_conn.Close();
                return DT.Rows[0]["codigo"].ToString();
            }
            catch (SQLiteException)
            {
                throw;
            }
        }

        private string CheckNull(string num)
        {
            if (!String.IsNullOrWhiteSpace(num))
            {
                return ("Round (" + num + ",2)");
            }
            else
            {
                return "null";
            }
        }

        private void InsertarDatosMuestra(string id, string parametro, string resultado)
        {
            EjecutarQuery("INSERT INTO Realizar_estudio (id_muestra,id_punto, id_parametro,resultado) VALUES" +
                "(" + "'" + id + "', 3, " + parametro + ", " + CheckNull(resultado) + ")");
        }

        private void BtnAgregarDatosM_Click(object sender, EventArgs e)
        {
            try
            {
                EjecutarQuery("INSERT INTO Muestra (ID,fecha,id_cliente,captador,analista,id_punto,descripcion)" +
                    "VALUES (" +
                        "'" + id + "'," +
                        "'" + fecha + "'," +
                        BuscarCodigoCliente(cliente) + "," +
                        "'" + BuscarCI(captador) + "'," +
                        "'" + BuscarCI(analista) + "'," +
                        " 3 ," +
                        "'" + observacion + "'" +
                    ")");
                InsertarDatosMuestra(id, "5", textOd.Text);
                InsertarDatosMuestra(id, "12", textDbo5.Text);
                InsertarDatosMuestra(id, "15", textSst.Text);
                InsertarDatosMuestra(id, "19", textSv.Text);

                MessageBox.Show("Operación Exitosa");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnAgregarDatosM_Click]\n" + ex.Message);
            }

        }

        private void ActualizarDatosMuestra(string id, string parametro, string resultado)
        {
            EjecutarQuery("UPDATE Realizar_estudio " +
                        "SET resultado =" + CheckNull(resultado) + "" +
                        " WHERE id_muestra like '" + id + "' AND " +
                        " id_parametro LIKE " + parametro
                    );
        }

        private void BtnActualizarDatosM_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que desea modificar los datos de la muestra " + id + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EjecutarQuery("UPDATE Muestra " +
                        "SET captador ='" + BuscarCI(captador) + "'," +
                        "analista ='" + BuscarCI(analista) + "'," +
                        "descripcion ='" + observacion + "'" +
                        " WHERE ID like '" + id + "'"
                    );
                    ActualizarDatosMuestra(id, "5", textOd.Text);
                    ActualizarDatosMuestra(id, "12", textDbo5.Text);
                    ActualizarDatosMuestra(id, "15", textSst.Text);
                    ActualizarDatosMuestra(id, "19", textSv.Text);

                    MessageBox.Show("Operación Exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [btnActualizarDatosM_Click]\n" + ex.Message);
            }
        }
    }
}
