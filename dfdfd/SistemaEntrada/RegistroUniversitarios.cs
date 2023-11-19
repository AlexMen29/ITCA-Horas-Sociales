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
using HorasSociales2;
using ProyectoSocial;

namespace Login
{
    public partial class RegistroUniversitarios : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();


        public RegistroUniversitarios()
        {
            InitializeComponent();
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

        private void btnRegresar_MouseEnter(object sender, EventArgs e)
        {
            this.btnRegresar.BackColor = ColorTranslator.FromHtml("#cd9013");
            this.btnRegresar.ForeColor = Color.White;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = ColorTranslator.FromHtml("#b1201f");
            btnRegresar.ForeColor = Color.White;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            EstudianteOrDocente frm = new EstudianteOrDocente();
            Close();
            frm.Show();
        }

        private void RegistroUniversitarios_Load(object sender, EventArgs e)
        {
            //Obtenemos el nombre de los encargados para mostarlos como selecionables al momento del registo
            var option = context.DatosAlumnos.Where(o => o.NivelUsuario == 2).Select(o => o.Nombres).ToList();

            foreach (var elementos in option)
            {
                txtEncargado.Items.Add(elementos);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DatosAlumno datos = new DatosAlumno();

            datos.Carnet = txtCarnet.Text;
            datos.Contraseña = txtContraseña.Text;
            datos.NivelUsuario = 1;
            datos.Nombres = txtNombres.Text;
            datos.Apellidos = txtApellidos.Text;
            datos.Encargado = txtEncargado.Text;
            datos.TipoEstudio = txtTipoEstudio.Text;
            datos.Correo = txtCorreo.Text;
            var docente = context.DatosAlumnos.FirstOrDefault(u => u.Nombres == txtEncargado.Text);
            datos.Estado = "En Proceso";



            if (string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtEncargado.Text) || string.IsNullOrWhiteSpace(txtTipoEstudio.Text))
            {
                MessageBox.Show("Por favor, Completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                datos.Grupo = docente.Grupo;

                context.Add(datos);
                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("Registro guardado", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var Usuario = context.DatosAlumnos.FirstOrDefault(o => o.Carnet == txtCarnet.Text);
                    compartir.usuario=Usuario;
                    FrmDatosGenerales frm = new FrmDatosGenerales(1, "N/A");
                    frm.Show();
                    Hide();
                    Close();
                }

                else
                {
                    MessageBox.Show("Error inesperado, no se ha podido registrar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
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
