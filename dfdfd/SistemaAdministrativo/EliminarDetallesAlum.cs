using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class EliminarDetallesAlum : Form
    {
        public EliminarDetallesAlum()
        {
            InitializeComponent();
        }

        private void EliminarDetallesAlum_Load(object sender, EventArgs e)
        {

        }


        private void True(object sender, ScrollEventArgs e)
        {

        }

        private void pnlInfoEliDetAd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Borra el contenido de las cajas de texto
                txtBoxCarnetCap.Text = "";
                txtBoxNombresCap.Text = "";
                txtBoxApellidosCap.Text = "";
                txtBoxCarreraCap.Text = "";
                txtBoxCorreoCap.Text = "";
                txtBoxTelAlumCap.Text = "";
                txtBoxCoorSSECap.Text = "";
                txtBoxTelEmergCap.Text = "";
                txtBoxConctEmergCap.Text = "";
                txtBoxNombreInstCap.Text = "";
                txtBoxTelInstCap.Text = "";
                txtBoxActivReaCap.Text = "";
                txtBoxResponsableCap.Text = "";
                txtBoxCorreoResponCap.Text = "";
                txtBoxTiempoCap.Text = "";
                txtBoxInicioSSCap.Text = "";
                txtBoxObjetivosCap.Text = "";
                txtBoxMetasCap.Text = "";
                txtBoxDuracionCap.Text = "";

                MessageBox.Show("Datos eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no han sido eliminados.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Coloca aquí el código para modificar los datos
                // Guardar los nuevos valores en una base de datos
                // Actualizar los controles con los nuevos valores
                // 
                txtBoxCarnetCap.Text = "";
                txtBoxNombresCap.Text = "";
                txtBoxApellidosCap.Text = "";
                txtBoxCarreraCap.Text = "";
                txtBoxCorreoCap.Text = "";
                txtBoxTelAlumCap.Text = "";
                txtBoxCoorSSECap.Text = "";
                txtBoxTelEmergCap.Text = "";
                txtBoxConctEmergCap.Text = "";
                txtBoxNombreInstCap.Text = "";
                txtBoxTelInstCap.Text = "";
                txtBoxActivReaCap.Text = "";
                txtBoxResponsableCap.Text = "";
                txtBoxCorreoResponCap.Text = "";
                txtBoxTiempoCap.Text = "";
                txtBoxInicioSSCap.Text = "";
                txtBoxObjetivosCap.Text = "";
                txtBoxMetasCap.Text = "";
                txtBoxDuracionCap.Text = "";


                MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no han sido modificados.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
