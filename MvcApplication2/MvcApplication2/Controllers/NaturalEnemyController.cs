using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class NaturalEnemyController : Controller
    {
        //
        // GET: /NaturalEnemy/
        Context db = new Context();
        public ActionResult Index(string id="")
        {
            var naturalenemy = db.Database.SqlQuery<NaturalEnemy>(SQLCMD.naturalenemycmd.naturalenemy_by_ne_id(id)).FirstOrDefault();
            ViewData["pest"] = db.Database.SqlQuery<pest>(SQLCMD.pestcmd.pestinfo_byneid(id));
            return View(naturalenemy);
        }

    }
}
