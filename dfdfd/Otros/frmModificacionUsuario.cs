using dfdfd.bdSocial;
using Login;
using ProyectoSocial.bdSocial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSocial.Otros
{
    public partial class frmModificacionUsuario : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public frmModificacionUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModificacionUsuario_Load(object sender, EventArgs e)
        {
            txtContraseña.Text = compartir.usuario.Contraseña;
            txtNombres.Text = compartir.usuario.Nombres;
            txtApellidos.Text = compartir.usuario.Apellidos;
            txtCorreo.Text = compartir.usuario.Correo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta apunto de modificar sus datos. ¿Desea continuar?", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                compartir.usuario.Contraseña = txtContraseña.Text;
                compartir.usuario.Nombres = txtNombres.Text;
                compartir.usuario.Apellidos = txtApellidos.Text;
                compartir.usuario.Correo = txtCorreo.Text;


                context.DatosAlumnos.Update(compartir.usuario);


                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("Tus datos se han modificado correctamente", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error inesperado, no se ha podido modifcar sus datos", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }


            }


        }
        private void PicMostrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = false; // Mostrar contraseña
                PicMostrar.Visible = false;
                PicOcultar.Visible = true;
            }

        }

        private void PicOcultar_Click(object sender, EventArgs e)
        {
            if (!txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = true;
                PicOcultar.Visible = false;
                PicMostrar.Visible = true;
            }
        }
    }
}
