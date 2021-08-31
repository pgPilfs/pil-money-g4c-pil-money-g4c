using APPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPO.Controllers
{
    public class ServiciosController : Controller
    {
    APPOEntities db = new APPOEntities();
    // GET: Servicios
    public ActionResult Index()
    {
      List<Servicios> listaServicios = db.Servicios.ToList();
      return View(listaServicios);
    }

    public ActionResult Agregar()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Agregar(Servicios oServicio)
    {
      db.Servicios.Add(oServicio);
      db.SaveChanges();
      return View();
    }

    public ActionResult Modificar(int id)
    {
      Servicios oServicio = db.Servicios.Where(a => a.id_servicio == id).FirstOrDefault();
      return View(oServicio);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Modificar(Servicios oServicios)
    {
      Servicios registroViejo = db.Servicios.Find(oServicios.id_servicio);
      registroViejo.nombre_servicio = oServicios.nombre_servicio;
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult DetallesServicios(int id)
    {
      Servicios servicio = db.Servicios.Find(id);
      return View(servicio);
    }

    public ActionResult Eliminar(int id)
    {
      Servicios servicio = db.Servicios.Find(id);
      db.Servicios.Remove(servicio);
      db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
