using dfdfd.bdSocial;
using Microsoft.Win32;
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
    public partial class FrmHorarioPeriodo : Form
    {
        
        
        
        ProyectoSocialContext context = new ProyectoSocialContext();

        public FrmHorarioPeriodo()
        {
            InitializeComponent();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmObjetivosMetas vistaMain = new FrmObjetivosMetas();
            vistaMain.Show();
            Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          

            datosContenedor.lunesAM = txtMonAM.Text;
            datosContenedor.lunesPM = txtMonPM.Text;
            datosContenedor.martesAM = txtTueAM.Text;
            datosContenedor.martesPM = txtTuePM.Text;
            datosContenedor.miercolesAM = txtWedAM.Text;
            datosContenedor.miercolesPM = txtWedPM.Text;
            datosContenedor.juevesAM = txtThuAM.Text;
            datosContenedor.juevesPM = txtThuPM.Text;
            datosContenedor.viernesAM = txtFriAM.Text;
            datosContenedor.viernesPM = txtFriPM.Text;

            if (string.IsNullOrWhiteSpace(txtMonAM.Text) && string.IsNullOrWhiteSpace(txtMonPM.Text) && string.IsNullOrWhiteSpace(txtTueAM.Text) && string.IsNullOrWhiteSpace(txtTuePM.Text) && string.IsNullOrWhiteSpace(txtWedAM.Text) && string.IsNullOrWhiteSpace(txtWedPM.Text) && string.IsNullOrWhiteSpace(txtThuAM.Text) && string.IsNullOrWhiteSpace(txtThuPM.Text) && string.IsNullOrWhiteSpace(txtFriAM.Text) && string.IsNullOrWhiteSpace(txtFriPM.Text))
            {
                MessageBox.Show("Por favor, Completar al menos 1 campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbDatosRegistro registro= new tbDatosRegistro();

                foreach (var propiedad in typeof(datosContenedor).GetProperties())
                {
                    var valor = propiedad.GetValue(null);

                    // Aquí puedes agregar lógica adicional si es necesario,
                    // por ejemplo, para manejar valores nulos o conversiones de tipo.

                    typeof(tbDatosRegistro).GetProperty(propiedad.Name)?.SetValue(registro, valor);
                }
                context.Add(registro);


                // Desactivar validación de restricciones de clave externa temporalmente (si es necesario)

                // Guardar cambios en la base de datos
                if (context.SaveChanges() == 1)
                {
                    MessageBox.Show("Datos guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error inesperado, no se ha podido registrar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Reactivar validación de restricciones de clave externa (si se desactivó)


            }

            Close();
        }
    }
}
