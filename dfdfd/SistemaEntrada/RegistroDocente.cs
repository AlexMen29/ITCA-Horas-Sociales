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
    public partial class RegistroDocente : Form
    {
        public RegistroDocente()
        {
            InitializeComponent();
        }

        private void btnRegresar_MouseEnter(object sender, EventArgs e)
        {
            this.btnRegresar.BackColor = ColorTranslator.FromHtml("#cd9013");
            this.btnRegresar.ForeColor = Color.White;

        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            this.btnRegresar.BackColor = ColorTranslator.FromHtml("#b1201f");
            this.btnRegresar.ForeColor = Color.White;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            EstudianteOrDocente frm = new EstudianteOrDocente();
            this.Close();
            frm.Show();
        }

        private void btnRegistrar_MouseEnter(object sender, EventArgs e)
        {
            this.btnRegistrar.BackColor = ColorTranslator.FromHtml("#cd9013");
            this.btnRegistrar.ForeColor = Color.White;

        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            this.btnRegistrar.BackColor = ColorTranslator.FromHtml("#b1201f");
            this.btnRegistrar.ForeColor = Color.White;

        }
    }
}
