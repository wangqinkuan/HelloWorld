using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class PesticideController : Controller
    {
        //
        // GET: /Pesticide/
        Context db = new Context();

        public ActionResult Index(string id)
        {
            var pesticide = db.Pesticide.Where(a => a.id == id).FirstOrDefault();
            ViewData["m"] = db.Database.SqlQuery<PesticideManufacturer>(SQLCMD.m.m_bypcid(id));
            ViewData["pest"] = db.Database.SqlQuery<pest>(SQLCMD.pestcmd.pestinfo_bypcid(id));
            return View(pesticide);
        }

    }
}
