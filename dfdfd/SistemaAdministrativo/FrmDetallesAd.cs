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

        private void CargarDatosEnDataGridViem(int nivel, string carnet)
        {
            if (nivel == 1)
            {

                // Filtrar los datos por el carnet especificado
                var datosAlumno = context.horasSociales.Where(h => h.Carnet == carnet).ToList();
                gridDatosAlumnos.DataSource = datosAlumno;


                if (compartir.Nivelusuario == 1)
                {
                    gridDatosAlumnos.Columns[0].Visible = false;
                    gridDatosAlumnos.Columns[1].Visible = false;
                }
                totalHoras();
            }
            else
            {
                var datosAlumno = context.horasSociales.Where(h => h.Grupo == compartir.usuario.Grupo).ToList();

                gridDatosAlumnos.DataSource = datosAlumno;

            }

        }

        private void FrmDetallesAd_Load(object sender, EventArgs e)
        {

            gridDatosAlumnos.DataSource = context.DatosAlumnos.ToList();


            CargarDatosEnDataGridViem(compartir.Nivelusuario, compartir.carnetIngresado);


            if (compartir.Nivelusuario == 1)
            {
                PanelElementosBusqueda.Visible = false;
                panelDetallesAlumnos.Visible = false;
                if (compartir.usuario.TipoEstudio == "Técnico")
                {
                    int horasRestantes = 300 - int.Parse(LabTotalHoras.Text);
                    LabHorasRestantes.Text = horasRestantes.ToString();
                }
                else
                {
                    int horasRestantes = 500 - int.Parse(LabTotalHoras.Text);
                    LabHorasRestantes.Text = horasRestantes.ToString();
                }
            }

            gridDatosAlumnos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LabCarnet.Text = "";
            txtBuscar.Text = "";
            LabNombre.Text = "";
            LabApellido.Text = "";
            LabCorreo.Text = "";
            LabActivoDesde.Text = "";
            LabUltimoServicio.Text = "";
            LabTotalHoras.Text = "";
            LabHorasRestantes.Text = "";

            CargarDatosEnDataGridViem(2, compartir.carnetIngresado);

        }

        //Metodo para Eventos mouse enter y leave
        public void eventosEnterLeave(Button btn, Color ColorFondo, Color ColorLetra)
        {
            btn.BackColor = ColorFondo;
            btn.ForeColor = ColorLetra;
        }

        private void btnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnLimpiar, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnLimpiar, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void gridDatosAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = gridDatosAlumnos.SelectedCells[1].Value.ToString();
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaAlumnos = context.DatosAlumnos.Select(o => o.Carnet).ToList();

            bool encontrado = false;
            for (int indice = 0; indice < listaAlumnos.Count; indice++)
            {


                if (txtBuscar.Text == listaAlumnos[indice])
                {
                    CargarDatosEnDataGridViem(1, txtBuscar.Text);
                    totalHoras();

                    var usuario = context.DatosAlumnos.FirstOrDefault(u => u.Carnet == txtBuscar.Text);
                    LabCarnet.Text = txtBuscar.Text;
                    LabNombre.Text = usuario.Nombres;
                    LabApellido.Text = usuario.Apellidos;
                    LabCorreo.Text = usuario.Correo;


                    var usuarioF = context.horasSociales.Where(u => u.Carnet == txtBuscar.Text).Select(u => u.Fecha).ToList();
                    LabActivoDesde.Text = usuarioF[0].ToString();
                    LabUltimoServicio.Text = usuarioF[usuarioF.Count - 1].ToString();
                    if (usuario.TipoEstudio == "Técnico")
                    {
                        int horasRestantes = 300 - int.Parse(LabTotalHoras.Text);
                        LabHorasRestantes.Text = horasRestantes.ToString();
                    }
                    else
                    {
                        int horasRestantes = 500 - int.Parse(LabTotalHoras.Text);
                        LabHorasRestantes.Text = horasRestantes.ToString();
                    }
                    encontrado = true;
                    break;
                }
                if (encontrado == false && indice == listaAlumnos.Count - 1)
                {
                    MessageBox.Show("El carnet ingresado no fue encontrado", "ITCA FEPADE SS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (encontrado == true)
                {
                    break;
                }
            }

        }


        public void totalHoras()
        {
            int totalHoras = 0;
            foreach (DataGridViewRow fila in gridDatosAlumnos.Rows)
            {
                totalHoras += Convert.ToInt32(fila.Cells["Total"].Value);
            }
            LabTotalHoras.Text = totalHoras.ToString();
        }

        private void panelDetallesAlumnos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
