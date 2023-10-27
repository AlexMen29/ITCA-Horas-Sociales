using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class EstudianteOrDocente : Form
    {
        public EstudianteOrDocente()
        {
            InitializeComponent();
        }

      

        private void PanelUniversitario_MouseEnter(object sender, EventArgs e)
        {
            this.PanelUniversitario.BackColor = Color.Black;
            this.PanelUniversitario.ForeColor = Color.White;
        }

        private void PanelUniversitario_MouseLeave(object sender, EventArgs e)
        {
            this.PanelUniversitario.BackColor = Color.White;
            this.PanelUniversitario.ForeColor = Color.Black;

        }

        private void PanelDocente_MouseEnter(object sender, EventArgs e)
        {
            this.PanelDocente.BackColor = Color.Black;
            this.PanelDocente.ForeColor = Color.White;

        }

        private void PanelDocente_MouseLeave(object sender, EventArgs e)
        {
            this.PanelDocente.BackColor = Color.White;
            this.PanelDocente.ForeColor = Color.Black;

        }

        private void EstudianteOrDocente_Load(object sender, EventArgs e)
        {

        }

        private void PanelUniversitario_Click(object sender, EventArgs e)
        {
            
            RegistroUniversitarios frm = new RegistroUniversitarios();
            Close();
            frm.Show();
        }

        private void PanelDocente_Click(object sender, EventArgs e)
        {
            RegistroDocente frm = new RegistroDocente();
            Close();
            frm.Show();

        }

     
    }
}
