using APPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPO.Controllers
{
    public class TipoCuentasController : Controller
    {
    APPOEntities db = new APPOEntities();
    // GET: TipoCuentas
    public ActionResult Index()
    {
      List<TiposCuentas> listaTiposCuentas = db.TiposCuentas.ToList();
      return View(listaTiposCuentas);
    }

    public ActionResult Agregar()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Agregar(TiposCuentas oTipoCuenta)
    {
      db.TiposCuentas.Add(oTipoCuenta);
      db.SaveChanges();
      return View();
    }

    public ActionResult Modificar(int id)
    {
      TiposCuentas oTipoCuenta = db.TiposCuentas.Where(a => a.id_tipo_cuenta == id).FirstOrDefault();
      return View(oTipoCuenta);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Modificar(TiposCuentas oTiposCuentas)
    {
      TiposCuentas registroViejo = db.TiposCuentas.Find(oTiposCuentas.id_tipo_cuenta);
      registroViejo.nombre = oTiposCuentas.nombre;
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult DetallesTiposCuentas(int id)
    {
      TiposCuentas tipocuenta = db.TiposCuentas.Find(id);
      return View(tipocuenta);
    }

    public ActionResult Eliminar(string id)
    {
      TiposCuentas tipocuenta = db.TiposCuentas.Find(id);
      db.TiposCuentas.Remove(tipocuenta);
      db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
