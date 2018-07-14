using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class NaturalEnemyofPest
    {
        [Key]
        public int id { get; set; }

        public string NaturalEnemyId { get; set; }

        public string PestId { get; set; }
    }
}