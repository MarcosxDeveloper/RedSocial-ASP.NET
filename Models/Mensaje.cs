using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models
{
    public class Mensaje
    {
        [Key]
        public int MensajeID { get; set; }
        public int UsuarioID { get; set; }
        public int AmigoID { get; set; }
        [Required]
        public String Contenido { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Mensaje { get; set; }
        public Usuario Usuario { get; set; }
    }
}