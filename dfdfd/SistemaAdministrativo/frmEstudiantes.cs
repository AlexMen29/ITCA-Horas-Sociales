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

namespace ProyectoSocial.SistemaAdministrativo
{
    public partial class frmEstudiantes : Form
    {

        ProyectoSocialContext context = new ProyectoSocialContext();

        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        public void CargarDataGrid()
        {
            var consulta = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.Encargado != "null").ToList();
            gridEstudiantes.DataSource = consulta;

            LabEstudiantes.Text=consulta.Count.ToString();



        }


    }
}
