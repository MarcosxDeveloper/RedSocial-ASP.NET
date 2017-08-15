using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models
{
    public class Amigo
    {
        [Key]
        public int AmistadID { get; set; }
        public int UsuarioID { get; set; }
        public int AmigoID { get; set; }
        [Required]
        public int Estado { get; set; }
        public Usuario Usuario { get; set; }
    }
}