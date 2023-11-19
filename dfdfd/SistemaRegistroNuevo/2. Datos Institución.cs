using dfdfd.bdSocial;
using Login;
using ProyectoSocial;
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
        private int formulario;
        private string carnetB;
        public FrmDatosInstitucion(int a, string carnet)
        {
            formulario = a;
            carnetB = carnet;

            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (formulario == 2)
            {
                FrmDatosGenerales frm = new FrmDatosGenerales(2, carnetB);
                frm.Show();
                Hide();
            }
            /*
            FrmDatosGenerales vistaMain = new FrmDatosGenerales();
            vistaMain.Show();
            Hide();
            */
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (formulario == 1)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtActivity.Text) || string.IsNullOrWhiteSpace(txtResponsable.Text) || string.IsNullOrWhiteSpace(txtTime.Text) || string.IsNullOrWhiteSpace(txtResPhone.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Por favor, Completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    datosContenedor.institucion = txtName.Text;
                    datosContenedor.telefonoInstitucion = int.Parse(txtPhone.Text);
                    datosContenedor.actividades = txtActivity.Text;
                    datosContenedor.responsable = txtResponsable.Text;
                    datosContenedor.correoResponsable = txtEmail.Text;
                    datosContenedor.telefonoResponsable = int.Parse(txtResPhone.Text);
                    datosContenedor.tiempo = int.Parse(txtTime.Text);
                    datosContenedor.fecha = DateTime.Parse(dateDate.Text);

                    FrmObjetivosMetas vistaObj = new FrmObjetivosMetas(1, "N/A");
                    vistaObj.Show();
                    Hide();
                }
            }
            else
            {
                FrmObjetivosMetas form = new FrmObjetivosMetas(2, carnetB);
                form.Show();
                Hide();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

        private void txtResPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }

        private void FrmDatosInstitucion_Load(object sender, EventArgs e)
        {
            if (formulario == 2)
            {
                pnlLeft.Visible = false;
                var datosUsuario = context.tbDatosRegistro.FirstOrDefault(o => o.carnet == carnetB);

                txtName.Text = datosUsuario.nombre;
                txtPhone.Text = datosUsuario.telefono.ToString();
                txtActivity.Text = datosUsuario.actividades;
                txtResponsable.Text = datosUsuario.responsable;
                txtEmail.Text = datosUsuario.correoResponsable;
                txtResPhone.Text = datosUsuario.telefonoResponsable.ToString();
                txtTime.Text = datosUsuario.tiempo.ToString();
                dateDate.Text = datosUsuario.fecha.ToString();

                txtName.Enabled = false;
                txtPhone.Enabled = false;
                txtActivity.Enabled = false;
                txtResponsable.Enabled = false;
                txtEmail.Enabled = false;
                txtResPhone.Enabled = false;
                txtTime.Enabled = false;
                dateDate.Enabled = false;

            }
        }
    }
}
