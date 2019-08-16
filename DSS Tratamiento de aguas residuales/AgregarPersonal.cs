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
    public partial class AgregarPersonal : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public AgregarPersonal()
        {
            InitializeComponent();
        }

        public AgregarPersonal(string CI, string nombre, string apellido, string cargo)
        {
            InitializeComponent();
            textCedula.Text = CI;
            textCedula.Enabled = false;
            textNombre.Text = nombre;
            textApellido.Text = apellido;
            cbCargo.Text = cargo;
            btnAgregarP.Text = "Actualizar";
            this.Text = "Actualizar datos del Personal " + CI;
            btnAgregarP.Click -= new EventHandler(BtnAgregarP_Click);
            btnAgregarP.Click += new EventHandler(BtnActualizarP_Click);
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


        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCedula.Text.Length < 7)
                {
                    MessageBox.Show("Cedula invalida");
                    return;
                }
                if (textNombre.Text.Length < 2)
                {
                    MessageBox.Show("Nombre invalido");
                    return;
                }
                if (textApellido.Text.Length < 2)
                {
                    MessageBox.Show("Apellido invalido");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbCargo.Text))
                {
                    MessageBox.Show("Seleccione un cargo");
                    return;
                }

                EjecutarQuery("INSERT INTO Personal (CI,nombre,apellido,cargo) VALUES (" +
                        "'" + textCedula.Text + "'," +
                        "'" + textNombre.Text + "'," +
                        "'" + textApellido.Text + "'," +
                        "'" + cbCargo.Text[0] + "'" +
                    ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnAgregarP_Click]\n" + ex.Message);
            }
        }

        private void BtnActualizarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (textNombre.Text.Length < 2)
                {
                    MessageBox.Show("Nombre invalido");
                    return;
                }
                if (textApellido.Text.Length < 2)
                {
                    MessageBox.Show("Apellido invalido");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbCargo.Text))
                {
                    MessageBox.Show("Seleccione un cargo");
                    return;
                }
                EjecutarQuery("UPDATE Personal " +
                                "SET nombre='" + textNombre.Text + "', " +
                                "apellido='" + textApellido.Text + "', " +
                                "cargo='" + cbCargo.Text[0] + "' " +
                             "WHERE CI like '" + textCedula.Text + "'"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error [BtnActualizarP_Click]\n" + ex.Message);
            }
        }

        private void TextCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsNumber(e.KeyChar)) & (!Char.IsControl(e.KeyChar));
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (Char.IsNumber(e.KeyChar)) & (!Char.IsControl(e.KeyChar));
        }
    }
}
