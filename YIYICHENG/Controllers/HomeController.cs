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

        [HttpPost]
        public ActionResult Loginin(Users users)
        {

            return View("Index");
        }

        //注册页面
        public ActionResult Register()
        {
            return View();
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
    }
}