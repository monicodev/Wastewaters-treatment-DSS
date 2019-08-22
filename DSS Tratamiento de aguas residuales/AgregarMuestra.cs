using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class AgregarMuestras : Form
    {
        public AgregarMuestras()
        {
            InitializeComponent();
            dtpFecha.Text = DateTime.Now.ToString();
            InsertarPersonalCB();
            InsertarClienteCB();
        }

        /*Muestras 1*/
        public AgregarMuestras(string ID, string cliente, string Captador, string Analista, string Ubicacion, string Fecha,
            string temperaturaIn, string phIn, string turbiedadIn, string conductividadIn, string odIn, string caudalIn,
            string dbo0In, string dbo1In, string dbo2In, string dbo3In, string dbo4In, string dbo5In, string dbo6In,
            string dbo7In, string coli_totIn, string coli_fecIn, string observacion)
        {
            InitializeComponent();
            InsertarPersonalCB();
            InsertarClienteCB();

            textID.Text = ID;
            textID.Enabled = false;
            cbCliente.Text = cliente;
            cbCliente.Enabled = false;
            cbAnalista.Text = Analista;
            cbCaptador.Text = Captador;
            dtpFecha.Value = DateTime.Parse(Fecha);
            dtpFecha.Enabled = false;
            cbHora.Text = (DateTime.Parse(Fecha)).ToString("HH:mm");
            cbHora.Enabled = false;
            cbUbicacion.Text = Ubicacion;
            cbUbicacion.Enabled = false;
            tbObservacion.Text = observacion;

            temperatura = temperaturaIn;
            ph = phIn;
            conductividad = conductividadIn;
            turbiedad = turbiedadIn;
            od = odIn;
            caudal = caudalIn;
            dbo0 = dbo0In;
            dbo1 = dbo1In;
            dbo2 = dbo2In;
            dbo3 = dbo3In;
            dbo4 = dbo4In;
            dbo5 = dbo5In;
            dbo6 = dbo6In;
            dbo7 = dbo7In;
            coli_tot = coli_totIn;
            coli_fec = coli_fecIn;

            btnAgregarDatosM.Click -= new EventHandler(BtnAgregarDatosM_Click);
            btnAgregarDatosM.Click += new EventHandler(BtnActualizarDatosM_Click);
            btnAgregarDatosM.Text = "Actualizar";
            this.Text = "Actualizar Muestra " + ID;
            label1.Text = "Actualizar " + ID;
        }

        /*Muestras 2*/
        public AgregarMuestras(string ID, string cliente, string Captador, string Analista, string Ubicacion, string Fecha,
            string temperaturaIn, string turbiedadIn, string conductividadIn, string odIn, string dbo5In, string sstIn, string observacion)
        {
            InitializeComponent();
            InsertarPersonalCB();
            InsertarClienteCB();

            textID.Text = ID;
            textID.Enabled = false;
            cbCliente.Text = cliente;
            cbCliente.Enabled = false;
            cbAnalista.Text = Analista;
            cbCaptador.Text = Captador;
            dtpFecha.Value = DateTime.Parse(Fecha);
            dtpFecha.Enabled = false;
            cbHora.Text = (DateTime.Parse(Fecha)).ToString("HH:mm");
            cbHora.Enabled = false;
            cbUbicacion.Text = Ubicacion;
            cbUbicacion.Enabled = false;
            tbObservacion.Text = observacion;

            temperatura = temperaturaIn;
            turbiedad = turbiedadIn;
            conductividad = conductividadIn;
            od = odIn;
            dbo5 = dbo5In;
            sst = sstIn;

            btnAgregarDatosM.Click -= new EventHandler(BtnAgregarDatosM_Click);
            btnAgregarDatosM.Click += new EventHandler(BtnActualizarDatosM_Click);
            btnAgregarDatosM.Text = "Actualizar";
            this.Text = "Actualizar Muestra " + ID;
            label1.Text = "Actualizar " + ID;
        }

        /*Muestras 3*/
        public AgregarMuestras(string ID, string cliente, string Captador, string Analista, string Ubicacion, string Fecha,
            string odIn, string dbo5In, string sstIn, string svIn, string observacion)
        {
            InitializeComponent();
            InsertarPersonalCB();
            InsertarClienteCB();

            textID.Text = ID;
            textID.Enabled = false;
            cbCliente.Text = cliente;
            cbCliente.Enabled = false;
            cbAnalista.Text = Analista;
            cbCaptador.Text = Captador;
            dtpFecha.Value = DateTime.Parse(Fecha);
            dtpFecha.Enabled = false;
            cbHora.Text = (DateTime.Parse(Fecha)).ToString("HH:mm");
            cbHora.Enabled = false;
            cbUbicacion.Text = Ubicacion;
            cbUbicacion.Enabled = false;
            tbObservacion.Text = observacion;

            od = odIn;
            dbo5 = dbo5In;
            sst = sstIn;
            sv = svIn;

            btnAgregarDatosM.Click -= new EventHandler(BtnAgregarDatosM_Click);
            btnAgregarDatosM.Click += new EventHandler(BtnActualizarDatosM_Click);
            btnAgregarDatosM.Text = "Actualizar";
            this.Text = "Actualizar Muestra " + ID;
            label1.Text = "Actualizar " + ID;
        }

        /*Muestras 4*/
        public AgregarMuestras(string ID, string cliente, string Captador, string Analista, string Ubicacion, string Fecha,
            string caudalIn, string xwIn, string observacion)
        {
            InitializeComponent();
            InsertarPersonalCB();
            InsertarClienteCB();

            textID.Text = ID;
            textID.Enabled = false;
            cbCliente.Text = cliente;
            cbCliente.Enabled = false;
            cbAnalista.Text = Analista;
            cbCaptador.Text = Captador;
            dtpFecha.Value = DateTime.Parse(Fecha);
            dtpFecha.Enabled = false;
            cbHora.Text = (DateTime.Parse(Fecha)).ToString("HH:mm");
            cbHora.Enabled = false;
            cbUbicacion.Text = Ubicacion;
            cbUbicacion.Enabled = false;
            tbObservacion.Text = observacion;

            caudal = caudalIn;
            xw = xwIn;

            btnAgregarDatosM.Click -= new EventHandler(BtnAgregarDatosM_Click);
            btnAgregarDatosM.Click += new EventHandler(BtnActualizarDatosM_Click);
            btnAgregarDatosM.Text = "Actualizar";
            this.Text = "Actualizar Muestra " + ID;
            label1.Text = "Actualizar " + ID;
        }

        /*Muestras 5*/
        public AgregarMuestras(string ID, string cliente, string Captador, string Analista, string Ubicacion, string Fecha,
            string temperaturaIn, string turbiedadIn, string conductividadIn, string ODIn, string caudalIn, string dbo5In, string SSTIn, string observacion)
        {
            InitializeComponent();
            InsertarPersonalCB();
            InsertarClienteCB();

            textID.Text = ID;
            textID.Enabled = false;
            cbCliente.Text = cliente;
            cbCliente.Enabled = false;
            cbAnalista.Text = Analista;
            cbCaptador.Text = Captador;
            dtpFecha.Value = DateTime.Parse(Fecha);
            dtpFecha.Enabled = false;
            cbHora.Text = (DateTime.Parse(Fecha)).ToString("HH:mm");
            cbHora.Enabled = false;
            cbUbicacion.Text = Ubicacion;
            cbUbicacion.Enabled = false;
            tbObservacion.Text = observacion;

            temperatura = temperaturaIn;
            turbiedad = turbiedadIn;
            conductividad = conductividadIn;
            od = ODIn;
            caudal = caudalIn;
            dbo5 = dbo5In;
            sst = SSTIn;

            btnAgregarDatosM.Click -= new EventHandler(BtnAgregarDatosM_Click);
            btnAgregarDatosM.Click += new EventHandler(BtnActualizarDatosM_Click);
            btnAgregarDatosM.Text = "Actualizar";
            this.Text = "Actualizar Muestra " + ID;
            label1.Text = "Actualizar " + ID;
        }

        /*Muestras 6*/
        public AgregarMuestras(string ID, string cliente, string Captador, string Analista, string Ubicacion, string Fecha,
            string temperaturaIn, string phIn, string turbiedadIn, string conductividadIn, string odIn,
            string dbo5In, string sstIn, string coli_totIn, string coli_fecIn, string cloroIn, string observacion)
        {
            InitializeComponent();
            InsertarPersonalCB();
            InsertarClienteCB();

            textID.Text = ID;
            textID.Enabled = false;
            cbCliente.Text = cliente;
            cbCliente.Enabled = false;
            cbAnalista.Text = Analista;
            cbCaptador.Text = Captador;
            dtpFecha.Value = DateTime.Parse(Fecha);
            dtpFecha.Enabled = false;
            cbHora.Text = (DateTime.Parse(Fecha)).ToString("HH:mm");
            cbHora.Enabled = false;
            MessageBox.Show(Ubicacion);
            cbUbicacion.Text = Ubicacion;
            cbUbicacion.Enabled = false;
            tbObservacion.Text = observacion;

            temperatura = temperaturaIn;
            ph = phIn;
            turbiedad = turbiedadIn;
            conductividad = conductividadIn;
            od = odIn;
            dbo5 = dbo5In;
            sst = sstIn;
            coli_tot = coli_totIn;
            coli_fec = coli_fecIn;
            cloro = cloroIn;

            btnAgregarDatosM.Click -= new EventHandler(BtnAgregarDatosM_Click);
            btnAgregarDatosM.Click += new EventHandler(BtnActualizarDatosM_Click);
            btnAgregarDatosM.Text = "Actualizar";
            this.Text = "Actualizar Muestra " + ID;
            label1.Text = "Actualizar " + ID;
        }

        string temperatura, ph, conductividad, turbiedad, od, caudal, dbo0, dbo1, dbo2, dbo3,
            dbo4, dbo5, dbo6, dbo7, sst, coli_tot, coli_fec, cloro, sv, xw;

        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        private void EjecutarQuery(string txtQuery)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = txtQuery;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [EjecutarQuery]\n" + e.Message);
            }
        }

        private void InsertarPersonalCB()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "Select nombre || ' ' || apellido as Nombre from Personal ORDER BY Nombre";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DT);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    cbAnalista.Items.Add(DT.Rows[i]["Nombre"]);
                    cbCaptador.Items.Add(DT.Rows[i]["Nombre"]);
                }
                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [InsertarPersonalCB]\n" + e.Message);
            }
        }

        private void InsertarClienteCB()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "Select razon_social as Nombre from Cliente order by razon_social";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DT);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    cbCliente.Items.Add(DT.Rows[i]["Nombre"]);
                }
                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [InsertarPersonalCB]\n" + e.Message);
            }
        }

        private bool RevisarID()
        {
            bool flag = false;
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "Select ID from Muestra where ID LIKE '" + textID.Text + "'";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DT);
                if (DT.Rows.Count == 0)
                    flag = true;
                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [RevisarID]\n" + e.Message);
            }
            return flag;
        }

        public bool RevisarFecha()
        {
            bool flag = false;
            if (dtpFecha.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Fecha superior a la actual");
                return flag;
            }
            if (!((dtpFecha.Value.DayOfWeek == DayOfWeek.Monday) || (dtpFecha.Value.DayOfWeek == DayOfWeek.Wednesday)
                 || (dtpFecha.Value.DayOfWeek == DayOfWeek.Friday)))
            {
                MessageBox.Show("Ingrese una fecha valida (Lunes, Miercoles o Viernes)");
                return flag;
            }
            try
            {
                sqlite_conn = new SQLiteConnection("Data source=DB_DSS_Tratamiento.sqlite;");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                string txtQuery = "Select M.ID from Muestra as M, Cliente as C " +
                        " Where M.fecha LIKE '" + dtpFecha.Value.Date.ToString("yyyy-MM-dd") + " " + cbHora.Text + "' and " +
                                " M.id_punto =  C.codigo And " +
                                " C.razon_social Like '" + cbCliente.Text + "'";
                SQLiteDataAdapter sqlite_dt = new SQLiteDataAdapter(txtQuery, sqlite_conn);
                DataTable DT = new DataTable();
                sqlite_dt.Fill(DT);
                if (DT.Rows.Count == 0)
                    flag = true;
                else
                    MessageBox.Show("Fecha de toma de muestra repetido");
                sqlite_conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error [RevisarFecha]\n" + e.Message);
            }
            return flag;
        }

        public bool RevisarTextBoxs()
        {
            if (string.IsNullOrWhiteSpace(cbAnalista.Text) || string.IsNullOrWhiteSpace(cbCaptador.Text) ||
                 string.IsNullOrWhiteSpace(cbHora.Text) || string.IsNullOrWhiteSpace(cbUbicacion.Text) ||
                 string.IsNullOrWhiteSpace(textID.Text) || string.IsNullOrWhiteSpace(cbCliente.Text))
            {
                MessageBox.Show("Llenar todos los campos antes de continuar");
                return false;
            }
            if (RevisarID())
            {
                if (RevisarFecha())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("ID de muestra repetido");
                return false;
            }
        }

        private void BtnAgregarDatosM_Click(object sender, EventArgs e)
        {
            if (RevisarTextBoxs())
            {
                switch (cbUbicacion.Text[0])
                {
                    case '1':
                        AgregarDatosMuestra1 formulario1 = new AgregarDatosMuestra1(textID.Text, cbCliente.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd") + " " + cbHora.Text,
                            cbCaptador.Text, cbAnalista.Text, tbObservacion.Text);
                        formulario1.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario1.ShowDialog();
                        break;
                    case '2':
                        AgregarDatosMuestra2 formulario2 = new AgregarDatosMuestra2(textID.Text, cbCliente.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd") + " " + cbHora.Text,
                            cbCaptador.Text, cbAnalista.Text, tbObservacion.Text);
                        formulario2.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario2.ShowDialog();
                        break;
                    case '3':
                        AgregarDatosMuestra3 formulario3 = new AgregarDatosMuestra3(textID.Text, cbCliente.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd") + " " + cbHora.Text,
                            cbCaptador.Text, cbAnalista.Text, tbObservacion.Text);
                        formulario3.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario3.ShowDialog();
                        break;
                    case '4':
                        AgregarDatosMuestra4 formulario4 = new AgregarDatosMuestra4(textID.Text, cbCliente.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd") + " " + cbHora.Text,
                            cbCaptador.Text, cbAnalista.Text, tbObservacion.Text);
                        formulario4.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario4.ShowDialog();
                        break;
                    case '5':
                        AgregarDatosMuestra5 formulario5 = new AgregarDatosMuestra5(textID.Text, cbCliente.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd") + " " + cbHora.Text,
                            cbCaptador.Text, cbAnalista.Text, tbObservacion.Text);
                        formulario5.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario5.ShowDialog();
                        break;
                    case '6':
                        AgregarDatosMuestra6 formulario6 = new AgregarDatosMuestra6(textID.Text, cbCliente.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd") + " " + cbHora.Text,
                            cbCaptador.Text, cbAnalista.Text, tbObservacion.Text);
                        formulario6.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                        formulario6.ShowDialog();
                        break;
                    default: break;
                }
            }
        }

        private void BtnActualizarDatosM_Click(object sender, EventArgs e)
        {
            switch (cbUbicacion.Text[0])
            {
                case '1':
                    AgregarDatosMuestra1 formulario1 = new AgregarDatosMuestra1(textID.Text, cbCaptador.Text, cbAnalista.Text, tbObservacion.Text,
                        temperatura, ph, turbiedad, conductividad, od, caudal, dbo0, dbo1, dbo2, dbo3, dbo4, dbo5, dbo6, dbo7,
                        coli_tot, coli_fec);
                    formulario1.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                    formulario1.ShowDialog();
                    break;
                case '2':
                    AgregarDatosMuestra2 formulario2 = new AgregarDatosMuestra2(textID.Text, cbCaptador.Text, cbAnalista.Text, tbObservacion.Text,
                        temperatura, turbiedad, conductividad, od, dbo5, sst);
                    formulario2.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                    formulario2.ShowDialog();
                    break;
                case '3':
                    AgregarDatosMuestra3 formulario3 = new AgregarDatosMuestra3(textID.Text, cbCaptador.Text, cbAnalista.Text, tbObservacion.Text,
                       od, dbo5, sst, sv);
                    formulario3.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                    formulario3.ShowDialog();
                    break;
                case '4':
                    AgregarDatosMuestra4 formulario4 = new AgregarDatosMuestra4(textID.Text, cbCaptador.Text, cbAnalista.Text, tbObservacion.Text,
                        caudal, xw, 2);
                    formulario4.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                    formulario4.ShowDialog();
                    break;
                case '5':
                    AgregarDatosMuestra5 formulario5 = new AgregarDatosMuestra5(textID.Text, cbCaptador.Text, cbAnalista.Text, tbObservacion.Text,
                        temperatura, turbiedad, conductividad, od, caudal, dbo5, sst);
                    formulario5.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                    formulario5.ShowDialog();
                    break;
                case '6':
                    AgregarDatosMuestra6 formulario6 = new AgregarDatosMuestra6(textID.Text, cbCaptador.Text, cbAnalista.Text, tbObservacion.Text,
                        temperatura, ph, turbiedad, conductividad, od, dbo5, sst, coli_tot, coli_fec, cloro);
                    formulario6.FormClosed += new FormClosedEventHandler(Formulario_FormClosed);
                    formulario6.ShowDialog();
                    break;
                default: break;
            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
