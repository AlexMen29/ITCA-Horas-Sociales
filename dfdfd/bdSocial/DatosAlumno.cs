using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dfdfd.bdSocial;

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

    public string Estado { get; set;}
    public int HorasTotal { get; set; }

}
