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
    public partial class frmEliminarModificar : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public frmEliminarModificar()
        {
            InitializeComponent();
        }

        private void frmEliminarModificar_Load(object sender, EventArgs e)
        {
            cargarExAlumnos();
            cargarAlumnos();
        }


        private void cargarExAlumnos()
        {
            gridExAlumnos.DataSource = context.DatosAlumnos.Where(o => o.Estado == "Terminado" && o.Grupo == compartir.usuario.Grupo).ToList();
            gridExAlumnos.Columns[1].Visible = false;
            gridExAlumnos.Columns[2].Visible = false;
        }

        private void cargarAlumnos()
        {
            gridAlumnos.DataSource = context.DatosAlumnos.Where(o => o.NivelUsuario == 1 && o.Grupo == compartir.usuario.Grupo && o.Estado == "En Proceso").ToList();
            gridAlumnos.Columns[1].Visible = false;
            gridAlumnos.Columns[2].Visible = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboFiltra.Text == "MaxHoras")
            {
                gridAlumnos.DataSource = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.Estado == "En proceso").OrderByDescending(o => o.HorasTotal).ToList();


            }
            else if (comboFiltra.Text == "MinHoras")
            {
                gridAlumnos.DataSource = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.Estado == "En proceso").OrderBy(o => o.HorasTotal).ToList();

            }

        }

        private void gridAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = gridAlumnos.SelectedCells[0].Value.ToString();
        }
    }
}
