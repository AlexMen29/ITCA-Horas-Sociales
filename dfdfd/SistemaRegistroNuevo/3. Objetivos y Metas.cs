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

namespace HorasSociales2
{
    public partial class FrmObjetivosMetas : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public FrmObjetivosMetas()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDatosInstitucion vistaMain = new FrmDatosInstitucion();
            vistaMain.Show();
            Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        { 
            datosContenedor.actividad1 = txtAct1.Text;
            datosContenedor.objetivos1 = txtObjetivos1.Text;
            datosContenedor.metas1 = txtGoals1.Text;
            datosContenedor.duracion1 = int.Parse(txtDuracion1.Text);
            datosContenedor.actividad2 = txtAct2.Text;
            datosContenedor.objetivos2 = txtObjetivos2.Text;
            datosContenedor.metas2 = txtGoals2.Text;
            datosContenedor.duracion2 = int.Parse(txtDuracion2.Text);

            if (string.IsNullOrWhiteSpace(txtAct1.Text) || string.IsNullOrWhiteSpace(txtObjetivos1.Text) || string.IsNullOrWhiteSpace(txtGoals1.Text) || string.IsNullOrWhiteSpace(txtDuracion1.Text))
            {
                MessageBox.Show("Por favor, Completar al menos 1 campo de cada apartado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                FrmHorarioPeriodo vistaObj = new FrmHorarioPeriodo();
                vistaObj.Show();
                Hide();

            }
        }
    }
}
