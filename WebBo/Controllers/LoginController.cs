using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBo.Bussiness.Users;
using WebBo.Models;
using Newtonsoft.Json;
using System.Text;

namespace WebBo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //检查用户信息
                var user = new UserBiz().CheckUser(model.UserName, model.Password);
                if (user != null)
                {
                    //记录Session
                    HttpContext.Session.Set(user.UserId.ToString(), Encoding.Default.GetBytes(JsonConvert.SerializeObject(user)));
                    //跳转到系统首页
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "用户名或密码错误。");
                return View();
            }
            return View(model);
        }




    }
}