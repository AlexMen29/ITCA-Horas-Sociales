using dfdfd.bdSocial;
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
        ProyectoSocialContext context = new ProyectoSocialContext();
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

            datosContenedor.institucion = txtName.Text;
            datosContenedor.telefonoInstitucion = int.Parse(txtPhone.Text);
            datosContenedor.actividades = txtActivity.Text;
            datosContenedor.responsable = txtResponsable.Text;
            datosContenedor.correoResponsable = txtEmail.Text;
            datosContenedor.telefonoResponsable = int.Parse(txtResPhone.Text);
            datosContenedor.tiempo = int.Parse(txtTime.Text);
            datosContenedor.fecha = dateDate.Value;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtActivity.Text) || string.IsNullOrWhiteSpace(txtResponsable.Text) || string.IsNullOrWhiteSpace(txtTime.Text) || string.IsNullOrWhiteSpace(txtResPhone.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Por favor, Completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmObjetivosMetas vistaObj = new FrmObjetivosMetas();
                vistaObj.Show();
                Hide();
            }
        }
    }
}
