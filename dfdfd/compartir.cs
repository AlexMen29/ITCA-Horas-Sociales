using dfdfd.bdSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSocial
{
    public class compartir
    {
        public static string carnetIngresado { get; set; }
        public static int Nivelusuario { get; set; }
        public static DatosAlumno usuario { get; set; }
        public static void ValidacionNumerica(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Escriba un dato válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true; // Indica que la tecla fue manejada y no se procesará más
            }
        }
    }
}
