using dfdfd.bdSocial;
using Login;
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
    public partial class frmPerfil : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public frmPerfil()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            txtCarnet.Text = compartir.usuario.Carnet;
            txtNombre.Text = compartir.usuario.Nombres;
            txtApellido.Text = compartir.usuario.Apellidos;
            txtGrupo.Text = compartir.usuario.Grupo;

            var consulta = context.DatosAlumnos.FirstOrDefault(a => a.Grupo == txtGrupo.Text && a.NivelUsuario == 2);

            txtNombreE.Text = consulta.Nombres;
            txtApellidoE.Text = consulta.Apellidos;
            txtCorreo.Text = consulta.Correo;
        }
    }
}
