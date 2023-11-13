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
//Agrego lo que utilizaré para el reporte. 
using iText.IO.Image;
using iText.IO.Font;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Diagnostics;
using System.IO;

namespace ProyectoSocial.Reportes
{
    public partial class FrmReportes : Form
    {
        //Crearé la ruta para guardar el reporte:
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosPDF\";


        ProyectoSocialContext context = new ProyectoSocialContext();
        public FrmReportes()
        {
            InitializeComponent();
            InitializeComponent();
            gridReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarDatosEnDataGridViem();
        }

        public void crearPDF()
        {
            var exportarPDF = System.IO.Path.Combine(path, "Documento.pdf");
            using (var writer = new PdfWriter(exportarPDF))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, iText.Kernel.Geom.PageSize.A4);

                    //Los margenes del documento:
                    doc.SetMargins(90, 0, 0, 0);

                    //Cargaré la imagen desde el disco:
                    ImageData imageData = ImageDataFactory.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosPDF\ITCALOGO.png");

                    //Crearé la imagen y le defino sus parámetros:
                    var image = new iText.Layout.Element.Image(imageData)

                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFixedPosition(1, 10, 700);

                    //Agregaré la imagen al PDF:
                    doc.Add(image);
                    Paragraph encabezado = new Paragraph("");
                    encabezado.Add(image);
                    doc.Add(encabezado);

                    //Definiré el nombre del proyecto:
                    string nombreProyecto = "Control de Horas Sociales de ITCA-FEPADE";
                    string sitioWeb = "www.itca.edu.sv";
                    string direccion = "Carr. Panamericana, Santa Tecla";
                    string cede = "Cede Central Santa Tecla";


                    PdfFont boldFont = PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD);
                    iText.Kernel.Colors.Color colorOrange = new DeviceRgb(255, 80, 0);
                    iText.Kernel.Colors.Color colorAzul = new DeviceRgb(0, 92, 226);
                    iText.Kernel.Colors.Color colorWhite = new DeviceRgb(255, 255, 255);
                    iText.Kernel.Colors.Color colorNegro = new DeviceRgb(0, 0, 0);

                    Paragraph parrafo0 = new Paragraph("Servicio Social")
                        .SetFontSize(32)
                        .SetMargins(0, 0, 0, 0)
                        .SetFontColor(colorOrange)
                        .SetFont(boldFont)
                        .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                        .SetTextAlignment(TextAlignment.CENTER);


                    doc.Add(parrafo0);

                    //Folio:
                    Paragraph pFolio = new Paragraph("");
                    pFolio.Add("Reporte: 1");

                    pFolio.SetFixedPosition(300, 685, 300);
                    pFolio.SetPageNumber(1);
                    pFolio.SetFont(boldFont);
                    pFolio.SetTextAlignment(TextAlignment.CENTER);
                    pFolio.SetFontSize(18);
                    pFolio.SetFontColor(colorAzul);
                    doc.Add(pFolio);

                    Paragraph pCarnet = new Paragraph("Carnet: \n" + txtCarnetReport.Text.ToString());
                    pCarnet.SetFixedPosition(250, 600, 300);
                    pCarnet.SetPageNumber(1);
                    //pCarnet.SetFont(boldFont);
                    pCarnet.SetTextAlignment(TextAlignment.CENTER);
                    pCarnet.SetFontSize(24);
                    //pCarnet.SetFontColor(colorAzul);
                    doc.Add(pCarnet);

                    Paragraph parrafo1 = new Paragraph("Fecha del reporte: " + DateTime.Now + "\n").SetFontSize(12)
                        .Add("Fecha vigencia: " + DateTime.Now + "\n").SetFontSize(12)
                        .Add("\n" + nombreProyecto + "\n").SetFontSize(12)
                        .Add("Sitio Web: " + sitioWeb + "\n").SetFontSize(12)
                        .Add("Dirección: " + direccion + "\n").SetFontSize(12)
                        .Add("Cede: " + cede + "\n").SetFontSize(12)
                        .SetMargins(0, 20, 0, 20)
                        .Add("Estudiante: " + txtNombresReport.Text.ToString() + "\n")
                        .Add("\nEstimado estudiante " + txtNombresReport.Text.ToString() + "me permito enviarle el reporte " +
                        "correspondiente a su Servicio Social de ITCA-FEPADE.\n");

                    doc.Add(parrafo1).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                    Style styleHeader = new Style()
                        .SetBackgroundColor(colorOrange)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(10);

                    //Vladimir XD
                    

                }
            }
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
        

        private void btnGenerarReporte_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarReporte_MouseLeave(object sender, EventArgs e)
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
                    txtNombresReport.Text = valorNombre.ToString();

                    // Obtiene el valor de la celda en la columna "apellidos"
                    object valorApellidos = gridReport.Rows[e.RowIndex].Cells["apellidos"].Value;
                    txtApellidosReport.Text = valorApellidos.ToString();

                    // Obtiene el valor de la celda en la columna "correo"
                    object valorCorreo = gridReport.Rows[e.RowIndex].Cells["correo"].Value;
                    txtCorreoReport.Text = valorCorreo.ToString();

                    // Obtiene el valor de la celda en la columna "grupo"
                    object valorGrupo = gridReport.Rows[e.RowIndex].Cells["grupo"].Value;
                    txtGrupoReport.Text = valorGrupo.ToString();
                }
            }
        }
    }
}

