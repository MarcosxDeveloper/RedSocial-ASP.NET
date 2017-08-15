using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Perfil
    {
        [Key]
        public int PerfilID { get; set; }
        public int UsuarioID { get; set; }
        public String Foto { get; set; }
        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(10)]
        public String Sexo { get; set; }
        [Required]
        [StringLength(10)]
        public String Telefono { get; set; }
        [Required]
        [StringLength(20)]
        public String Direccion { get; set; }
        [Required]
        [StringLength(20)]
        public String Escuela { get; set; }
        [Required]
        [StringLength(20)]
        public String Trabajo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public String Fecha_Nacimiento { get; set; }
        public Usuario Usuario { get; set; }
    }
}