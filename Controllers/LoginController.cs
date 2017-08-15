using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Controllers
{
    public class LoginController : Controller
    {   
        public IActionResult Entrar()
        {
            return View();
        }
        public IActionResult Registrarse()
        {
            return View();
        }
        public ActionResult ButtonLogin(String correo, String clave)
        {
            var id = 0;
            var optionsBuilder = new DbContextOptionsBuilder<AplicacionContext>();
            using (var DB = new AplicacionContext(optionsBuilder.Options))
            {
                var user = DB.Usuarios.ToList();    
                foreach(var item in user) {
                    if (item.Correo == correo && item.Clave == clave){
                        id = item.UsuarioID;
                    }
                }  
            }
            return View(id);
        }
        public ActionResult ButtonSignUp(String nombre, String correo, String clave)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicacionContext>();
            using (var DB = new AplicacionContext(optionsBuilder.Options))
            {
                var user = new Usuario {
                    Correo = correo,
                    Clave = clave
                };
                var profile = new Perfil{
                    Nombre = nombre
                };
                DB.Add(user);
                DB.Add(profile);
                DB.SaveChanges(); 
                return RedirectToAction("Entrar", "Login");
            }
        }
    }
}