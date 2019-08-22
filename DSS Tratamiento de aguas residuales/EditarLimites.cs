using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;


namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class EditarLimites : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public EditarLimites(string param, string valorMin, string valorMax)
        {
            InitializeComponent();
            textParam.Text = param;
            textValMin.Text = valorMin;
            textValMax.Text = valorMax;
        }

        private string CheckNull(string num)
        {
            if (!String.IsNullOrWhiteSpace(num))
            {
                return ("Round (" + num + ",2)");
            }
            else
            {
                return "null ";
            }
        }

        private void BtnEditarL_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textValMin.Text))
                {
                    if (string.IsNullOrWhiteSpace(textValMax.Text))
                    {
                        MessageBox.Show("Valor máximo no puede ser nulo");
                        return;
                    }
                    if (float.Parse(textValMax.Text, CultureInfo.InvariantCulture) < float.Parse(textValMin.Text, CultureInfo.InvariantCulture))
                    {
                        MessageBox.Show("Valor Mínimo no puede ser mayor a Valor Máximo");
                        return;
                    }
                }
                string query = "UPDATE Parametro SET " +
                                    "val_min = " + CheckNull(textValMin.Text) + "," +
                                    "val_max = " + CheckNull(textValMax.Text) +
                                "Where parametro ='" + textParam.Text + "'";
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = query;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
                MessageBox.Show("Actualización exitosa");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnEditarL_Click]\n" + ex.Message);
            }
        }

        private void TextValMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)) || (e.KeyChar == 46));
        }
    }
}
