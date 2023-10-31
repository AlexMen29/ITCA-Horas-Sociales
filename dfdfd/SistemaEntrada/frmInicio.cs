using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;
using dfdfd.bdSocial;
using ProyectoSocial;
using SistemaAdministrativo;

namespace Login
{
    public partial class frmInicio : Form
    {

        ProyectoSocialContext context = new ProyectoSocialContext();
        //Instancia para usar metodo de cambio de letra
        MetodoUniversales metodo = new MetodoUniversales();
        public frmInicio()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            metodo.eventosEnterLeave(btnIngresar, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            //Evento creado para minimazar lineas de codigo
            metodo.eventosEnterLeave(btnIngresar, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void labRegistrarme_MouseEnter_1(object sender, EventArgs e)
        {
            this.labRegistrarme.ForeColor = Color.Red;
        }
        private void labRegistrarme_MouseLeave(object sender, EventArgs e)
        {
            this.labRegistrarme.ForeColor = ColorTranslator.FromHtml("176; 25; 30");
        }
        private void PicOcultar_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false; // Mostrar contraseña
                PicMostrar.Visible = true;
                PicOcultar.Visible = false;
            }
        }
        private void PicMostrar_Click(object sender, EventArgs e)
        {
            if (!txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = true;
                PicOcultar.Visible = true;
                PicMostrar.Visible = false;
            }
        }
        private void labRegistrarme_Click(object sender, EventArgs e)
        {
            EstudianteOrDocente frm = new EstudianteOrDocente();
            frm.Show();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            cargando();
        }
        private async void cargando()
        {
            pictCargando.Visible = true;

            // Esperar 2 segundos (2000 milisegundos)
            await Task.Delay(1000);

            pictCargando.Visible = false;

            var carnet = txtCarnet.Text;
            var contraseña = txtPassword.Text;

            var usuario = context.DatosAlumnos.FirstOrDefault(u => u.Carnet == carnet && u.Contraseña == contraseña);

            if (usuario != null)
            {
                MessageBox.Show("Credenciales Correctas", "Horas Sociales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Las credenciales son válidas, abre el formulario de menú

                //menu.UsuarioActual = usuario;
                if (usuario.NivelUsuario == 2)
                {
                    MessageBox.Show("Usuario Nivel 2", "Horas Sociales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FrmSisAd frmMenu = new FrmSisAd();
                //Mandamos informacion de usuario a nuestro metodo ubicado en el fomulario FrmSisad 
                frmMenu.usuarioActual = usuario;
                compartir.carnetIngresado = txtCarnet.Text;
                compartir.Nivelusuario = usuario.NivelUsuario;
                Hide();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Las Credenciales Ingresadas Son Incorrectas ", "ITCA FEPADE ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        class MetodoUniversales
        {
            public void eventosEnterLeave(Button btn, Color ColorFondo, Color ColorLetra)
            {
                btn.BackColor = ColorFondo;
                btn.ForeColor = ColorLetra;
            }
        }
    }

    //Necesario para poder tener acceso desde los demas formularios
    public static class compartir 
    {
        public static string carnetIngresado { get; set; }
        public static int Nivelusuario { get; set; }
    }
}
