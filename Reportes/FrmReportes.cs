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

namespace ProyectoSocial.Reportes
{
    public partial class FrmReportes : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public FrmReportes()
        {
            InitializeComponent();
            gridReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarDatosEnDataGridViem();

        }

        private void CargarTabla()
        {
            var datosAlumno = context.DatosAlumnos.Where(h => h.Grupo == compartir.usuario.Grupo).ToList();

            gridReport.DataSource = null;
            gridReport.DataSource = datosAlumno;

        }

        private void CargarDatosEnDataGridViem()
        {
            //Oculto la contraseña y el nivel de usuario.
            gridReport.DataSource = context.DatosAlumnos.ToList();
            gridReport.DataBindingComplete += (s, e) =>
            {
                gridReport.Columns[1].Visible = false; // Columna 1
                gridReport.Columns[2].Visible = false; // Columna 2
            };
            CargarTabla();
        }
        public void eventosEnterLeave(Button btn, Color ColorFondo, Color ColorLetra)
        {
            btn.BackColor = ColorFondo;
            btn.ForeColor = ColorLetra;
        }

        private void btnGenerarReporte_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnGenerarReporte, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnGenerarReporte_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnGenerarReporte, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void txtCarnetReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridReport.Columns["carnet"].Index)
            {
                // Obtiene el valor de la celda en la columna "carnet"
                object valorCelda = gridReport.Rows[e.RowIndex].Cells["carnet"].Value;

                // Verifica si el valor no es nulo
                if (valorCelda != null)
                {
                    // Establece el texto del txtCarnetReport en el valor de la celda clicada
                    txtCarnetReport.Text = valorCelda.ToString();

                    // Obtiene el valor de la celda en la columna "nombre"
                    object valorNombre = gridReport.Rows[e.RowIndex].Cells["nombres"].Value;
                    txtNombreReport.Text = valorNombre.ToString();

                    // Obtiene el valor de la celda en la columna "apellidos"
                    object valorApellidos = gridReport.Rows[e.RowIndex].Cells["apellidos"].Value;
                    txtApellidoReport.Text = valorApellidos.ToString();

                    // Obtiene el valor de la celda en la columna "correo"
                    object valorCorreo = gridReport.Rows[e.RowIndex].Cells["correo"].Value;
                    txtCorreoReport.Text = valorCorreo.ToString();

                    // Obtiene el valor de la celda en la columna "grupo"
                    object valorGrupo = gridReport.Rows[e.RowIndex].Cells["grupo"].Value;
                    txtGrupoReport.Text = valorGrupo.ToString();
                }
            }
        }

        private void gridReport_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
