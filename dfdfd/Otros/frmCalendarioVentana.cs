using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dfdfd.bdSocial;
using Login;
using ProyectoSocial.bdSocial;

namespace ProyectoSocial.Otros
{
    public partial class frmCalendarioVentana : Form
    {
        ProyectoSocialContext context = new ProyectoSocialContext();
        public frmCalendarioVentana()
        {
            InitializeComponent();
        }

        private void frmCalendarioVentana_Load(object sender, EventArgs e)
        {
            cargarEvento();
        }

        private void cargarEvento()
        {
            var eventosBase = context.Eventos.Where(d=>d.Grupo==compartir.usuario.Grupo).Select(o => o.Fecha).ToList();

            foreach (var evento in eventosBase)
            {
                monthCalendar1.AddBoldedDate(evento);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSelecicionda = monthCalendar1.SelectionStart.Date;

            var consulta = context.Eventos.FirstOrDefault(o=>o.Fecha==fechaSelecicionda);
            if (consulta!=null) 
            {
                string mensaje = consulta.Mensaje;
                MessageBox.Show($"{mensaje}","Eventos ITCA FEPADE SS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            

        }
    }
}
