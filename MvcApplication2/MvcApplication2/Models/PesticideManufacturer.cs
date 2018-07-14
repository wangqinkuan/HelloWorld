using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class PesticideManufacturer
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Zipcode { get; set; }

        public string Phone { get; set; }
    }
}