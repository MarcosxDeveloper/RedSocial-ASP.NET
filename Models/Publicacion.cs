using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models
{
    public class Publicacion
    {
        [Key]
        public int PublicacionID { get; set; }
        public int UsuarioID { get; set; }
        [Required]
        public String Contenido { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Publicacion { get; set; }
        public Usuario Usuario { get; set; }
    }
}