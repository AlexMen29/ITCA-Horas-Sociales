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

        public string telefono { get; set; } = null!;

        public string emergencia { get; set; } = null!;

        public string coordinador { get; set; } = null!;

        public string institucion { get; set; } = null!;

        public string telefonoInstitucion { get; set; } = null!;

        public string actividades { get; set; } = null!;

        public string responsable { get; set; } = null!;

        public string correoResponsable { get; set; } = null!;

        public string telefonoResponsable { get; set; } = null!;

        public string tiempo { get; set; } = null!;

        public string fecha { get; set; } = null!;

        public string actividad1 { get; set; } = null!;

        public string objetivos1 { get; set; } = null!;

        public string metas1 { get; set; } = null!;

        public string duracion1 { get; set; } = null!;

        public string? actividad2 { get; set; }

        public string? metas2 { get; set; }

        public string? objetivos2 { get; set; }

        public string? duracion2 { get; set; }

        public string? lunesAM { get; set; }

        public string? lunesPM { get; set; }

        public string? martesAM { get; set; }

        public string? martesPM { get; set; }

        public string? miercolesAM { get; set; }

        public string? miercolesPM { get; set; }

        public string? juevesAM { get; set; }

        public string? juevesPM { get; set; }

        public string? viernesAM { get; set; }

        public string? viernesPM { get; set; }

    }
}