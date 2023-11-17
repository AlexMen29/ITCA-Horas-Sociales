using dfdfd.bdSocial;
using ProyectoSocial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class RegistroDocente : Form
    {

        ProyectoSocialContext context = new ProyectoSocialContext();

        public RegistroDocente()
        {
            InitializeComponent();
        }

        private void btnRegresar_MouseEnter(object sender, EventArgs e)
        {
            this.btnRegresar.BackColor = ColorTranslator.FromHtml("#cd9013");
            this.btnRegresar.ForeColor = Color.White;

        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            this.btnRegresar.BackColor = ColorTranslator.FromHtml("#b1201f");
            this.btnRegresar.ForeColor = Color.White;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            EstudianteOrDocente frm = new EstudianteOrDocente();
            Close();
            frm.Show();
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            this.btnRegistrar.BackColor = ColorTranslator.FromHtml("#cd9013");
            this.btnRegistrar.ForeColor = Color.White;

        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            this.btnRegistrar.BackColor = ColorTranslator.FromHtml("#b1201f");
            this.btnRegistrar.ForeColor = Color.White;

        }

        private void RegistroDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosAlumno datos = new DatosAlumno();

            datos.Carnet = txtCarnet.Text;
            datos.Contraseña = txtContraseña.Text;
            datos.NivelUsuario = 2;
            datos.Nombres = txtNombres.Text;
            datos.Apellidos = txtApellidos.Text;
            datos.Encargado = "null";
            datos.TipoEstudio = "null";
            datos.Correo = txtCorreo.Text;
            datos.Grupo = txtGrupo.Text;
            datos.Estado = "N/A";

            if (string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtGrupo.Text))
            {
                MessageBox.Show("Por favor, Completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                context.Add(datos);
                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("Se ha Registrado Exitosamente", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                else
                {
                    MessageBox.Show("Error inesperado, no se ha podido registrar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }
    }


}
