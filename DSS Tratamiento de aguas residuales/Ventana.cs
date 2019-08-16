using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DSS_Tratamiento_de_aguas_residuales
{
    public partial class ventana : Form
    {
        public ventana()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnCloseWin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinWin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void BtnCloseWin_MouseMove(object sender, MouseEventArgs e)
        {
            btnCloseWin.BackColor = Color.Silver;
        }

        private void BtnCloseWin_MouseLeave(object sender, EventArgs e)
        {
            btnCloseWin.BackColor = Color.Gainsboro;
        }

        private void BtnMinWin_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinWin.BackColor = Color.Silver;
        }

        private void BtnMinWin_MouseLeave(object sender, EventArgs e)
        {
            btnMinWin.BackColor = Color.Gainsboro;
        }

        private void BtnPressed(Button boton, Button boton2, Button boton3, Button boton4, Button boton5)
        {
            boton.BackColor = Color.FromArgb(0, 0, 100);
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 100);
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 100);
            BtnDesellected(boton2);
            BtnDesellected(boton3);
            BtnDesellected(boton4);
            BtnDesellected(boton5);
        }

        private void BtnDesellected(Button boton)
        {
            boton.BackColor = Color.Blue;
            boton.FlatAppearance.MouseDownBackColor = Color.DarkBlue;
            boton.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();
        }   

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            BtnPressed(btnPersonal, btnClientes, btnMuestras, btnGraficas, btnLimites);
            AbrirFormInPanel(new Personal());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            BtnPressed(btnClientes, btnPersonal, btnMuestras, btnGraficas, btnLimites);
            AbrirFormInPanel(new Clientes());
        }

        private void BtnMuestras_Click(object sender, EventArgs e)
        {
            BtnPressed(btnMuestras, btnPersonal, btnClientes, btnGraficas, btnLimites);
            AbrirFormInPanel(new Muestras());
        }

        private void BtnGraficas_Click(object sender, EventArgs e)
        {
            BtnPressed(btnGraficas, btnPersonal, btnClientes, btnMuestras, btnLimites);
            AbrirFormInPanel(new Graficas());
        }

        private void BtnLimites_Click(object sender, EventArgs e)
        {
            BtnPressed(btnLimites, btnPersonal, btnClientes, btnMuestras, btnGraficas);
            AbrirFormInPanel(new Limites());
        }
    }
}
