﻿using dfdfd.bdSocial;
using Login;
using ProyectoSocial.bdSocial;
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
        ProyectoSocialContext context = new ProyectoSocialContext();

        public FrmDatosInicio()
        {
            InitializeComponent();
            //Con esta linea podemos evitar que los usuarios ingresen texto en la comboBox
            boxHoras.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#cd9013"), Color.White);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            eventosEnterLeave(btnBuscar, ColorTranslator.FromHtml("#b1201f"), Color.White);
        }
        public void eventosEnterLeave(Button btn, Color ColorFondo, Color ColorLetra)
        {
            btn.BackColor = ColorFondo;
            btn.ForeColor = ColorLetra;
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            if (compartir.Nivelusuario == 2)
            {
                MessageBox.Show("Acción no permitida, acción valida solo para estudiantes.", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtActividad.Text) || string.IsNullOrWhiteSpace(boxHoras.Text))
                {
                    MessageBox.Show("Por favor ingrese los datos solicitados", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    horasSociales datosTabla = new horasSociales();

                    datosTabla.Carnet = compartir.usuario.Carnet;
                    datosTabla.Fecha = dateTimePicker1.Value;
                    datosTabla.Actividad = txtActividad.Text;
                    datosTabla.Total = Convert.ToInt32(boxHoras.Text);
                    datosTabla.Grupo = compartir.usuario.Grupo;
                    context.Add(datosTabla);

                    if (context.SaveChanges() == 1)
                    {
                        MessageBox.Show("Registro guardado exitosamente", "ITCA FEPADE SS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtActividad.Text = null;
                        boxHoras.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Error Inesperado", "ITCA FEPADE SS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    int totalHoras = 0;
                    int horasRestantes = 0;
                    var consulta = context.horasSociales.Where(o => o.Carnet == compartir.carnetIngresado).Select(o => o.Total).ToList();
                    foreach (int calculando in consulta)
                    {
                        totalHoras += calculando;
                    }

                    if (compartir.usuario.TipoEstudio == "Técnico")
                    {
                        horasRestantes = 300 - totalHoras;
                    }
                    else
                    {
                        horasRestantes = 500 - totalHoras;
                    }

                    if (horasRestantes <= 0)
                    {
                        var modifcacionEstado = context.DatosAlumnos.FirstOrDefault(o => o.Carnet == compartir.carnetIngresado);
                        modifcacionEstado.Estado = "Terminado";
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}