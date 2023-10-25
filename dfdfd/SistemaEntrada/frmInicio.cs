using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dfdfd.bdSocial;
using ProyectoSocial;
using SistemaAdministrativo;

namespace Login
{
    public partial class frmInicio : Form
    {

        ProyectoSocialContext context = new ProyectoSocialContext();



        public frmInicio()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Damos commo origen de datos la clase DatosAlumnos ya que reprensenta nuestra tabla en la base de datos
            dataGridView1.DataSource = context.DatosAlumnos.ToList();


        }



        private void label1_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }




        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = ColorTranslator.FromHtml("#b1201f");
            this.btnIngresar.ForeColor = Color.White;
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = ColorTranslator.FromHtml("#cd9013");
            this.btnIngresar.ForeColor = Color.White;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabRecuperarContraseña_MouseEnter(object sender, EventArgs e)
        {
            this.LabRecuperarContraseña.ForeColor = Color.Red;

        }

        private void LabRecuperarContraseña_MouseLeave(object sender, EventArgs e)
        {
            this.LabRecuperarContraseña.ForeColor = ColorTranslator.FromHtml("176; 25; 30");
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



            var carnet =txtCarnet.Text;
            var contraseña = txtPassword.Text;

            var usuario = context.DatosAlumnos
                .FirstOrDefault(u => u.Carnet == carnet && u.Contraseña == contraseña);

            if (usuario != null)
            {
                MessageBox.Show("Credenciales Correctas","Horas Sociales",MessageBoxButtons.OK,MessageBoxIcon.Information);
                // Las credenciales son válidas, abre el formulario de menú


               

                //menu.UsuarioActual = usuario;

                if (usuario.NivelUsuario == 2)
                {
                    MessageBox.Show("Usuario Nivel 2", "Horas Sociales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas","Horas Sociales",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            FrmSisAd frmMenu= new FrmSisAd();
            //Mandamos informacion de usuario a nuestro metodo ubicado en el fomulario FrmSisad 
            frmMenu.usuarioActual = usuario;
            Hide();
            frmMenu.Show();
        }



    }
}
