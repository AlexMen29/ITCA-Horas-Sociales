using dfdfd.bdSocial;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class FrmDetallesAd : Form
    {

        ProyectoSocialContext context = new ProyectoSocialContext();
        public FrmDetallesAd()
        {
            InitializeComponent();
        }

        private void CargarDatosEnDataGridViem()
        {
            int nivel = compartir.Nivelusuario;
            if (nivel == 1)
            {

                //metodo que devuelve el carnet actual (es decir el alumno)
                string carnet = compartir.carnetIngresado;

                // Filtrar los datos por el carnet especificado
                var datosAlumno = context.horasSociales.Where(h => h.Carnet == carnet).ToList();
                gridDatosAlumnos.DataSource = datosAlumno;




                //gridDatosAlumnos.Columns[1].Visible = false;
                //gridDatosAlumnos.Columns[2].Visible = false;
            }
            else
            {
                gridDatosAlumnos.DataSource = context.horasSociales.ToList();

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gridDatosAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDetallesAd_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridViem();
        }
    }
}
