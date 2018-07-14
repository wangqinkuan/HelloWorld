using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class Users
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "必填")]
        public string ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "必填")]
        public string Account { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "必填")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "必填")]
        public string Password { get; set; }

        public string Institution { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Postcode { get; set; }

        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "必填")]
        public int Autority { get; set; }
    }
}