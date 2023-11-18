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
            var consulta = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).Count();
            if (consulta < 1)
            {
                MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nActualmente, no tienes estudiantes asignados a tu grupo, por lo que las funcionalidades del sistema se encuentran inactivas." +
                    $" Para aprovechar al máximo las características del sistema, asigna estudiantes a tu grupo: {compartir.usuario.Grupo} ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Por Favor, seleccione un carnet", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea eliminar al estudiante", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var Eliminar = context.DatosAlumnos.FirstOrDefault(o => o.Carnet == txtBuscar.Text);
                    context.DatosAlumnos.Remove(Eliminar);
                    if (context.SaveChanges() == 1)
                    {
                        MessageBox.Show("Estudiante eliminado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDataGrid();
                        txtBuscar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error inesperado, no se ha podido eliminar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //lista de alumnos de docente actual
            var listaDeAlumnos = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).Select(o => o.Carnet).ToList();

            for (int indice = 0; indice < listaDeAlumnos.Count; indice++)
            {
                bool encontrado = false;
                //si se encuentra el carntet ingresado
                if (txtBuscar.Text == listaDeAlumnos[indice])
                {
                    //verificamos si usuario ya termino su servicio social
                    var consulta = context.DatosAlumnos.Where(o => o.Carnet == txtBuscar.Text && o.Estado == "Terminado").Count();
                    //datos de usuario seleccionado
                    var usuario = context.DatosAlumnos.FirstOrDefault(o => o.Carnet == txtBuscar.Text);
                    if (consulta > 0)
                    {
                        if (MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nEsta apunto de imprimir la hoja social de: {usuario.Nombres + " " + usuario.Apellidos}. ", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            if (gridEstudiantes.SelectedRows.Count > 0)
                            {
                                // Obtener la fila seleccionada
                                DataGridViewRow selectedRow = gridEstudiantes.SelectedRows[0];
                                string carnet = selectedRow.Cells[0].Value.ToString();
                                var datosRegistro = context.tbDatosRegistro.FirstOrDefault(d => d.carnet == carnet);
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
                                if (datosRegistro != null)
                                {
                                    datos_Estudiantes.estudioAño = datosRegistro.año;
                                    datos_Estudiantes.escuelaEs = datosRegistro.escuela;
                                    datos_Estudiantes.telefonoEs = datosRegistro.telefono.ToString();
                                    datos_Estudiantes.institucionName = datosRegistro.institucion;
                                    datos_Estudiantes.responsable = datosRegistro.coordinador;
                                    datos_Estudiantes.telefonoInstitucion = datosRegistro.telefonoInstitucion;
                                    datos_Estudiantes.coordinador = datosRegistro.coordinador;
                                    datos_Estudiantes.responsable = datosRegistro.responsable;
                                    //datos_Estudiantes.direInst = datos_Estudiantes.instucion;
                                    datos_Estudiantes.fechaInicioSer = datosRegistro.fecha.ToLongDateString();
                                    datos_Estudiantes.fechaFinalSer = datosRegistro.fecha.ToLongDateString();
                                }
                                Procesar_PDF pdf = new Procesar_PDF();
                                pdf.crearPdf(datos_Estudiantes, gridEstudiantes);
                            }
                            else
                            {
                                MessageBox.Show("Por favor, seleccione una fila antes de generar el informe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nno puede  imprimir la hoja social de {usuario.Nombres + " " + usuario.Apellidos}, actualmente tiene realizadas {usuario.HorasTotal} horas sociales siendo su tipo de estudio de {usuario.TipoEstudio}", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    encontrado = true;
                }

                if (encontrado == false && indice == listaDeAlumnos.Count - 1)
                {
                    MessageBox.Show("El carnet ingresado es invalido", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (encontrado == true)
                {
                    break;
                }

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
            compartir.ValidacionNumerica(sender, e);
        }
    }
}
