using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBo.Bussiness.Api;
using WebBo.Models;

namespace WebBo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var result = ApiAdapter.Instance.Post("http://api.ekai03.cn/api/create.asp", new ApiParamModel
            {
                ApiKey= "961b1d975f0e6c1b9b3463867cd1cb37",
                Link = "https://weibo.com/1932379431/G0GbZexxB",
                Num = 100,
                Author = false,
                Type = 12,
                Comment="aaa",
                ContentType = 2
            });

            ViewData["Message"] = ViewData["Message"] + result.msg;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
