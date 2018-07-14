using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class pest
    {   
        [Required(AllowEmptyStrings = false, ErrorMessage = "id必填")]
        [StringLength(13, MinimumLength = 13,ErrorMessage="请输入正确的13位id")]
        [RegularExpression("[0-9]+",ErrorMessage="请输入数字")]
        [Key]
         public string id { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "拉丁名必填")]
         public string ScientificName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "中文名必填")]
        [RegularExpression("[\u4e00-\u9fa5]+",ErrorMessage="请输入中文")]
        public string ScientificName_chs { get; set; }

       
        public string Alias { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "目必填")]
        public string Order_ { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " 科必填")]
        public string Family { get; set; }

      
        public string Imago { get; set; }

       
        public string Egg { get; set; }

     
        public string Larva { get; set; }

  
        public string Occurence { get; set; }

 
        public string Distribution { get; set; }

     
        public string DamageSymptoms { get; set; }
                      
           
      
    }
}
