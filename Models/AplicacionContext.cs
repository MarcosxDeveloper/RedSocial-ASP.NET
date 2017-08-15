using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Models
{
    public class AplicacionContext : DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }    
    }
}