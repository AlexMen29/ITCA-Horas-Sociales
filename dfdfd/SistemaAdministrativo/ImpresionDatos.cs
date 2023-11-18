using dfdfd.bdSocial;
using HorasSociales2;
using Login;
using ProyectoSocial;
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
        ProyectoSocialContext context=new ProyectoSocialContext();
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


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var alumnos = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo).Select(o => o.Carnet).ToList();

            for (int indice = 0; indice < alumnos.Count; indice++)
            {
                bool encontrado=false;
                if (txtBuscar.Text == alumnos[indice])
                {
                    PicturiEspera.Visible = false;
                    FrmDatosGenerales form = new FrmDatosGenerales(2, txtBuscar.Text);

                    form.TopLevel = false;
                    form.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(form);

                    // Asigna el formulario como el Tag del SplitContainer si es necesario
                    splitContainer1.Tag = form;
                    form.FormBorderStyle = FormBorderStyle.None;
                    // Muestra el formulario
                    form.Show();

                    encontrado = true;
                }
                else if (encontrado == false && indice == alumnos.Count() - 1)
                {
                    MessageBox.Show("pasmado");
                }

                else if (encontrado == true)
                {
                    break;
                }
            }

           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = null;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

   
    }


}
