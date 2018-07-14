using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class ObservePoint
    {
        [Key]
        public int ID { get; set; }

        public string Address { get; set; }

        public string Altitude { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public DateTime ObDate { get; set; }

        public string Name { get; set; }
    }
}