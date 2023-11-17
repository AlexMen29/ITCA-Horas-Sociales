using dfdfd.bdSocial;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HorasSociales2
{
    public partial class FrmDatosGenerales : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();

        public KeyPressEventHandler ValidacionNumerica { get; private set; }

        public FrmDatosGenerales()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            datosContenedor.nombre = txtName.Text;
            datosContenedor.carnet = txtCarnet.Text;
            datosContenedor.escuela = txtSchool.Text;
            datosContenedor.año = int.Parse(txtYear.Text);
            datosContenedor.carrera = txtCareer.Text;
            datosContenedor.correo = txtEmail.Text;
            datosContenedor.telefono = int.Parse(txtPhone.Text);
            datosContenedor.telefonoEmergencia = int.Parse(txtEGPhone.Text);
            datosContenedor.emergencia = txtEmergency.Text;
            datosContenedor.coordinador = txtSSE.Text;


            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtSchool.Text) || string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtCareer.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtEmergency.Text) || string.IsNullOrEmpty(txtEGPhone.Text) || string.IsNullOrWhiteSpace(txtSSE.Text))
            {
                MessageBox.Show("Por favor, Completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmDatosInstitucion vistaMain = new FrmDatosInstitucion();
                vistaMain.Show();
                Hide();
            }
        }

        public void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

    }
    public static class datosContenedor
    {
        public static string nombre { get; set; } = null!;

        public static string carnet { get; set; } = null!;

        public static string escuela { get; set; } = null!;

        public static int año { get; set; }

        public static string carrera { get; set; } = null!;

        public static string correo { get; set; } = null!;

        public static int telefono { get; set; }

        public static string emergencia { get; set; } = null!;

        public static int telefonoEmergencia { get; set; }

        public static string coordinador { get; set; } = null!;

        public static string institucion { get; set; } = null!;

        public static int telefonoInstitucion { get; set; }

        public static string actividades { get; set; } = null!;

        public static string responsable { get; set; } = null!;

        public static string correoResponsable { get; set; } = null!;

        public static int telefonoResponsable { get; set; }

        public static int tiempo { get; set; }

        public static DateTime fecha { get; set; }

        public static string actividad1 { get; set; } = null!;

        public static string objetivos1 { get; set; } = null!;

        public static string metas1 { get; set; } = null!;

        public static string duracion1 { get; set; } = null!;

        public static string actividad2 { get; set; } = null!;

        public static string metas2 { get; set; } = null!;

        public static string objetivos2 { get; set; } = null!;

        public static string? duracion2 { get; set; }

        public static string? lunes { get; set; }

        public static string? martes { get; set; }

        public static string? miercoles { get; set; }

        public static string? jueves { get; set; }

        public static string? viernes { get; set; }

        public static string? sabado { get; set; }

        public static string? domingo { get; set; }
    }
}
