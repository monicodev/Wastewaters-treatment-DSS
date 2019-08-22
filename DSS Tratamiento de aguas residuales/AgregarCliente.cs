using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class AgregarCliente : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public AgregarCliente()
        {
            InitializeComponent();
        }

        public AgregarCliente(string rif, string razon_social, string direccion, string telefono)
        {
            InitializeComponent();
            textRIF.Text = rif;
            textRIF.Enabled = false;
            textRazonSocial.Text = razon_social;
            textRazonSocial.Enabled = false;
            textDireccion.Text = direccion;
            textTelefono.Text = telefono;
            btnAgregarC.Text = "Actualizar";
            this.Text = "Actualizar datos del cliente J-" + rif;
            btnAgregarC.Click -= new EventHandler(BtnAgregarC_Click);
            btnAgregarC.Click += new EventHandler(BtnActualizarC_Click);
        }

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
                MessageBox.Show("Operación Exitosa");
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [EjecutarQuery]\n" + e.Message);
            }
        }

        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsNumber(e.KeyChar)) & (!Char.IsControl(e.KeyChar));
        }

        private void BtnAgregarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRIF.Text.Length < 8)
                {
                    MessageBox.Show("Ingresar un RIF valido");
                    return;
                }
                if (textRazonSocial.Text.Length == 0)
                {
                    MessageBox.Show("Ingresar una razon social valida");
                    return;
                }
                if (textDireccion.Text.Length == 0)
                {
                    MessageBox.Show("Ingresar una direccion valida");
                    return;
                }

                EjecutarQuery("INSERT INTO Cliente (RIF,razon_social,direccion,telefono) VALUES (" +
                        "'" + textRIF.Text + "'," +
                        "'" + textRazonSocial.Text + "'," +
                        "'" + textDireccion.Text + "'," +
                        "'" + textTelefono.Text + "'" +
                    ")");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnAgregarC_Click]\n" + ex.Message);
            }
        }

        private void BtnActualizarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRIF.Text.Length < 8)
                {
                    MessageBox.Show("Ingresar un RIF valido");
                    return;
                }
                if (textRazonSocial.Text.Length == 0)
                {
                    MessageBox.Show("Ingresar una razon social valida");
                    return;
                }
                if (textDireccion.Text.Length == 0)
                {
                    MessageBox.Show("Ingresar una direccion valida");
                    return;
                }

                EjecutarQuery("UPDATE Cliente " +
                                "SET direccion='" + textDireccion.Text + "', " +
                                "telefono='" + textTelefono.Text + "' " +
                             "WHERE RIF like '" + textRIF.Text + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnActualizarC_Click]\n" + ex.Message);
            }
        }
    }
}
