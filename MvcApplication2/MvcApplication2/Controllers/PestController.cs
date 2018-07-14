using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using MvcApplication2.Models;


namespace MvcApplication2.Controllers
{
    public class PestController : Controller
    {
       
        //
        // GET: /Pest/
        Context db = new Context();
     
        //显示全部病虫害信息
        public ActionResult Index(string searchtxt="")
        {
           // .Where(a => a.id.Contains(searchtxt)).OrderBy(a => a.id)
             var pestInfo = db.Database.SqlQuery<pest>(SQLCMD.pestcmd.searchPest(searchtxt)).OrderBy(a=>a.id);
             ViewBag.searchtxt = searchtxt;
           // IPagedList<pest> pagelist = pestInfo.Where(a => a.id.Contains(searchtxt)).OrderBy(a => a.id).ToPagedList(pageIndex, 20);
            //根据id检索

    //         Chart chart = new Chart(500, 400, ChartTheme.Blue);
    //         chart.AddTitle("2014年城市人口统计");
    //         chart.AddSeries(name: "2014population",
    //xValue: new List<string>() { "北京", "上海", "广州", "深圳", "重庆" },//要沿 X 轴绘制的值
    //yValues: new List<float>() { 1962.24f, 2301.91f, 1270.08f, 1035.79f, 2884.62f }//要沿 Y 轴绘制的值 );
    //         chart.SetXAxis("城市");
    //         chart.SetYAxis("人口");
    //         chart.Write();
  
            return View(pestInfo);
        }
        //创建病虫害入口
        public ActionResult Create() 
        {
            return View(new pest());
        }
        //创建病虫害post请求
        [HttpPost]
        public ActionResult Create(pest p)
        {
            //用try防止程序终止
            try
            {
              
                db.pest.Add(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            //创建失败 则传递回pest对象给create页面
            return View(p);
        }

        //病虫害删除
        public ActionResult Delete(string id)
        {
            try
            {
                var pest = db.pest.Where(x => x.id == id).FirstOrDefault();
                db.pest.Remove(pest);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        //病虫害编辑
        public ActionResult Edit(string id) 
        {
            try
            {
                var data = db.pest.Where(x => x.id == id).FirstOrDefault();
                return View(data);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
          
        }
        //post编辑
        [HttpPost]
        public ActionResult Edit(pest p)
        {
            try
            {
              
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception e)
            { 
            }
            return View(p);
        }

        public ActionResult Detail(string id) 
        {
            //根据害虫的id查询其自身详情以及控制方法及天敌
            try
            {
                var pestinfo = db.pest.Where(x => x.id == id).FirstOrDefault();

                ViewData["controllingmethod"] = db.Database.SqlQuery<ControllingMethod>(SQLCMD.controllingmethodcmd.controlling_method_info(id));
                ViewData["naturalenemy"] = db.Database.SqlQuery<NaturalEnemy>(SQLCMD.naturalenemycmd.naturalenemy_info(id));
                ViewData["Pesticide"] = db.Database.SqlQuery<Pesticide>(SQLCMD.pesticide.pesticideinfo_bypestid(id));
                //ViewData["Photos"] = db.Database.SqlQuery<Photos>("");
                return View(pestinfo);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }


    }
}
