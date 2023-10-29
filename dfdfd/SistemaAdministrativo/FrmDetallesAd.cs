using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class FrmDetallesAd : Form
    {
        public FrmDetallesAd()
        {
            InitializeComponent();
            CargarDatosEnDataGridViem();
        }

        private void CargarDatosEnDataGridViem()
        {
            
            string cadenaConexion = "Data Source = DESKTOP-IJ4S2TJ\\SQLEXPRESS; Initial Catalog= proyectoSocial; Integrated Security= True";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string consulta = "SELECT * FROM dbo.DatosAlumnos";

                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            gridDatosAlumnos.DataSource = dataTable;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gridDatosAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
