using HorasSociales2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class ImpresionDatos : Form
    {
        public ImpresionDatos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*
            // Me mostrará el cuadro de diálogo de impresión
            PrintDocument pd = new PrintDocument();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.PrinterSettings = printDialog.PrinterSettings; // Configuración de la impresora
                pd.PrintPage += new PrintPageEventHandler(this.ImprimirContenido);
                pd.DefaultPageSettings.Landscape = false; // Configura la orientación de la hoja

                // Verificar si la impresora admite color o no
                if (pd.PrinterSettings.SupportsColor)
                {
                    // Me mostrará el cuadro de diálogo de configuración de la impresora
                    PageSetupDialog pageSetupDialog = new PageSetupDialog();
                    pageSetupDialog.PageSettings = pd.DefaultPageSettings;

                    if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                    {
                        pd.DefaultPageSettings = pageSetupDialog.PageSettings;
                    }
                }

                pd.Print();
            */
            FrmDatosGenerales form = new FrmDatosGenerales(2, txtBuscar.Text);
            form.Show();

        }
    }

    
}
