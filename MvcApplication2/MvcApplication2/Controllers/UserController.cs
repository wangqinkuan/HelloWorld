using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        Context db=new Context();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Users user) 
        {
            var u = db.Users.Where(a => a.Account == user.Account).FirstOrDefault();
            if (u == null || u.Password != user.Password) 
            {
                Response.Write("<script>alert(\'用户名或密码错误\')</script>");
                return View();
            }

            Session["level"] = u.Autority;
            Session["name"] = u.Name;
            return RedirectToAction("Index", "Pest/Index");
        }

        public ActionResult View1()
        { return View(); }
    }
}
