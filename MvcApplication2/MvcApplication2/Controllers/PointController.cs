using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class PointController : Controller
    {
        //
        // GET: /Point/
        
        Context db = new Context();

        public ActionResult Index(string searchtxt = "", string pname = "", string buffer = "")
        {
            ViewBag.searchtxt = searchtxt;
            ViewBag.name = pname;
            ViewBag.buffer = buffer;
            var points = db.Database.SqlQuery<ObservePoint>(SQLCMD.point.search(searchtxt,pname));

            return View(points);
        }
        //上传点数据
        [HttpPost]
        public ActionResult Upload()
        {
            //遍历所有文件
            for (int i = 0; i < Request.Files.Count;i++ )
            {
                var File = Request.Files[i];
                byte[] byts = new byte[File.ContentLength];
                //将文件内容写入bytes
                File.InputStream.Read(byts, 0, File.ContentLength);

                AddPoints(byts);

                File.InputStream.Close();
            }
           
            return RedirectToAction("Index");
        }
        //加多个点
        public int AddPoints(byte[] byts)
        {
            int result = 0;
            //将byte数组转为string
            string str = System.Text.Encoding.Default.GetString(byts);
            //将文件通过换行切分
            string[] rows = str.Split('\r','\n');
            foreach (var row in rows)
            {
                if (row != "")
                {
                   //每一行通过空格或制表符分离
                   result+=AddPoint(row.Split(' ','\t'));
                }
            }
            return result;
        }
        //加单个点
        public int AddPoint(string[] pointinfo)
        {
            try
            {
                ObservePoint point = new ObservePoint();

                point.Address = pointinfo[0];
                point.Altitude = pointinfo[1];
                point.Longitude = pointinfo[2];
                point.Latitude = pointinfo[3];
                point.ObDate = Convert.ToDateTime(pointinfo[4]);
                point.Name = pointinfo[5];

                db.ObservePoint.Add(point);
                db.SaveChanges();
            }
            catch (Exception e)
            {

                return 0;
            }

            return 1;
        }
        //删除
       
        public ActionResult Delete(int id)
        {
            var data = db.ObservePoint.Where(a => a.ID == id).FirstOrDefault();
            db.ObservePoint.Remove(data);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

     
    }
}
