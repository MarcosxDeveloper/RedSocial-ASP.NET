using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        [Required]
        [EmailAddress]
        public String Correo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Clave { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha_Registro { get; set; }
        
    }
}