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
            gridEstudiantes.CellFormatting += gridEstudiantes_CellFormatting;
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            gridEstudiantes.ClearSelection();

        }

        public void CargarDataGrid()
        {
            var consulta = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.Encargado != "null").ToList();
            gridEstudiantes.DataSource = consulta;

            gridEstudiantes.Columns[1].Visible = false;
            gridEstudiantes.Columns[2].Visible = false;

            gridEstudiantes.Columns[5].Visible = false;


            LabEstudiantes.Text = consulta.Count.ToString();



        }

        private void gridEstudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                string valorCelda = e.Value.ToString();
                // Comparar el valor de la celda y establecer el color
                if (valorCelda.Equals("Terminado", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (valorCelda.Equals("En Proceso", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;

                }

            }
        }
    }
}
