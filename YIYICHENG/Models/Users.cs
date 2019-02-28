using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace YIYICHENG.Models
{
    public class Users
    {
        public Users()
        {
            Orders = new HashSet<Order>();
            Addresses = new HashSet<Address>();
            Cats = new HashSet<GoodsCats>();
            UserSex = 0;
        }

        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "用户名不能为空")]
        [StringLength(16)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        [RegularExpression(@"^[a-zA-Z]\w{5,17}$", ErrorMessage = "以字母开头，长度在6~18之间，只能包含字符、数字和下划线")]
        [DataType(DataType.Password)]
        [StringLength(16,MinimumLength = 6)]
        [Display(Name = "密码")]
        public string Pwd { get; set; }

        [Display(Name = "昵称")]
        [Required(ErrorMessage = "昵称不能为空")]
        public string UserNickName { get; set; }
               
        [Display(Name = "手机号码")]
        [RegularExpression(@"^((/(/d{3}/))|(/d{3}/-))?13[0-9]/d{8}|15[89]/d{8}", ErrorMessage = "请输入正确的电话号码")]
        [Phone]
        public string Phone { get; set; }

        [RegularExpression(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "请输入正确的Email格式：abc@123.com")]
        [EmailAddress]
        [Display(Name = "邮箱")]
        [StringLength(30)]
        public string Email { get; set; }

        [Display(Name = "性别")]
        public int UserSex { get; set; }

        [Display(Name = "头像")]
        public string UserHead { get; set; }

        [Display(Name = "出生日期")]
        public DateTime BirthDay { get; set; }

        [Display(Name = "上次登录时间")]
        public DateTime LastLoginTime { get; set; }

        [Display(Name = "注册时间")]
        public DateTime RegTime { get; set; }

        [Display(Name = "注册方式")]
        public string RegWay { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<GoodsCats> Cats { get; set; }
        public virtual Vip Vips { get; set; } //一对一关系

    }
}