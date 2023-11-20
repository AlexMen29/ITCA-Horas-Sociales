//Todo lo necesario para crear el PDF através del btnGenerarReporte
//Se ha instalado el iTextSharp para poder crear el reporte
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importar librerías de iTextSharp
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
//using System.Reflection.Metadata;
using iTextSharp.text; //Me soluciona el problema de usar el System ya que no son compatibles si se usan ambos al mismo tiempo
//import System.IO
//import ItextSharp.text.pdf


namespace ProyectoSocial
{
    public class Procesar_PDF
    {
        //iniciar la ruta del directorio
        public string rutaDirectorio = Application.StartupPath + "\\ReportePDF";

        private string nombreArchivo = "";

        private void crearDirectorio()
        {
            //Si el directorio no existe, entonces que me lo cree. 
            if (!Directory.Exists(rutaDirectorio))
            {
                Directory.CreateDirectory(rutaDirectorio);
            }
        }

        private bool verificarArchivo(string nombreArchivo)
        {
            if (File.Exists(rutaDirectorio + "\\" + nombreArchivo))
            {
                return true;
            }
            return false;
        }

        Document docPDF = new Document();
        iTextSharp.text.Image fotoPDF; //pictureBox1
        PdfContentByte dc;
        string ruta = "";
        int x, y, espacioVertical; //la posición del archivo; x horizontal, y vertical
        iTextSharp.text.pdf.PdfWriter pdfW;

        public void crearPdf(Datos_Estudiantes datos_Estudiantes, DataGridView dato)
        {
            crearPdf(datos_Estudiantes, dato, docPDF);
        }

        public void crearPdf(Datos_Estudiantes datos_Estudiantes, DataGridView dato, Document docPDF)
        {

            crearDirectorio();
            ruta = rutaDirectorio + "\\" + datos_Estudiantes.carnet + ".pdf";
            if (!verificarArchivo(datos_Estudiantes.carnet))
            {
                pdfW = PdfWriter.GetInstance(docPDF, new FileStream(ruta, FileMode.Create));
                docPDF.Open();
                dc = pdfW.DirectContent; //Tamaño y color de la letra.
                int limite = 820;
                x = 25;
                y = 80;
                espacioVertical = 30;

                //MessageBox.Show(docPDF.PageSize.Height.ToString()); ME DABA ERROR "842".

                dc.SetColorFill(iTextSharp.text.BaseColor.BLACK);

                if (datos_Estudiantes.logo_itca != null)
                {
                    //docPDF.PageSize.Heigth representa la alineación a la izquierda de los datos.
                    fotoPDF = iTextSharp.text.Image.GetInstance(datos_Estudiantes.logo_itca, iTextSharp.text.BaseColor.WHITE);
                    fotoPDF.SetAbsolutePosition(x, docPDF.PageSize.Height - y);
                    fotoPDF.ScaleAbsolute(70, 70);
                    docPDF.Add(fotoPDF);
                }


                x += 50;
                //Los encabezados
                //Aquí me permiten tomar el tamaño y la fuente de la letra.
                // Dode PageSize.Width me permite manipular el maquetado del reporte, se divide entre 2 para darle un salto de línea a los titulos
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD).BaseFont, 12);
                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.titulo, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;

                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.subTitulo, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;

                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.otroTitulo, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;

                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.datosLlenar, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);

                //Los datos a llenar del estudiante:
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, iTextSharp.text.Font.NORMAL).BaseFont, 11);
                //dc.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, datos_Estudiantes.NombreCompleto, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;

                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.NombreCompleto, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.EscuelaEstudiante, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.SedeEstudiante, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.carreraEstudiante, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.carnetNo, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.jornada, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.estudioYear, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.TelefonoEstudiante, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.correoEstu, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;


                //Encabezado de la institución:
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES, 12, iTextSharp.text.Font.BOLD).BaseFont, 12);
                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.tituloDos, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.tituloTres, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                //Datos de la Institución
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, iTextSharp.text.Font.NORMAL).BaseFont, 11);
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.NombreInsti, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.direccionInst, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.telefonoInst, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.sitioWebInst, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.fechaInicio, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.fechaFinal, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.observaciones, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.f, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.nombreEnca, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.desEnca, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.s, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;


                //Si se sobrepasa los datos entonces que se me cree un nuevo documento
                if (y > limite)
                {
                    docPDF.NewPage();
                    dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, iTextSharp.text.Font.NORMAL).BaseFont, 11);
                    y = 30;
                    x = 80;
                }

                //Otra página:
                
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, iTextSharp.text.Font.NORMAL).BaseFont, 11);
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.f, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - x, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.nombreEncaDos, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, datos_Estudiantes.desSSE, docPDF.PageSize.Width / 23, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;
                dc.ShowTextAligned(PdfContentByte.ALIGN_CENTER, datos_Estudiantes.s2, docPDF.PageSize.Width / 2, docPDF.PageSize.Height - y, 0);
                y += espacioVertical;


                if (y > limite)
                {
                    docPDF.NewPage();
                    dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, iTextSharp.text.Font.NORMAL).BaseFont, 11);
                    y = 30;
                    x = 80;
                }

                //Recorrido del gridEstudiantes:
                dc.SetColorFill(iTextSharp.text.BaseColor.BLACK);
                dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL).BaseFont, 11);
                y += 15;

                //Uso el bucle for para iterar el ancho de la página que es "i"
                //Donde "-" dará alineación a la izquierda del documento
                //docPDF.PageSize.Heigth representa la alineación a la izquierda de los datos.
                //Donde los "-" son iguales al ancho del documento.
                for (int i = 0; i < docPDF.PageSize.Width; i++)
                {
                    dc.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "-", i, docPDF.PageSize.Height - y, 0);
                }
                y += 15;
                //dc.SetFontAndSize(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 11, iTextSharp.text.Font.NORMAL).BaseFont, 11);
                for (int i = 0; i < dato.Rows.Count; i++)
                {
                    if (y > limite)
                    {
                        docPDF.NewPage();

                        y = 30;
                        x = 80;
                    }
                }
                if (y > limite)
                {
                    docPDF.NewPage();
                    y = 30;
                    x = 80;
                }


                docPDF.Close();
                MessageBox.Show("Reporte creado correctamente.", "Reporte de Servicio Social", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El repoorte ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
