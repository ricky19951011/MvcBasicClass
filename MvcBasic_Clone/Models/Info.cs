using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Info
    {
        public int Id { get; set; }


        [Display(Name="姓名")]
        [Required(ErrorMessage ="Name必須輸入")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="最少需要三個字元")]
        public string Name { get; set; }


        [Display(Name="行動電話")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$",ErrorMessage ="須為09xx-xxx-xxx")]
        [Required(ErrorMessage ="必須輸入行動電話")]
        public string Phone { get; set; }


        [Display(Name="Email")]
        [Required(ErrorMessage ="請輸入信箱")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name="性別")]
        [Required(ErrorMessage ="請輸入GENDER")]
        public string Gender { get; set; }
        
    }
}