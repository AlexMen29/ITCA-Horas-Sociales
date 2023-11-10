using dfdfd.bdSocial;
using Login;
using ProyectoSocial.bdSocial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaAdministrativo
{
    public partial class FrmDatosInicio : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();

        public FrmDatosInicio()
        {
            InitializeComponent();
            //Con esta linea podemos evitar que los usuarios ingresen texto en la comboBox
            boxHoras.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }
        public void eventosEnterLeave(Button btn, Color ColorFondo, Color ColorLetra)
        {
            btn.BackColor = ColorFondo;
            btn.ForeColor = ColorLetra;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            horasSociales datosTabla = new horasSociales();

            datosTabla.Carnet = compartir.usuario.Carnet;
            datosTabla.Fecha = dateTimePicker1.Value;
            datosTabla.Actividad = txtActividad.Text;
            datosTabla.Total = Convert.ToInt32(boxHoras.Text);
            datosTabla.Grupo = compartir.usuario.Grupo;

            context.Add(datosTabla);

            if (context.SaveChanges() == 1)
            {
                MessageBox.Show("Registro guardado exitosamente", "ITCA FEPADE SS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Inesperado", "ITCA FEPADE SS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmDatosInicio_Load(object sender, EventArgs e)
        {

        }
    }
}