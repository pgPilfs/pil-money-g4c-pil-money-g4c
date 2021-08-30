using APPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPO.Controllers
{
    public class CuentasController : Controller
    {
    APPOEntities db = new APPOEntities();
    // GET: Cuentas
    public ActionResult Index()
    {
      List<Cuentas> listaCuentas = db.Cuentas.ToList();
      return View(listaCuentas);
    }

    public ActionResult Agregar()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Agregar(Cuentas oCuenta)
    {
      db.Cuentas.Add(oCuenta);
      db.SaveChanges();
      return View();
    }

    public ActionResult Modificar(string id)
    {
      Cuentas oCuenta = db.Cuentas.Where(a => a.CVU == id).FirstOrDefault();
      return View(oCuenta);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Modificar(Cuentas oCuentas)
    {
      Cuentas registroViejo = db.Cuentas.Find(oCuentas.CVU);
      registroViejo.alias = oCuentas.alias;
      registroViejo.id_tipo_cuenta = oCuentas.id_tipo_cuenta;
      registroViejo.saldo_actual = oCuentas.saldo_actual;
      registroViejo.dni_usuario = oCuentas.dni_usuario;
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult DetallesCuentas(string id)
    {
      Cuentas cuenta = db.Cuentas.Find(id);
      return View(cuenta);
    }

    public ActionResult Eliminar(string id)
    {
      Cuentas cuenta = db.Cuentas.Find(id);
      db.Cuentas.Remove(cuenta);
      db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
