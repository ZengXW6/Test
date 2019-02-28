using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YIYICHENG.Models
{
    public class Address
    {

        [Key]
        public int ID { get; set; }

        [Required]
        public int UserID { get; set; }

        public string Addresses { get; set; }


        [ForeignKey("UserID")]
        public Users Users { get; set; }

    }
}