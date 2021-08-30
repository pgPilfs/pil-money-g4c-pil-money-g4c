using APPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPO.Controllers
{
    public class UsuariosController : Controller
    {
        APPOEntities db = new APPOEntities();
        // GET: Usuarios
        public ActionResult Index()
        {
            List<Usuarios> listaUsuarios = db.Usuarios.ToList();
            return View(listaUsuarios);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(Usuarios oUsuario)
        {
            db.Usuarios.Add(oUsuario);
            db.SaveChanges();
            return View();
        }

        public ActionResult Modificar(int id)
        {
            Usuarios oUsuario = db.Usuarios.Where(a => a.dni == id).FirstOrDefault();
            return View(oUsuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modificar(Usuarios oUsuarios)
        {
            Usuarios registroViejo = db.Usuarios.Find(oUsuarios.dni);
            registroViejo.nombre = oUsuarios.nombre;
            registroViejo.apellido = oUsuarios.apellido;
            registroViejo.foto_dni_frente = oUsuarios.foto_dni_frente;
            registroViejo.foto_dni_dorso = oUsuarios.foto_dni_dorso;
            registroViejo.mail = oUsuarios.mail;
            registroViejo.password = oUsuarios.password;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetallesUsuarios(int id)
        {
            Usuarios usuario = db.Usuarios.Find(id);
            return View(usuario);
        }

        public ActionResult Eliminar(int id)
        {
            Usuarios usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}