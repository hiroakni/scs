using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SCSHomePage.Models
{
    public class Code
    {
        [Required]
        [DisplayName("お名前")]
        public string Oname { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("電話番号")]
        public int Phone { get; set; }

        [Required]
        [DisplayName("内容")]
        public string Detail { get; set; }

    }
}