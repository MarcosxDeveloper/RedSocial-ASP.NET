using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models
{
    public class Notificacion
    {
        [Key]
        public int NotificacionID { get; set; }
        public int UsuarioID { get; set; }
        [Required]
        public String Contenido { get; set; }
        [DataType(DataType.Date)]
        public String Fecha_Notificacion { get; set; }
        public Usuario Usuario { get; set; }
    }
}