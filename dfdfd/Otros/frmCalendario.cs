using dfdfd.bdSocial;
using Login;
using ProyectoSocial.bdSocial;
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
            CargarDataGrid();
            fechasEventos();
            gridEventos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        public void CargarDataGrid()
        {
            gridEventos.DataSource = context.Eventos.Where(o => o.Grupo == compartir.usuario.Grupo).ToList();
        }

        //hace negritas las fechas del calendario si hay evento
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
            try
            {
                txtDescripcionME.Text = gridEventos.SelectedCells[2].Value.ToString();
                dateTimeME.Value = (DateTime)gridEventos.SelectedCells[1].Value;
                int idEvento = Convert.ToInt32(gridEventos.SelectedCells[0].Value);
                EventosITCA.itEvento = idEvento;
                txtDescripcionME.Focus();
                panelModificarEliminar.Visible = true;
            }
            catch
            {

            }
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart.Date;

            var evento = context.Eventos.FirstOrDefault(o => o.Fecha == fechaSeleccionada && o.Grupo == compartir.usuario.Grupo);

            if (evento != null)
            {

                var idEventos = context.Eventos.Where(o => o.Fecha == fechaSeleccionada && o.Grupo == compartir.usuario.Grupo).Select(o => o.Id).ToList();

                if (idEventos.Count > 0)
                {
                    foreach (var id in idEventos)
                    {
                        var ConsultaEventos = context.Eventos.FirstOrDefault(o => o.Id == id);
                        MessageBox.Show($"{ConsultaEventos.Mensaje}", "Eventos ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"{evento.Mensaje}", "Eventos ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();
            eventos.Mensaje = txtMensaje.Text;
            eventos.Fecha = dateTimeGuardar.Value;
            eventos.Grupo = compartir.usuario.Grupo;



            if (string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                MessageBox.Show("Por Favor, ingrese un mensaje", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Agregar = context.Eventos.FirstOrDefault(m => m.Mensaje == compartir.usuario.Grupo);

                context.Eventos.Add(eventos);
                if (context.SaveChanges() == 1)
                {
                    CargarDataGrid();
                    fechasEventos();
                    MessageBox.Show("Evento Agregado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error inesperado, no se ha podido modificar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();
            {
                if (string.IsNullOrWhiteSpace(txtDescripcionME.Text))
                {
                    MessageBox.Show("Por Favor, ingrese un mensaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Seguro que desea modificar el evento", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        var Modificar = context.Eventos.FirstOrDefault(m => m.Id == EventosITCA.itEvento);
                        Modificar.Mensaje = txtDescripcionME.Text;
                        Modificar.Fecha = dateTimeME.Value;
                        context.Eventos.Update(Modificar);
                        if (context.SaveChanges() == 1)
                        {
                            MessageBox.Show("Evento modificado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDataGrid();
                            fechasEventos();
                            panelModificarEliminar.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error inesperado, no se ha podido modificar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El evento no fue modificado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();
            eventos.Mensaje = txtDescripcionME.Text;


            {
                if (string.IsNullOrWhiteSpace(eventos.Mensaje))
                {
                    MessageBox.Show("Por Favor, ingrese un mensaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Seguro que desea eliminar el evento", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        var Eliminar = context.Eventos.FirstOrDefault(m => m.Id == EventosITCA.itEvento);
                        context.Eventos.Remove(Eliminar);
                        if (context.SaveChanges() == 1)
                        {
                            MessageBox.Show("Registro eliminado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDataGrid();
                            fechasEventos();
                            txtDescripcionME.Clear();
                            panelModificarEliminar.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error inesperado, no se ha podido eliminar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El evento no pudo ser eliminado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
    }
    public static class EventosITCA
    {
        public static int itEvento { get; set; }
    }

}
