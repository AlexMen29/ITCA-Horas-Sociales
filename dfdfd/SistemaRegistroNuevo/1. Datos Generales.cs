using dfdfd.bdSocial;
using Login;
using System.Linq;
using ProyectoSocial;
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
using Microsoft.IdentityModel.Tokens;

namespace HorasSociales2
{
    public partial class FrmDatosGenerales : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        private int formulario;
        private string carnetB;
        public FrmDatosGenerales(int a, string carnet)
        {
            formulario = a;
            carnetB = carnet;

            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (formulario == 1)
            {

                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtSchool.Text) || string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtCareer.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtEmergency.Text) || string.IsNullOrEmpty(txtEGPhone.Text) || string.IsNullOrWhiteSpace(txtSSE.Text))
                {
                    MessageBox.Show("Por favor, Completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    datosContenedor.nombre = compartir.usuario.Nombres + " " + compartir.usuario.Apellidos;
                    datosContenedor.carnet = compartir.usuario.Carnet;
                    datosContenedor.escuela = txtSchool.Text;
                    datosContenedor.año = txtYear.Text;
                    datosContenedor.carrera = txtCareer.Text;
                    datosContenedor.correo = txtEmail.Text;
                    datosContenedor.telefono = int.Parse(txtPhone.Text);
                    datosContenedor.telefonoEmergencia = int.Parse(txtEGPhone.Text);
                    datosContenedor.emergencia = txtEmergency.Text;
                    datosContenedor.coordinador = txtSSE.Text;

                    FrmDatosInstitucion vistaMain = new FrmDatosInstitucion(1, "N/A");
                    vistaMain.Show();
                    Hide();
                }
            }
            else
            {
                FrmDatosInstitucion form = new FrmDatosInstitucion(2, carnetB);
                form.Show();
                Hide();
            }

        }

        public void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

        private void txtEGPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

        private void FrmDatosGenerales_Load(object sender, EventArgs e)
        {
            if (formulario == 2)
            {
                pnlLeft.Visible = false;
                var datosUsuario = context.tbDatosRegistro.FirstOrDefault(o => o.carnet == carnetB);

                txtName.Text = datosUsuario.nombre;
                txtCarnet.Text = datosUsuario.carnet;
                txtYear.Text = datosUsuario.año;
                txtSchool.Text = datosUsuario.escuela;
                txtCareer.Text = datosUsuario.carrera;
                txtEmail.Text = datosUsuario.correo;
                txtPhone.Text = datosUsuario.telefono.ToString();
                txtEmergency.Text = datosUsuario.emergencia;
                txtEGPhone.Text = datosUsuario.telefonoEmergencia.ToString();
                txtSSE.Text = datosUsuario.coordinador;


                txtName.Enabled = false;
                txtCarnet.Enabled = false;
                txtYear.Enabled = false;
                txtSchool.Enabled = false;
                txtCareer.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                txtEmergency.Enabled = false;
                txtEGPhone.Enabled = false;
                txtSSE.Enabled = false;
            }
            else
            {
                txtName.Text = compartir.usuario.Nombres + " " + compartir.usuario.Apellidos;
                txtCarnet.Text = compartir.usuario.Carnet;
                txtEmail.Text = compartir.usuario.Correo;

                txtCarnet.Enabled = false;
            }
        }

    }
    public static class datosContenedor
    {
        public static string nombre { get; set; } = null!;

        public static string carnet { get; set; } = null!;

        public static string escuela { get; set; } = null!;

        public static string año { get; set; } = null!;

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