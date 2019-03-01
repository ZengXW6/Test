using Forcheng.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YIYICHENG.Models;

namespace YIYICHENG.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //登入页面
        public ActionResult Login()
        {
            return View();
        }
        //注册页面
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registers(Users us)
        {
          
            return View("Login");
        }

        //产品列表
        public ActionResult Product()
        {
            return View();
        }

        //购物车
        public ActionResult ShoppingCat()
        {
            return View();
        }

        //修改密码
        public ActionResult Pwd()
        {
            return View();
        }

        //产品详情
        public ActionResult ProductShow()
        {
            return View();
        }

        //提交订单
        public ActionResult InFo()
        {
            return View();
        }

        //会员中心
        public ActionResult Member()
        {
            return View();
        }

        //选择支付
        public ActionResult Payply()
        {
            return View();
        }







        /// <summary>
        /// 获取图片验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult GetValidateCode(string codeClass)
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(4);
            Session["ValidateCode"] = code;
            byte[] bytes = vCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }

        /// <summary>
        /// 验证验证码是否正确
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool CheckValidateCode(string num)
        {

            string cnum = Session["ValidateCode"] == null ? "" : Session["ValidateCode"].ToString();

            if (num == cnum && !string.IsNullOrEmpty(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 验证码检查
        /// </summary>
        /// <returns></returns>
        public ActionResult CodeVerify()
        {
            string code = Request["code"];
            string result = string.Empty;
            if (CheckValidateCode(code))
            {
                result = "1";
                return Content(result);
            }
            else
            {
                result = "0";
                return Content(result);
            }
        }

    }
}