using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class NaturalEnemy
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "id必填")]
        [RegularExpression("[0-9]+", ErrorMessage = "请输入数字")]
        [Key]
        public string id { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "拉丁名必填")]
        public string ScientificName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "中文名必填")]
        [RegularExpression("[\u4e00-\u9fa5]+", ErrorMessage = "请输入中文")]
        public string ScientificName_chs { get; set; }
        
        public string Alias { get; set; }

        public string Description { get; set; }
    }
}