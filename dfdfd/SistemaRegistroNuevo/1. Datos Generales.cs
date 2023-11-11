using dfdfd.bdSocial;
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

namespace HorasSociales2
{
    public partial class FrmDatosGenerales : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();

        public FrmDatosGenerales()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            tbDatosRegistro datosContenedor = new tbDatosRegistro();

            datosContenedor.nombre = txtName.Text;
            datosContenedor.carnet = txtCarnet.Text;
            datosContenedor.escuela = txtSchool.Text;
            datosContenedor.año = txtYear.Text;
            datosContenedor.carrera = txtCareer.Text;
            datosContenedor.correo = txtEmail.Text;
            datosContenedor.telefono = txtPhone.Text;
            datosContenedor.emergencia = txtEmergency.Text;
            datosContenedor.coordinador = txtSSE.Text;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtSchool.Text) || string.IsNullOrWhiteSpace(txtYear.Text) || string.IsNullOrWhiteSpace(txtCarnet.Text) || string.IsNullOrWhiteSpace(txtCareer.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtEmergency.Text) || string.IsNullOrWhiteSpace(txtSSE.Text))
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

    }
    public static class datosContenedor
    {
        public static string nombre { get; set; }

        public static string carnet { get; set; } 

        public static string escuela { get; set; } 

        public static string año { get; set; }

        public static string carrera { get; set; }  

        public static string correo { get; set; }  

        public static string telefono { get; set; }  

        public static string emergencia { get; set; }  

        public static string coordinador { get; set; }  

        public static string institucion { get; set; }  

        public static string telefonoInstitucion { get; set; }  

        public static string actividades { get; set; }  

        public static string responsable { get; set; }  

        public static string correoResponsable { get; set; }  

        public static string telefonoResponsable { get; set; }  

        public static string tiempo { get; set; }  

        public static string fecha { get; set; }  

        public static string actividad1 { get; set; }  

        public static string objetivos1 { get; set; }  

        public static string metas1 { get; set; }  

        public static string duracion1 { get; set; }  

        public static string actividad2 { get; set; }

        public static string metas2 { get; set; }

        public static string objetivos2 { get; set; }

        public static string duracion2 { get; set; }

        public static string lunesAM { get; set; }

        public static string lunesPM { get; set; }

        public static string martesAM { get; set; }

        public static string martesPM { get; set; }

        public static string miercolesAM { get; set; }

        public static string miercolesPM { get; set; }

        public static string juevesAM { get; set; }

        public static string juevesPM { get; set; }

        public static string viernesAM { get; set; }

        public static string viernesPM { get; set; }
    }
}
