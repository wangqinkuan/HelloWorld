using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class ControllingMethod
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "id必填")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "请输入正确的14位id")]
        [RegularExpression("[0-9]+", ErrorMessage = "请输入数字")]
        public string id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "id必填")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "请输入正确的14位Pestid")]
        [RegularExpression("[0-9]+", ErrorMessage = "请输入数字")]
        public string PestID { get; set; }

        public int Type { get; set; }

        public string Description { get; set; }
    }
}