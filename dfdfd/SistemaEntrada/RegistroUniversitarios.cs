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
            datos.Correo= txtCorreo.Text;
            datos.Grupo = "RS01";

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
}
