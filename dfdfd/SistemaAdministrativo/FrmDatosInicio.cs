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
        public FrmDatosInicio()
        {
            InitializeComponent();
            CargarDatosEnDataGridViem();
            //Con esta linea podemos evitar que los usuarios ingresen texto en la comboBox
            boxHoras.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarDatosEnDataGridViem()
        {

            /*
            string cadenaConexion = "Data Source= DESKTOP-E4D98NB\\SQLEXPRESS;Initial Catalog=proyectoSocial;Integrated Security=True";
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

            gridDatosAd.DataSource = dataTable;
            gridDatosAd.Columns[1].Visible = false;
            gridDatosAd.Columns[2].Visible = false;
            */
        }

        private void gridDatosAd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}