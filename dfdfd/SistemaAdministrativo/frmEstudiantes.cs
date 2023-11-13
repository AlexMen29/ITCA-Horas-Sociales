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
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosPDF\";
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
                    string nombreProyecto = "ESCUELA ESPECIALIZADA EN INGENIERÍA ITCA-FEPADE";
                    string subNombreProyecto = "PROGRAMA DE SERVICIO SOCIAL ESTUDIANTIL";
                    string subTitulo = "HOJA DE FINALIZACIÓN DEL SERVICIO SOCIAL ESTUDIANTIL";
                    string finalSubTitulo = "DATOS A LLENAR POR EL ESTUDIANTE";



                    PdfFont boldFont = PdfFontFactory.CreateFont();
                    iText.Kernel.Colors.Color colorOrange = new DeviceRgb(255, 80, 0);
                    iText.Kernel.Colors.Color colorAzul = new DeviceRgb(0, 92, 226);
                    iText.Kernel.Colors.Color colorWhite = new DeviceRgb(255, 255, 255);
                    iText.Kernel.Colors.Color colorNegro = new DeviceRgb(0, 0, 0);

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

                    Paragraph pCarnet = new Paragraph("Nombre completo del estudiante: \n");
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
                        .Add("Escuela a la que pertenece: " + "\n").SetFontSize(12)
                        .Add("Sede a la cual pertenece: " + "\n").SetFontSize(12)
                        .Add("Carrera que estudia: " + "\n").SetFontSize(12)
                        .SetMargins(0, 20, 0, 20)
                        .Add("Estudiante: " + "\n")
                        .Add("Carent N°: " + "\n").SetFontSize(12)
                        .Add("Jornada: " + "\n").SetFontSize(12)
                        .Add("Año de estudio: " + "\n").SetFontSize(12)
                        .Add("Teléfono: " + "\n").SetFontSize(12)
                        .Add("Correo electrónico: " + "\n").SetFontSize(12)
                        .Add("\nEstimado estudiante " + "me permito enviarle el reporte " +
                        "correspondiente a su Servicio Social de ITCA-FEPADE.\n");

                    doc.Add(parrafo1).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                    Style styleHeader = new Style()
                        .SetBackgroundColor(colorOrange)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(10);

                    //Vladimir XD

                    Paragraph datosInst = new Paragraph("\nDATOS A LLENAR POR LA INSTITUCIÓN DONDE REALIZÓ EL SERVICIO SOCIAL ESTUDIANTIL");
                    datosInst.SetFixedPosition(250, 600, 300);
                    datosInst.SetPageNumber(1);
                    //pCarnet.SetFont(boldFont);
                    datosInst.SetTextAlignment(TextAlignment.CENTER);
                    datosInst.SetFontSize(24);
                    //pCarnet.SetFontColor(colorAzul);
                    doc.Add(datosInst);


                    //Debo conectar los datos en la BD de Fernando :D
                    Paragraph parrafo2 = new Paragraph().SetFontSize(12)
                        .Add("Nombre completo de la institución: " + "\n").SetFontSize(12)
                        .Add("Dirección: " + "\n").SetFontSize(12)
                        .Add("Telefonos: " + "\n").SetFontSize(12)
                        .Add("Sitio web: " + "\n").SetFontSize(12)
                        .Add("Fecha de inicio: " + "\n").SetFontSize(12)
                        .Add("Fecha de finalización: " + "\n").SetFontSize(12)
                        .Add("Observaciones: " + "\n").SetFontSize(12)
                        .Add("F: ________________________________________" + "\n").SetFontSize(12)
                        .Add("Nombre: " + "\n").SetFontSize(12)
                        .Add("Encargado de supervisar el Servicio Social en la institución.").SetFontSize(12)
                        .Add("F: ________________________________________" + "\n").SetFontSize(12)
                        .Add("Nombre").SetFontSize(12)
                        .Add("Coordinador de SSE de Escuela Académica.")
                        .Add("Sello").SetTextAlignment(TextAlignment.CENTER)
                        .Add("Sello ").SetTextAlignment(TextAlignment.RIGHT);
                }
            }

            try
            {

                if (File.Exists(path + "Finalización_Servicio_Social.pdf"))
                {
                    Process.Start(path + "Finalización_Servicio_Social.pdf");// ABRO EL ARCHIVO 
                }

            }
            catch (FileNotFoundException a)
            {


            }

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
            crearPDF();
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
    }
}
