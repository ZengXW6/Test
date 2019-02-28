using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YIYICHENG.Models
{
    public class Nav
    {
        [Key]
        public int NavID { get; set; }

        [Required]
        public string NavName { get; set; }

    }
}