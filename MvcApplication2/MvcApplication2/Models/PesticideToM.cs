using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class PesticideToM
    {
        [Key]
        public int id { get; set; }

        public string PesticideId { get; set; }

        public string ManufacturerId { get; set; }
    }
}