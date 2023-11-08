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
    public partial class FrmDatosInstitucion : Form
    {
        public FrmDatosInstitucion()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmDatosGenerales vistaMain = new FrmDatosGenerales();
            vistaMain.Show();
            Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmObjetivosMetas vistaMain = new FrmObjetivosMetas();
            vistaMain.Show();
            Hide();
        }

    }
}
