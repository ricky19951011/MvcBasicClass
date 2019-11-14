using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcBasic_Clone.Models
{
    public class family
    {
        [Display(Name = "身分證字號")]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "電話")]
        public string Phone { get; set; }
        [Display(Name = "年齡")]
        public string Age { get; set; }
        [Display(Name = "城市")]
        public string City { get; set; }
    }
}