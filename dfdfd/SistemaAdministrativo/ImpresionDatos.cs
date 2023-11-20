using dfdfd.bdSocial;
using HorasSociales2;
using Login;
using ProyectoSocial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class ImpresionDatos : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public ImpresionDatos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var alumnos = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario==1).Select(o => o.Carnet).ToList();

            for (int indice = 0; indice < alumnos.Count; indice++)
            {
                bool encontrado = false;
                if (txtBuscar.Text == alumnos[indice])
                {
                    PicturiEspera.Visible = false;


                    FrmDatosGenerales form = new FrmDatosGenerales(2, txtBuscar.Text);
                    form.Show();

                    encontrado = true;
                }
                if (encontrado == false && indice == alumnos.Count() - 1)
                {
                    MessageBox.Show("El estudiante ingresado no fue encontrado ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (encontrado == true)
                {
                    break;
                }
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = null;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }
        private void ImpresionDatos_Load_1(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = true;


            if (compartir.usuario.NivelUsuario == 1)
            {
                PanelOcultar.Visible = false;
                FrmDatosGenerales form = new FrmDatosGenerales(2, compartir.carnetIngresado);
                form.Show();
            }
        }
    }


}
