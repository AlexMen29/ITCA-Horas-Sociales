using System.ComponentModel.DataAnnotations;

namespace dfdfd.bdSocial
{
    public class tbDatosRegistro
    {
        public string nombre { get; set; } = null!;
        [Key]
        public string carnet { get; set; } = null!;

        public string escuela { get; set; } = null!;

        public string año { get; set; } = null!;

        public string carrera { get; set; } = null!;

        public string correo { get; set; } = null!;

        public int telefono { get; set; }

        public string emergencia { get; set; } = null!;

        public int telefonoEmergencia { get; set; }

        public string coordinador { get; set; } = null!;

        public string institucion { get; set; } = null!;

        public int telefonoInstitucion { get; set; }

        public string actividades { get; set; } = null!;

        public string responsable { get; set; } = null!;

        public string correoResponsable { get; set; } = null!;

        public int telefonoResponsable { get; set; }

        public int tiempo { get; set; }

        public DateTime fecha { get; set; }

        public string actividad1 { get; set; } = null!;

        public string objetivos1 { get; set; } = null!;

        public string metas1 { get; set; } = null!;

        public string duracion1 { get; set; } = null!;

        public string? actividad2 { get; set; }

        public string? metas2 { get; set; }

        public string? objetivos2 { get; set; }

        public string? duracion2 { get; set; }

        public string? lunes { get; set; }

        public string? martes { get; set; }

        public string? miercoles { get; set; }

        public string? jueves { get; set; }

        public string? viernes { get; set; }

        public string? sabado { get; set; }

        public string? domingo { get; set; }

    }
}