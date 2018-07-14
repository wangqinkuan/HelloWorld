using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace MvcApplication2.Models
{
    public class Photos
    {
        [Key]
        public int id { get; set; }

        public string Type { get; set; }

        public string ObjID { get; set; }

        public string Url { get; set; }

        public string Photographer { get; set; }

        public string Description { get; set; }

        public DateTime ShotDate { get; set; }

        public string Location { get; set; }
    }
}