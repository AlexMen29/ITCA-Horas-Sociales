using dfdfd.bdSocial;
using Login;
using ProyectoSocial.Otros;
using ProyectoSocial.SistemaAdministrativo;
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
        ProyectoSocialContext context =new ProyectoSocialContext();
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

            if (compartir.Nivelusuario == 1)
            {
                panelAdministrador.Visible = false;
            }
            else
            {
                var consulta =context.DatosAlumnos.Where(o=>o.Grupo==compartir.usuario.Grupo && o.NivelUsuario==1).Count();
                if (consulta < 1)
                {
                    MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nActualmente, no tienes estudiantes asignados a tu grupo, por lo que las funcionalidades del sistema se encuentran inactivas." +
                        $" Para aprovechar al máximo las características del sistema, asigna estudiantes a tu grupo: {compartir.usuario.Grupo}. ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            

        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta = MessageBox.Show("¿Desea salir del Sistema?", "Horas Sociales", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void eventosEnterLeave(Button btn, Color ColorFondo, Color ColorLetra)
        {
            btn.BackColor = ColorFondo;
            btn.ForeColor = ColorLetra;
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnInicio, ColorTranslator.FromHtml("#cd9013"), Color.White);

        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnInicio, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void btnDetalles_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnDetalles, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }
        private void btnDetalles_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnDetalles, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }
        private void btnEliModi_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnEliModi, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }
        private void btnEliModi_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnEliModi, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }
        private void btnEnviarMensaje_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnEnviarMensaje, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }
        private void btnEnviarMensaje_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnEnviarMensaje, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }
        private void btnHojaSocial_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnHojaSocial, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }
        private void btnHojaSocial_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnHojaSocial, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            frmInicio Frm = new frmInicio();
            Close();
            Frm.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"eres{compartir.usuario.Apellidos}");
            //MessageBox.Show($"{usuarioActual.Carnet}\n--------------------\n{usuarioActual.Nombres}\n{usuarioActual.Apellidos}\n{usuarioActual.Correo}","Detalles de Sesión");
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiantes us = new frmEstudiantes();
            AbrirForm(us);
        }

        private void btnEstudiantes_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnEstudiantes, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnEstudiantes_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnEstudiantes, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void btnCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnCerrarSesion, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnCerrarSesion, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnSalir, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnSalir, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form formPerfil = Application.OpenForms["frmPerfil"];

            if (formPerfil != null)
            {
                formPerfil.Close();
            }
            else
            {
                frmPerfil frm = new frmPerfil();
                frm.TopLevel = false;
                pnlContenedor.Controls.Add(frm);
                frm.Dock = DockStyle.Right;

                frm.Show();
            }
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            frmCalendario us = new frmCalendario();
            AbrirForm(us);
        }

        private void PictureCalendario_Click(object sender, EventArgs e)
        {
            Form frmCalendario = Application.OpenForms["frmCalendarioVentana"];

            if (frmCalendario != null)
            {
                frmCalendario.Close();
            }
            else
            {
                frmCalendarioVentana frm = new frmCalendarioVentana();
                frm.TopLevel = false;
                pnlContenedor.Controls.Add(frm);
                frm.Dock = DockStyle.Right;
                frm.Show();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

      
    }

}
