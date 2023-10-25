using dfdfd.bdSocial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class FrmSisAd : Form
    {

        //Metodo para obtener informacion de las credenciales ingresadas en el menu de login
        public DatosAlumno usuarioActual { get; set; }
        public FrmSisAd()
        {
            InitializeComponent();
        }

        private void AbrirForm(object FrmInicio)
        {
            if (pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }

            Form fh = FrmInicio as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmDatosInicio us = new FrmDatosInicio();
            AbrirForm(us);



        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FrmDetallesAd us = new FrmDetallesAd();
            AbrirForm(us);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarDetallesAlum us = new EliminarDetallesAlum();
            AbrirForm(us);

        }

        private void btnHojaSocial_Click(object sender, EventArgs e)
        {
            ImpresionDatos us = new ImpresionDatos();
            AbrirForm(us);

        }

        private void FrmSisAd_Load(object sender, EventArgs e)
        {
            LabNombre.Text = usuarioActual.Nombres + " " + usuarioActual.Apellidos;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            DialogResult Respuesta = MessageBox.Show("¿Desea salir del Sistema?", "Horas Sociales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnNotificacion_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es una version beta de como mostrar los mensajes, posiblemnete lo dejemos asi pero con clik, sin mas que decir chambean por favor");
        }
    }
}
