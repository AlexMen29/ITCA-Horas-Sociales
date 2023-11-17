using dfdfd.bdSocial;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.IO.Font;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoSocial.SistemaAdministrativo
{
    public partial class frmEstudiantes : Form
    {
        //Crearé la ruta para guardar el reporte:
        //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosPDF\";
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

        public void crearPDF()
        {


        }

        public Cell getCell(String text, TextAlignment alignment)
        {
            Cell cell = new Cell().Add(new Paragraph(text));

            cell.SetTextAlignment(alignment);
            // cell.SetBorder(iText.Layout.Borders.Border.NO_BORDER);
            // cell.SetWidth();
            return cell;
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
                    e.CellStyle.BackColor = System.Drawing.Color.Green;
                    e.CellStyle.ForeColor = System.Drawing.Color.White;
                }
                else if (valorCelda.Equals("En Proceso", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                    e.CellStyle.ForeColor = System.Drawing.Color.Black;

                }

            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            //Procesar_PDF pdf = new Procesar_PDF();
            //pdf.crearDirectorio();
            if (gridEstudiantes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = gridEstudiantes.SelectedRows[0];

                Datos_Estudiantes datos_Estudiantes = new Datos_Estudiantes
                {
                    //Debo ingresar más variables si se crea más campos en el gridEstudiantes que estáne en la clase Datos_Estudiantes.
                    logo_itca = logoITCA.Image,
                    carnet = selectedRow.Cells[0].Value.ToString(),
                    nombres = selectedRow.Cells[3].Value.ToString(),
                    apellidos = selectedRow.Cells[4].Value.ToString(),
                    TipoEstudio = selectedRow.Cells[6].Value.ToString(),
                    correo = selectedRow.Cells[7].Value.ToString(),
                    grupo = selectedRow.Cells[8].Value.ToString(),
                    estado = selectedRow.Cells[9].Value.ToString(),


                };

                Procesar_PDF pdf = new Procesar_PDF();
                pdf.crearPdf(datos_Estudiantes, gridEstudiantes);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de generar el informe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void eventosEnterLeave(Button btn, System.Drawing.Color ColorFondo, System.Drawing.Color ColorLetra)
        {
            btn.BackColor = ColorFondo;
            btn.ForeColor = ColorLetra;
        }

        private void btnGenerarReporte_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnGenerarReporte, ColorTranslator.FromHtml("#cd9013"), System.Drawing.Color.White);
        }

        private void btnGenerarReporte_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnGenerarReporte, ColorTranslator.FromHtml("#b1201f"), System.Drawing.Color.White);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var consulta = context.DatosAlumnos.Where(o => o.Carnet == txtBuscar.Text && o.Estado == "Terminado").Count();
            if (consulta > 0)
            {
                MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nEsta apunto de imprimir la hoja social {compartir.usuario.Grupo}. ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                //si aqui dice que si aca ira la generacion del reporte
            }
            else
            {
                MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nno puede  imprimir la hoja social {compartir.usuario.Grupo}. ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void gridEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = gridEstudiantes.SelectedCells[0].Value.ToString();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboFiltra.Text == "MaxHoras")
            {
                gridEstudiantes.DataSource = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).OrderByDescending(o => o.HorasTotal).ToList();


            }
            else if (comboFiltra.Text == "MinHoras")
            {
                gridEstudiantes.DataSource = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).OrderBy(o => o.HorasTotal).ToList();

            }
        }

        private void logoITCA_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender,e);
        }
    }
}
