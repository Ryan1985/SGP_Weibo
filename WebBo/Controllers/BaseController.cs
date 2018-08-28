using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebBo.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //验证权限
            if (!context.HttpContext.Session.Keys.Contains("CurrentUser"))
            {
                //重定向到登录页面
                HttpContext.Response.Redirect("../Login/Login");
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}