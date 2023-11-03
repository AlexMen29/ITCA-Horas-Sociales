using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoSocial.bdSocial
{
    public class horasSociales
    {
        [Key]
        public int Id { get; set; } 
        public string Carnet { get; set; } = null!;
        public DateTime Fecha { get; set; } 
        public string Actividad { get; set; } = null!;
        public int Total { get; set; }
        public string Grupo { get; set; } = null!;

    }
}
