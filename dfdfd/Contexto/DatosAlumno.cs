using System;
using System.Collections.Generic;

namespace ProyectoSocial.Contexto;

public partial class DatosAlumno
{
    public string Carnet { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public int NivelUsuario { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Encargado { get; set; } = null!;

    public string TipoEstudio { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Grupo { get; set; } = null!;
}
