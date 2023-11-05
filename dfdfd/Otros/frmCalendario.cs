using dfdfd.bdSocial;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSocial.Otros
{
    public partial class frmCalendario : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();


        public frmCalendario()
        {
            InitializeComponent();
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            // Para fijar la barra divisoria del SplitContainer
            splitContainer1.IsSplitterFixed = true;
            gridEventos.DataSource = context.Eventos.Where(o => o.Grupo == compartir.usuario.Grupo).ToList();
            fechasEventos();
            gridEventos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


        }

        private void fechasEventos()
        {
            var fechasEventos = context.Eventos.Where(o => o.Grupo == compartir.usuario.Grupo).Select(o => o.Fecha);

            foreach (var fecha in fechasEventos)
            {
                monthCalendar1.AddBoldedDate(fecha);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void gridEventos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcionME.Text = gridEventos.SelectedCells[2].Value.ToString();
            dataTimeFechaME.Value = (DateTime)gridEventos.SelectedCells[1].Value;
            txtDescripcionME.Focus();
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart.Date;

            var evento = context.Eventos.FirstOrDefault(o => o.Fecha == fechaSeleccionada);

            if (evento != null)
            {
                MessageBox.Show($"{evento.Mensaje}", "Eventos ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
