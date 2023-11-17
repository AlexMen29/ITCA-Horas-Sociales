using dfdfd.bdSocial;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HorasSociales2
{
    public partial class FrmObjetivosMetas : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public FrmObjetivosMetas()
        {
            InitializeComponent();

            txtAct1.TextChanged += TextBox1_TextChanged;
            txtObjetivos1.TextChanged += TextBox1_TextChanged;
            txtGoals1.TextChanged += TextBox1_TextChanged;
            txtDuracion1.TextChanged += TextBox1_TextChanged;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDatosInstitucion vistaMain = new FrmDatosInstitucion();
            vistaMain.Show();
            Hide();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAct1.Text) || string.IsNullOrWhiteSpace(txtObjetivos1.Text) || string.IsNullOrWhiteSpace(txtGoals1.Text) || string.IsNullOrWhiteSpace(txtDuracion1.Text))
            {
                MessageBox.Show("Por favor, Completar al menos 1 campo de cada apartado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                datosContenedor.actividad1 = txtAct1.Text;
                datosContenedor.objetivos1 = txtObjetivos1.Text;
                datosContenedor.metas1 = txtGoals1.Text;
                datosContenedor.duracion1 = txtDuracion1.Text;
                datosContenedor.actividad2 = txtAct2.Text;
                datosContenedor.objetivos2 = txtObjetivos2.Text;
                datosContenedor.metas2 = txtGoals2.Text;
                datosContenedor.duracion2 = txtDuracion2.Text;

                FrmHorarioPeriodo vistaObj = new FrmHorarioPeriodo();
                vistaObj.Show();
                Hide();

            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAct1.Text) || string.IsNullOrWhiteSpace(txtObjetivos1.Text) || string.IsNullOrWhiteSpace(txtGoals1.Text) || string.IsNullOrWhiteSpace(txtDuracion1.Text))
            {
                txtAct2.Enabled = false;
                txtObjetivos2.Enabled = false;
                txtGoals2.Enabled = false;
                txtDuracion2.Enabled = false;
            }

            else
            {
                txtAct2.Enabled = true;
                txtObjetivos2.Enabled = true;
                txtGoals2.Enabled = true;
                txtDuracion2.Enabled = true;
            }

        }
    }
}