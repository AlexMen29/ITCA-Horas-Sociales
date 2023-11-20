using dfdfd.bdSocial;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.IO.Font;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoSocial.SistemaAdministrativo
{
    public partial class frmEstudiantes : Form
    {
        //Crearé la ruta para guardar el reporte:
        
        ProyectoSocialContext context = new ProyectoSocialContext();

        public frmEstudiantes()
        {
            InitializeComponent(); //formulario y se encarga de inicializar y configurar todos los componentes visuales y no visuales que agregados al formulario.
            gridEstudiantes.CellFormatting += gridEstudiantes_CellFormatting;
            //El evento CellFormatting se dispara cuando se formatea una celda en un control DataGridView. 
            //Útil para personalizar la apariencia o el contenido de una celda antes de que se muestre en la pantalla.
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            //Se hace  una consulta segúne el contexto de la base de datos tomando como argumento el grupo y el nivel de usuario que es 1 que 
            //representa a los "Estudiante".
            var consulta = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).Count();
            if (consulta < 1) //Si no hay datos, entonces se muestra un mensaje de aviso que no tiene estudiantes registrados en su GRUPO.
            {
                MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nActualmente, no tienes estudiantes asignados a tu grupo, por lo que las funcionalidades del sistema se encuentran inactivas." +
                    $" Para aprovechar al máximo las características del sistema, asigna estudiantes a tu grupo: {compartir.usuario.Grupo} ", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        public void CargarDataGrid()
        {
            var consulta = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.Encargado != "null").ToList();
            gridEstudiantes.DataSource = consulta;

            gridEstudiantes.Columns[1].Visible = false; //Columna de la Contraseña
            gridEstudiantes.Columns[2].Visible = false; //Columna del Nivel de usuario
            gridEstudiantes.Columns[5].Visible = false; //Columna del Encargado
            LabEstudiantes.Text = consulta.Count.ToString();
            //Carga el grid con los datos que cumplen con estos requisitos.


        }

        private void gridEstudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                string valorCelda = e.Value.ToString();
                // Comparar el valor de la celda y establecer el color
                if (valorCelda.Equals("Terminado", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Green;
                    e.CellStyle.ForeColor = System.Drawing.Color.White;
                }
                else if (valorCelda.Equals("En Proceso", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                    e.CellStyle.ForeColor = System.Drawing.Color.Black;

                }

            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEliminar.Text))
            {
                MessageBox.Show("Por Favor, ingrese un carnet", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var listaDeAlumnos = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).Select(o => o.Carnet).ToList();

                for (int indice = 0; indice < listaDeAlumnos.Count; indice++)
                {
                    bool encontrado = false;
                    //si se encuentra el carntet ingresado
                    if (txtEliminar.Text == listaDeAlumnos[indice])
                    {
                        var Eliminar = context.DatosAlumnos.FirstOrDefault(o => o.Carnet == txtEliminar.Text);

                        if (MessageBox.Show($"¿Seguro que desea eliminar al estudiante {Eliminar.Nombres + " " + Eliminar.Apellidos + " con el carnet " + Eliminar.Carnet}? Esta acción no se puede revertir", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            // Eliminar registros en la tabla horasSociales relacionados con el Carnet
                            var registrosHorasSociales = context.horasSociales.Where(o => o.Carnet == txtEliminar.Text).ToList();
                            context.horasSociales.RemoveRange(registrosHorasSociales);
                            //elimina registros de la tabla de tbregistros
                            var tbRegistro = context.tbDatosRegistro.FirstOrDefault(o => o.carnet == txtEliminar.Text);
                            context.tbDatosRegistro.Remove(tbRegistro);


                            context.DatosAlumnos.Remove(Eliminar);

                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Estudiante eliminado", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarDataGrid();
                                txtEliminar.Text = null;
                                CargarDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("Error inesperado, no se ha podido eliminar correctamente", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        encontrado = true;

                    }
                    if (encontrado == false && indice == listaDeAlumnos.Count - 1) //Si el carnet no existe en la base de datos
                    {
                        MessageBox.Show("El carnet ingresado es invalido", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (encontrado == true)
                    {
                        break;
                    }

                }




            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //lista de alumnos de docente actual
            var listaDeAlumnos = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).Select(o => o.Carnet).ToList();

            for (int indice = 0; indice < listaDeAlumnos.Count; indice++)
            {
                bool encontrado = false;
                //si se encuentra el carntet ingresado
                if (txtBuscar.Text == listaDeAlumnos[indice])
                {
                    //verificamos si usuario ya termino su servicio social
                    var consulta = context.DatosAlumnos.Where(o => o.Carnet == txtBuscar.Text && o.Estado == "Terminado").Count();
                    //datos de usuario seleccionado
                    var usuario = context.DatosAlumnos.FirstOrDefault(o => o.Carnet == txtBuscar.Text);
                    if (consulta > 0)
                    {
                        if (MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nEsta apunto de imprimir la hoja social de: {usuario.Nombres + " " + usuario.Apellidos}. ", "ITCA FEPADE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            if (gridEstudiantes.SelectedRows.Count > 0)
                            {
                                // Obtener la fila seleccionada
                                DataGridViewRow selectedRow = gridEstudiantes.SelectedRows[0];
                                string carnet = selectedRow.Cells[0].Value.ToString();
                                var datosRegistro = context.tbDatosRegistro.FirstOrDefault(d => d.carnet == carnet);
                                Datos_Estudiantes datos_Estudiantes = new Datos_Estudiantes
                                {
                                   //Los datos de la base de datos que le darán valor a las variables en la Clase "Datos_Estudiantes".
                                    logo_itca = logoITCA.Image,
                                    carnet = selectedRow.Cells[0].Value.ToString(),
                                    nombres = selectedRow.Cells[3].Value.ToString(),
                                    apellidos = selectedRow.Cells[4].Value.ToString(),
                                    TipoEstudio = selectedRow.Cells[6].Value.ToString(),
                                    correo = selectedRow.Cells[7].Value.ToString(),
                                    grupo = selectedRow.Cells[8].Value.ToString(),
                                    estado = selectedRow.Cells[9].Value.ToString(),
                                };
                                if (datosRegistro != null) //Conexión a la base de datos "datosRegistro" para poder imprimir los datos
                                    //de la clase "Datos_Estudiantes" y poder imprimir el reporte con los datos ingresados.
                                {
                                    datos_Estudiantes.estudioAño = datosRegistro.año;
                                    datos_Estudiantes.escuelaEs = datosRegistro.escuela;
                                    datos_Estudiantes.telefonoEs = datosRegistro.telefono.ToString();
                                    datos_Estudiantes.institucionName = datosRegistro.institucion;
                                    datos_Estudiantes.responsable = datosRegistro.coordinador;
                                    datos_Estudiantes.telefonoInstitucion = datosRegistro.telefonoInstitucion;
                                    datos_Estudiantes.coordinador = datosRegistro.coordinador;
                                    datos_Estudiantes.responsable = datosRegistro.responsable;
                                    datos_Estudiantes.fechaInicioSer = datosRegistro.fecha.ToLongDateString();
                                    datos_Estudiantes.fechaFinalSer = datosRegistro.fecha.ToLongDateString();
                                }
                                Procesar_PDF pdf = new Procesar_PDF(); //Al cumplirlo, se imprimirá los datos en el reporte.
                                pdf.crearPdf(datos_Estudiantes, gridEstudiantes); //También se imprime los datos de la clase y el gridEstudiantes
                            }
                            else //Primero debe seleccionar una fila de los datos para poder imprimir el reporte del estudiante.
                            {
                                MessageBox.Show("Por favor, seleccione una fila antes de generar el informe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else //Si el estudiante no tienen las 300 o 500 horas de su SSE, no se podrá imprimir su reporte de SSE. 
                    {
                        MessageBox.Show($"Estimado/a {compartir.usuario.Nombres}\nno puede  imprimir la hoja social de {usuario.Nombres + " " + usuario.Apellidos}, actualmente tiene realizadas {usuario.HorasTotal} horas sociales siendo su tipo de estudio de {usuario.TipoEstudio}", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    encontrado = true;
                }

                if (encontrado == false && indice == listaDeAlumnos.Count - 1) //Si el carnet no se encuentra en la BD, entonces se muestra el siguiente mensaje:
                {
                    MessageBox.Show("El carnet ingresado es invalido", "ITCA FEPADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (encontrado == true)
                {
                    break;
                }

            }




        }

        private void gridEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscar.Text = gridEstudiantes.SelectedCells[0].Value.ToString();
            //Hace que al dar clic en el grid, se seleccione por defecto el priemr valor, en este caso, el número de Carnet
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboFiltra.Text == "MaxHoras") //Permite ordenar de forma numérica del valor más alto, en este caso, las horas de los estudiantes.
            {
                gridEstudiantes.DataSource = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).OrderByDescending(o => o.HorasTotal).ToList();


            }
            else if (comboFiltra.Text == "MinHoras") //Permite ordenar de forma numérica del valor más bajo, en este caso, las horas de los estudiantes.
            {
                gridEstudiantes.DataSource = context.DatosAlumnos.Where(o => o.Grupo == compartir.usuario.Grupo && o.NivelUsuario == 1).OrderBy(o => o.HorasTotal).ToList();

            }
        }

        private void logoITCA_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
            //Precisa la verificación de que no se haya ingresado un numéro.
            //También verifica que la tecla fue manejada y no se procesará más
        }

        private void txtEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            compartir.ValidacionNumerica(sender, e);
            //Precisa la verificación de que no se haya ingresado un numéro.
            //También verifica que la tecla fue manejada y no se procesará más
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = null;
            //Borrará sin consecuencia el botónd de limpiar sin afectar la base de datos.
        }
    }
}
