using dfdfd.bdSocial;
using Login;
using Microsoft.VisualBasic;
using ProyectoSocial;
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

        ProyectoSocialContext context = new ProyectoSocialContext();
        public FrmDetallesAd()
        {
            InitializeComponent();

        }

        private void CargarDatosEnDataGridViem(int nivel, string carnet)
        {
            if (nivel == 1)
            {

                // Filtrar los datos por el carnet especificado
                var datosAlumno = context.horasSociales.Where(h => h.Carnet == carnet).ToList();
                gridDatosAlumnos.DataSource = datosAlumno;


                if (compartir.Nivelusuario == 1)
                {
                    gridDatosAlumnos.Columns[0].Visible = false;
                    gridDatosAlumnos.Columns[1].Visible = false;
                }
                totalHoras();

            }
            else
            {
                var datosAlumno = context.horasSociales.Where(h => h.Grupo == compartir.usuario.Grupo).ToList();

                gridDatosAlumnos.DataSource = datosAlumno;
                gridDatosAlumnos.Columns[0].Visible = false;



            }

        }

        private void FrmDetallesAd_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridViem(compartir.Nivelusuario, compartir.carnetIngresado);

            if (compartir.Nivelusuario == 1)
            {
                PanelElementosBusqueda.Visible = false;
                panelDetallesAlumnos.Visible = false;
                if (compartir.usuario.TipoEstudio == "Técnico")
                {
                    int horasRestantes = 300 - int.Parse(LabTotalHoras.Text);
                    LabHorasRestantes.Text = horasRestantes.ToString();
                }
                else
                {
                    int horasRestantes = 500 - int.Parse(LabTotalHoras.Text);
                    LabHorasRestantes.Text = horasRestantes.ToString();
                }

                if (compartir.usuario.Estado == "En Proceso")
                {
                    btnEstado.Text = "En Proceso";
                }
                else
                {
                    btnEstado.Text = "Terminado";
                    btnEstado.BackColor = Color.Green;
                }
                var consulta = context.horasSociales.Where(o => o.Carnet == compartir.carnetIngresado).Count();

                if (consulta < 1)
                {
                    MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nActualmente, no has registrado horas de tu servicio social. Te invitamos a comenzar lo antes posible con el fin de culminar de manera satisfactoria tu servicio social." +
                        $" ¡Inicia el registro ahora para asegurar un proceso exitoso! ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                var consulta = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).Count();
                if (consulta < 1)
                {
                    MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nActualmente, no tienes estudiantes asignados a tu grupo, por lo que las funcionalidades del sistema se encuentran inactivas." +
                        $" Para aprovechar al máximo las características del sistema, asigna estudiantes a tu grupo: {compartir.usuario.Grupo} ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            gridDatosAlumnos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LabCarnet.Text = "";
            txtBuscar.Text = null;
            LabNombre.Text = "";
            LabApellido.Text = "";
            LabCorreo.Text = "";
            LabActivoDesde.Text = "";
            LabUltimoServicio.Text = "";
            LabTotalHoras.Text = "";
            LabHorasRestantes.Text = "";
            btnEstado.Text = "¿?";
            btnEstado.BackColor = Color.Yellow;
            comboFiltra.SelectedIndex = 2;

            CargarDatosEnDataGridViem(2, compartir.carnetIngresado);

        }

        //Metodo para Eventos mouse enter y leave
        public void eventosEnterLeave(Button btn, Color ColorFondo, Color ColorLetra)
        {
            btn.BackColor = ColorFondo;
            btn.ForeColor = ColorLetra;
        }

        private void btnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnLimpiar, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnLimpiar, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void gridDatosAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBuscar.Text = gridDatosAlumnos.SelectedCells[1].Value.ToString();
            }
            catch
            {

            }
        }


        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaAlumnos = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo).Select(o => o.Carnet).ToList();

            bool encontrado = false;
            for (int indice = 0; indice < listaAlumnos.Count; indice++)
            {


                if (txtBuscar.Text == listaAlumnos[indice])
                {
                    CargarDatosEnDataGridViem(1, txtBuscar.Text);
                    totalHoras();

                    var usuario = context.DatosAlumnos.FirstOrDefault(u => u.Carnet == txtBuscar.Text);
                    LabCarnet.Text = txtBuscar.Text;
                    LabNombre.Text = usuario.Nombres;
                    LabApellido.Text = usuario.Apellidos;
                    LabCorreo.Text = usuario.Correo;


                    var usuarioF = context.horasSociales.Where(u => u.Carnet == txtBuscar.Text).Select(u => u.Fecha).ToList();
                    LabActivoDesde.Text = (usuarioF[0].ToString()).Substring(0, 10);
                    LabUltimoServicio.Text = (usuarioF[usuarioF.Count - 1].ToString().Substring(0, 10));
                    if (usuario.TipoEstudio == "Técnico")
                    {
                        int horasRestantes = 300 - int.Parse(LabTotalHoras.Text);
                        LabHorasRestantes.Text = horasRestantes.ToString();
                    }
                    else
                    {
                        int horasRestantes = 500 - int.Parse(LabTotalHoras.Text);
                        LabHorasRestantes.Text = horasRestantes.ToString();
                    }
                    if (usuario.Estado == "En Proceso")
                    {
                        btnEstado.Text = "En Proceso";
                    }
                    else
                    {
                        btnEstado.Text = "Terminado";
                        btnEstado.BackColor = Color.Green;
                    }
                    break;
                }
                if (encontrado == false && indice == listaAlumnos.Count - 1)
                {
                    MessageBox.Show("El carnet ingresado no fue encontrado", "ITCA FEPADE SS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtBuscar.Clear();
                }
                if (encontrado == true)
                {
                    break;
                }
            }

        }


        public void totalHoras()
        {
            int totalHoras = 0;
            foreach (DataGridViewRow fila in gridDatosAlumnos.Rows)
            {
                totalHoras += Convert.ToInt32(fila.Cells["Total"].Value);
            }
            LabTotalHoras.Text = totalHoras.ToString();
        }

        private void panelDetallesAlumnos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (comboFiltra.Text == "Descendente")
                {
                    var datosOrdenados = context.horasSociales.Where(o => o.Grupo == compartir.usuario.Grupo).OrderByDescending(h => h.Fecha).ToList();
                    gridDatosAlumnos.DataSource = datosOrdenados;
                }
                if (comboFiltra.Text == "Ascendente")
                {
                    var datosOrdenados = context.horasSociales.Where(o => o.Grupo == compartir.usuario.Grupo).OrderBy(h => h.Fecha).ToList();
                    gridDatosAlumnos.DataSource = datosOrdenados;
                }
            }
            else
            {
                if (comboFiltra.Text == "Descendente")
                {
                    var datosOrdenados = context.horasSociales.Where(o => o.Grupo == compartir.usuario.Grupo && o.Carnet == txtBuscar.Text).OrderByDescending(h => h.Fecha).ToList();
                    if (datosOrdenados.Count > 0)
                    {
                        gridDatosAlumnos.DataSource = datosOrdenados;
                    }
                    else
                    {
                        MessageBox.Show("Carnet Invalido", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (comboFiltra.Text == "Ascendente")
                {
                    var datosOrdenados = context.horasSociales.Where(o => o.Grupo == compartir.usuario.Grupo && o.Carnet == txtBuscar.Text).OrderBy(h => h.Fecha).ToList();
                    if (datosOrdenados.Count > 0)
                    {
                        gridDatosAlumnos.DataSource = datosOrdenados;
                    }
                    else
                    {
                        MessageBox.Show("Carnet Invalido", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (compartir.Nivelusuario == 1)
            {
                if (btnEstado.Text == "En Proceso")
                {
                    MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nLe informamos que su estado se encuentra actualmente en proceso." +
                        $" Le invitamos a continuar llevando a cabo su servicio social de manera excelente para que pueda culminar " +
                        $"satisfactoriamente en el menor tiempo posible.", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (btnEstado.Text == "Terminado")
                {
                    MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\n¡Felicitaciones! Nos complace informarle que su servicio social ha sido completado con éxito. " +
                        $"Le solicitamos presentarse o comunicarse con su encargado {compartir.usuario.Encargado} para recibir su hoja de finalización y" +
                        $" formalizar los detalles de su logro.\nAgradecemos su dedicación y esfuerzo durante este proceso.", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnFiltrar_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnFiltrar, ColorTranslator.FromHtml("#cd9013"), Color.White);

        }

        private void btnFiltrar_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnFiltrar, ColorTranslator.FromHtml("#b1201f"), Color.White);

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
        }
    }
}
