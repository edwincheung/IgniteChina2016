using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.PlatformAbstractions;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string nameFX = PlatformServices.Default.Application.RuntimeFramework.FullName.ToString();
            string osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
               
            //ViewData["Message"] = " ";
            DateTime today = DateTime.Today.ToLocalTime();
            ViewData["Today"] = today.Year.ToString() + "年" + today.Month.ToString() + "月" + today.Day.ToString() + "日"; 
            ViewData["DOTNETCORE"] = nameFX;
            ViewData["OSPlatform"] = osNameAndVersion;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
