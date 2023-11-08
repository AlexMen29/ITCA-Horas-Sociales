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
    public partial class FrmDatosGenerales : Form
    {
        public FrmDatosGenerales()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmDatosInstitucion vistaMain = new FrmDatosInstitucion();
            vistaMain.Show();
            Hide();
        }
    }
}
