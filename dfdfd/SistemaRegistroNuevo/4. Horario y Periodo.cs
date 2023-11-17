using dfdfd.bdSocial;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HorasSociales2
{
    public partial class FrmHorarioPeriodo : Form
    {

        ProyectoSocialContext context = new ProyectoSocialContext();

        public FrmHorarioPeriodo()
        {
            InitializeComponent();

            cmbSinceMON.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            cmbSinceTUE.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            cmbSinceWED.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;
            cmbSinceTHU.SelectedIndexChanged += ComboBox4_SelectedIndexChanged;
            cmbSinceFRI.SelectedIndexChanged += ComboBox5_SelectedIndexChanged;
            cmbSinceSAT.SelectedIndexChanged += ComboBox6_SelectedIndexChanged;
            cmbSinceSUN.SelectedIndexChanged += ComboBox7_SelectedIndexChanged;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmObjetivosMetas vistaMain = new FrmObjetivosMetas();
            vistaMain.Show();
            Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cmbSinceMON.Text) && string.IsNullOrWhiteSpace(cmbUntilMON.Text) && string.IsNullOrWhiteSpace(cmbSinceTUE.Text) && string.IsNullOrWhiteSpace(cmbUntilTUE.Text) && string.IsNullOrWhiteSpace(cmbSinceWED.Text) && string.IsNullOrWhiteSpace(cmbUntilWED.Text) && string.IsNullOrWhiteSpace(cmbSinceTHU.Text) && string.IsNullOrWhiteSpace(cmbUntilTHU.Text) && string.IsNullOrWhiteSpace(cmbSinceFRI.Text) && string.IsNullOrWhiteSpace(cmbUntilFRI.Text) && string.IsNullOrWhiteSpace(cmbSinceSAT.Text) && string.IsNullOrWhiteSpace(cmbUntilSAT.Text) && string.IsNullOrWhiteSpace(cmbSinceSUN.Text) && string.IsNullOrWhiteSpace(cmbUntilSUN.Text))
            {
                MessageBox.Show("Por favor, Completar al menos 1 campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(cmbUntilMON.Text) && string.IsNullOrWhiteSpace(cmbUntilTUE.Text) && string.IsNullOrWhiteSpace(cmbUntilWED.Text) && string.IsNullOrWhiteSpace(cmbUntilTHU.Text) && string.IsNullOrWhiteSpace(cmbUntilFRI.Text) && string.IsNullOrWhiteSpace(cmbUntilSAT.Text) && string.IsNullOrWhiteSpace(cmbUntilSUN.Text))
                {
                    MessageBox.Show("Por favor, Ingresar el campo de la hora de finalizacion del trabajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    datosContenedor.lunes = cmbSinceMON.Text + " - " + cmbUntilMON.Text;
                    datosContenedor.martes = cmbSinceTUE.Text + " - " + cmbUntilTUE.Text;
                    datosContenedor.miercoles = cmbSinceWED.Text + " - " + cmbUntilWED.Text;
                    datosContenedor.jueves = cmbSinceTHU.Text + " - " + cmbUntilTHU.Text;
                    datosContenedor.viernes = cmbSinceFRI.Text + " - " + cmbUntilFRI.Text;
                    datosContenedor.sabado = cmbSinceSAT.Text + " - " + cmbUntilSAT.Text;
                    datosContenedor.domingo = cmbSinceSUN.Text + " - " + cmbUntilSUN.Text;

                    tbDatosRegistro registro = new tbDatosRegistro();

                    foreach (var propiedad in typeof(datosContenedor).GetProperties())
                    {
                        var valor = propiedad.GetValue(null);

                        typeof(tbDatosRegistro).GetProperty(propiedad.Name)?.SetValue(registro, valor);
                    }
                    context.Add(registro);


                    if (context.SaveChanges() == 1)
                    {
                        MessageBox.Show("Datos guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }

                    else
                    {
                        MessageBox.Show("Error inesperado, no se ha podido registrar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUntilMON.Enabled = true;
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUntilTUE.Enabled = true;
        }
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUntilWED.Enabled = true;
        }
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUntilTHU.Enabled = true;
        }
        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUntilFRI.Enabled = true;
        }
        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUntilSAT.Enabled = true;
        }
        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUntilSUN.Enabled = true;
        }
    }
}
