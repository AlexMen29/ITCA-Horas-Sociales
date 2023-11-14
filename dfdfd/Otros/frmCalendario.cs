﻿using dfdfd.bdSocial;
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
            int idEvento = Convert.ToInt32(gridEventos.SelectedCells[0].Value);
            EventosITCA.itEvento = idEvento;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Eventos eventos = new Eventos();
            eventos.Mensaje = txtMensaje.Text;
            eventos.Fecha = dateTimePicker1.Value;
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
            eventos.Mensaje = txtDescripcionME.Text;

            var cantidad = context.Eventos.Where(m => m.Grupo == compartir.usuario.Grupo).Count();
            if (cantidad < 1)
            {
                MessageBox.Show("No hay ningun evento programado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(eventos.Mensaje))
                {
                    MessageBox.Show("Por Favor, ingrese un mensaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Seguro que desea modificar el evento", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        var Modificar = context.Eventos.FirstOrDefault(m => m.Id == EventosITCA.itEvento);
                        Modificar.Mensaje = txtDescripcionME.Text;
                        context.Eventos.Update(Modificar);
                        if (context.SaveChanges() == 1)
                        {
                            MessageBox.Show("Evento modificado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDataGrid();
                            fechasEventos();

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

            var cantidad = context.Eventos.Where(m => m.Grupo == compartir.usuario.Grupo).Count();
            if (cantidad < 1)
            {
                MessageBox.Show("No hay ningun evento programado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
                        }
                        else
                        {
                            MessageBox.Show("Error inesperado, no se ha podido eliminar", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El evento no fue eliminado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public static class EventosITCA
    {
        public static int itEvento { get; set; }
    }

}
