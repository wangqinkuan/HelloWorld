using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcApplication2.Models
{
    public class Pesticide
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "id必填")]
        [RegularExpression("[0-9]+", ErrorMessage = "请输入数字")]
        [Key]
        public string id { get; set; }
        //s属名
        public string GenericName { get; set; }
        //商品名
        public string TradeName { get; set; }
        //剂量
        public string DosageForm { get; set; }

        public string ApplicationRate { get; set; }

        public string Method { get; set; }

        public string Safety { get; set; }

    }
}