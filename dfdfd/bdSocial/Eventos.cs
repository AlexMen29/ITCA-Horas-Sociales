using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoSocial.bdSocial
{
    public class Eventos
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; } 
        public string Mensaje { get; set; } = null!;
        public string Grupo { get; set; } = null!;
 

    }
}
