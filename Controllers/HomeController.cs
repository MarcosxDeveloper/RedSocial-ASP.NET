using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Perfil(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicacionContext>();
            using (var DB = new AplicacionContext(optionsBuilder.Options))
            {
                var perfil = DB.Usuarios.Where( u => u.UsuarioID == id).ToList();
                return View(perfil);
            }
        }
        public ActionResult Amigos(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicacionContext>();
            using (var DB = new AplicacionContext(optionsBuilder.Options))
            {
                var amigos = DB.Amigos.Where( a => a.AmigoID == id).ToList();    
                return View(amigos);
            }
        }
        public ActionResult Publicaciones(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicacionContext>();
            using (var DB = new AplicacionContext(optionsBuilder.Options))
            {
                var publicaciones = DB.Publicaciones.Where( p => p.PublicacionID == id).ToList();    
                return View(publicaciones);
            }
        }
        public ActionResult Mensajes(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicacionContext>();
            using (var DB = new AplicacionContext(optionsBuilder.Options))
            {
                var mensajes = DB.Mensajes.Where( m => m.MensajeID == id).ToList();    
                return View(mensajes);
            }
        }
        public ActionResult Notificaciones(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicacionContext>();
            using (var DB = new AplicacionContext(optionsBuilder.Options))
            {
                var notificaciones = DB.Notificaciones.Where( n => n.NotificacionID == id).ToList();    
                return View(notificaciones);
            }
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
