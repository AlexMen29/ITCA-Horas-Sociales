using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using dfdfd.bdSocial;
using iTextSharp.text.xml;
using Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSocial
{
    //He creado esto para poder crear el PDF
    public class Datos_Estudiantes : Datos_PDF
    {
        //Con esto puedo concatenar los datos del gridEstudiantes.
        public string carnet { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string TipoEstudio { get; set; }
        public string correo { get; set; }
        public string grupo { get; set; }
        public string estado { get; set; }
        public string telefonoEs { get; set; }
        public string escuelaEs { get; set; }
        public string coordinador { get; set; }
        public string institucionName { get; set; }
        public int telefonoInstitucion { get; set; }
        public string responsable { get; set; }
        public static int tiempo { get; set; }
        public string estudioAño { get; set; }
        public string direInst { get; set; }
        public string fechaInicioSer { get; set; }
        public string fechaFinalSer { get; set; }

        public string NombreCompleto
        {
            get { return $"Nombre completo del estudiante: {nombres} {apellidos}"; }
        }

        public string carnetNo
        {
            get { return $"Carnet N°: {carnet}"; }
        }

        public string TelefonoEstudiante
        {
            get { return $"Teléfono: {telefonoEs}"; }
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

        public string NombreInsti
        {
            get { return $"Nombre completo de la institución: {institucionName}"; }
        }

        public string SedeEstudiante
        {
            get { return $"Sede donde estudia: Santa Tecla: ____  Zacatecoluca: ____  San Miguel: ____  Santa Ana: ____  La Unión: ____"; }
        }

        public string jornada
        {
            get { return $"Jornada: Diurna: ____  Nocturna: ____  Virtual: ____"; }
        }

        public string estudioYear
        {
            get { return $"Año de estudio: {estudioAño}"; }
        }

        public string titulo = "ESCUELA ESPECIALIZA EN INGENIERÍA ITCA-FEPADE ";
        public string subTitulo = "PROGRAMA DE SERVICIO SOCIAL ESTUDIANTIL";
        public string otroTitulo = "HOJA DE FINALIZACIÓN DEL SERVICIO SOCIAL ESTUDIANTIL";
        public string datosLlenar = "DATOS A LLENAR POR EL ESTUDIANTE";

        public string tituloDos = "DATOS A LLENAR POR LA INSTITUCIÓN DONDE REALIZÓ";
        public string tituloTres = "EL SERVICIO SOCIAL ESTUDIANTIL";

        public string direccionInst
        {
            get { return $"Dirección: ____________________________________ "; }
        }

        public string telefonoInst
        {
            get { return $"Teléfono: {telefonoInstitucion}"; }
        }

        public string sitioWebInst
        {
            get { return $"Sitio Web: www.itca.edu.sv."; }
        }

        public string fechaInicio
        {
            get { return $"Fecha de Inicio: {fechaInicioSer}"; }
        }

        public string fechaFinal
        {
            get { return $"Fecha de finalización: {fechaFinalSer}"; }
        }

        public string observaciones
        {
            get { return $"Observaciones: ________________________________________________________"; }
        }

        public string f = "F. ___________________________________", s = "Sello ";

        public string nombreEnca
        {
            get { return $"Nombre: {coordinador}"; }
        }
        public string desEnca = "Encargado de supervisar el Servicio Social en la institución.";
        public string f2 = "F. ___________________________________", s2 = "Sello ";

        public string nombreEncaDos
        {
            get { return $"Nombre: {responsable}"; }
        }
        public string desSSE = "Coordinador de SSE de Escuela Académica.";

    }
}

