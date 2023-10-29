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

//Acceso a la carpeta:
using ProyectoSocial.Contexto;

namespace SistemaAdministrativo
{
    public partial class EliminarDetallesAlum : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public EliminarDetallesAlum()
        {
            InitializeComponent();
            dataGridEliminarModificar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarDatosEnDataGridViem();
        }


        private void CargarTabla()
        {
            dataGridEliminarModificar.DataSource = null;
            dataGridEliminarModificar.DataSource = context.DatosAlumnos.ToList();
        }
        private void CargarDatosEnDataGridViem()
        {
            dataGridEliminarModificar.DataSource = context.DatosAlumnos.ToList();
            CargarTabla();

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
            if (MessageBox.Show(this, "¿Desea eliminar los registros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var aEliminar = context.DatosAlumnos.FirstOrDefault(p => p.Carnet == txtBoxCarnetCap.Text);
                context.DatosAlumnos.Remove(aEliminar);
                context.SaveChanges();

                MessageBox.Show("Registros eliminados correctamente.");
                CargarTabla();
            }
            else
            {
                MessageBox.Show("Los registros no han sido eliminados.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea modificar los registros?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var aModificar = context.DatosAlumnos.FirstOrDefault(p => p.Carnet == txtBoxCarnetCap.Text);
                aModificar.Carnet = txtBoxCarnetCap.Text;
                aModificar.Nombres = txtBoxNombresCap.Text;
                aModificar.Apellidos = txtBoxApellidosCap.Text;
                aModificar.Encargado = txtBoxResponsableCap.Text;
                aModificar.TipoEstudio = txtBoxCarreraCap.Text;
                aModificar.Correo = txtBoxCorreoCap.Text;
                aModificar.Grupo = txtGrupoCap.Text;


                context.DatosAlumnos.Update(aModificar);
                context.SaveChanges();

                MessageBox.Show("Registros modificados correctamente.");
                CargarTabla();
            }
            else
            {
                MessageBox.Show("Los registros no han sido modificados.");
            }
        }


        private void dataGridEliminarModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridEliminarModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridEliminarModificar_Click(object sender, EventArgs e)
        {
            txtBoxCarnetCap.Text = dataGridEliminarModificar.SelectedCells[0].Value.ToString();
            txtBoxNombresCap.Text = dataGridEliminarModificar.SelectedCells[3].Value.ToString();
            txtBoxApellidosCap.Text = dataGridEliminarModificar.SelectedCells[4].Value.ToString();
            txtBoxCarreraCap.Text = dataGridEliminarModificar.SelectedCells[6].Value.ToString();
            txtGrupoCap.Text = dataGridEliminarModificar.SelectedCells[8].Value.ToString();
            txtBoxCorreoCap.Text = dataGridEliminarModificar.SelectedCells[7].Value.ToString();
            txtBoxResponsableCap.Text = dataGridEliminarModificar.SelectedCells[5].Value.ToString();

        }

        private void pnlInfoEliMoAd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtGrupoCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void pnlInfoDeta_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnIInfoElMoAd_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void txtBoxDuracionCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxMetasCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxObjetivosCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxInicioSSCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxTiempoCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxCorreoResponCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxResponsableCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxActivReaCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxTelInstCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxNombreInstCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void txtBoxConctEmergCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxCoorSSECap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxTelEmergCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxTelAlumCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxCorreoCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxAñoCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxCarreraCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxApellidosCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxNombresCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxCarnetCap_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
