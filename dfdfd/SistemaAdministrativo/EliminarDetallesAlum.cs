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
    public partial class EliminarDetallesAlum : Form
    {
        public EliminarDetallesAlum()
        {
            InitializeComponent();
            CargarDatosEnDataGridViem();
        }

        private void CargarDatosEnDataGridViem()
        {
            string cadenaConexion = "Data Source = DESKTOP-E4D98NB\\SQLEXPRESS; Initial Catalog = proyectoSocial; Integrated Security = True";
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

            dataGridEliminarModificar.DataSource = dataTable;
        }

        private void EliminarDetallesAlum_Load(object sender, EventArgs e)
        {

        }


        private void True(object sender, ScrollEventArgs e)
        {

        }

        private void pnlInfoEliDetAd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string carnet = txtBoxCarnetCap.Text;
                string cadenaConexion = "Data Source = DESKTOP-E4D98NB\\SQLEXPRESS; Initial Catalog = proyectoSocial; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    string Consulta = "DELETE FROM dbo.DatosAlumnos WHERE Carnet = @Carnet";

                    using (SqlCommand command = new SqlCommand(Consulta, connection))
                    {
                        command.Parameters.AddWithValue("@Carnet", carnet);
                        command.ExecuteNonQuery();
                    }
                }
                LimpiarTextBox();
                MessageBox.Show("Datos eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no han sido eliminados.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string nuevoNombres = txtBoxNombresCap.Text;
                string nuevoApellidos = txtBoxApellidosCap.Text;
                //Me falta más campos


                string carnet = txtBoxCarnetCap.Text;
                //Más obtención de datos

                //Realizo la modificación en la BD:

                string cadenaConexion = "Data Source = DESKTOP-E4D98NB\\SQLEXPRESS; Initial Catalog = proyectoSocial; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    // Corrección de la consulta SQL
                    string consulta = "UPDATE dbo.DatosAlumnos SET Nombres = @Nombres, Apellidos = @Apellidos WHERE CARNET = @Carnet";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@Nombres", nuevoNombres);
                        command.Parameters.AddWithValue("@Apellidos", nuevoApellidos);
                        command.Parameters.AddWithValue("@Carnet", carnet);
                        // Me faltan parámetros para otros campos aquí

                        command.ExecuteNonQuery();
                    }
                }

                LimpiarTextBox();
                MessageBox.Show("Datos modificados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos no han sido modificados.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridEliminarModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridEliminarModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridEliminarModificar.Rows[e.RowIndex];
                txtBoxCarnetCap.Text = selectedRow.Cells["carnet"].Value.ToString();
                txtBoxNombresCap.Text = selectedRow.Cells["nombres"].Value.ToString();
                txtBoxApellidosCap.Text = selectedRow.Cells["apellidos"].Value.ToString();

                
            }
        }

        private void LimpiarTextBox()
        {
            txtBoxCarnetCap.Text = "";
            txtBoxNombresCap.Text = "";
            txtBoxApellidosCap.Text = "";
            txtBoxCarreraCap.Text = "";
            txtBoxCorreoCap.Text = "";
            txtBoxTelAlumCap.Text = "";
            txtBoxCoorSSECap.Text = "";
            txtBoxTelEmergCap.Text = "";
            txtBoxConctEmergCap.Text = "";
            txtBoxNombreInstCap.Text = "";
            txtBoxTelInstCap.Text = "";
            txtBoxActivReaCap.Text = "";
            txtBoxResponsableCap.Text = "";
            txtBoxCorreoResponCap.Text = "";
            txtBoxTiempoCap.Text = "";
            txtBoxInicioSSCap.Text = "";
            txtBoxObjetivosCap.Text = "";
            txtBoxMetasCap.Text = "";
            txtBoxDuracionCap.Text = "";
        }
    }
}
