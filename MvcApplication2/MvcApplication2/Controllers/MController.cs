using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class MController : Controller
    {
        //
        // GET: /M/
        Context db = new Context();

        public ActionResult Index(string id)
        {
            var m = db.PesticideManufacturer.Where(a => a.ID == id).FirstOrDefault();
            ViewData["pc"] = db.Database.SqlQuery<Pesticide>(SQLCMD.pesticide.pesticideinfo_bymid(id));
            return View(m);
        }

    }
}
