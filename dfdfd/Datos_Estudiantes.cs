using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dfdfd.bdSocial;

namespace ProyectoSocial
{
    //He creado esto para poder crear el PDF
    public class Datos_Estudiantes: Datos_PDF
    {
        //Con esto puedo concatenar los datos del gridEstudiantes.
        public string carnet { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string TipoEstudio { get; set; }
        public string correo { get; set; }
        public string grupo { get; set; }
        public string estado { get; set; }
        public string telefono { get; set; }
        public string escuelaEs { get; set; }

        public string NombreCompleto
        {
            get { return $"Nombre completo del estudiante: {nombres} {apellidos}"; }
        }

        public string carnetNo
        {
            get { return $"Carnet N°: {carnet}"; }
        }

        public string telefonoEstudiante
        {
            get { return $"Teléfono: {telefono}"; }
        }

        public string EscuelaEstudiante
        {
            get { return $"Escuela de ITCA-FEPADE a la que pertenece: {escuelaEs}"; }
        }

        public string correoEstu
        {
            get { return $"Correo electrónico: {correo}"; }
        }

        public string carreraEstudiante
        {
            get { return $"Carrera que estudia: {TipoEstudio}"; }
        }

        public string titulo = "ESCUELA ESPECIALIZA EN INGENIERÍA ITCA-FEPADE ";
        public string subTitulo = "PROGRAMA DE SERVICIO SOCIAL ESTUDIANTIL";
        public string otroTitulo = "HOJA DE FINALIZACIÓN DEL SERVICIO SOCIAL ESTUDIANTIL";
        public string datosLlenar = "DATOS A LLENAR POR EL ESTUDIANTE";

        public string SedeEstudiante = "Sede donde estudia:   Santa Tecla: ____  Zacatecoluca: ____  San Miguel: ____  Santa Ana: ____  La Unión: ____";
        public string jornada = "Jornada:        Diurna: ____  Nocturna: ____  Virtual: ____";
        public string estudioYear = "Año de estudio:      Primero: ____   Segundo: ____ Tercero: ____  Otro: ____";



        public string tituloDos = "DATOS A LLENAR POR LA INSTITUCIÓN DONDE REALIZÓ";
        public string tituloTres = "EL SERVICIO SOCIAL ESTUDIANTIL";

        public string NombreInsti = "Nombre completo de la institución: _________________________________________";
        public string direccionInst = "Dirección: _______________________________________________________________";
        public string telefonoInst = "Teléfono: _________________________________________________________________";
        public string sitioWebInst = "Sitio Web: ________________________________________________________________";
        public string fechaInicio = "Fecha de Inicio: ___________________________________________________________";
        public string fechaFinal = "Fecha de finalización: ______________________________________________________";
        public string observaciones = "Observaciones: ______________________________________________________________________";
        public string f = "F. ___________________________________", s = "Sello ";
        public string nombreEnca = "Nombre: _______________________________________";
        public string desEnca = "Encargado de supervisar el Servicio Social en la institución.";
        public string f2 = "F. ___________________________________", s2 = "Sello ";
        public string nombreEncaDos = "Nombre: ____________________________________";
        public string desSSE = "Coordinador de SSE de Escuela Académica.";

    }
}

