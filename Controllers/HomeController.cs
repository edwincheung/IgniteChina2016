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
            //string nameFX = PlatformServices.Default.Application.RuntimeFramework.FullName.ToString();

            //string osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

            //ViewData["Message"] = nameFX + " running on " + osNameAndVersion + ". " ;

            ViewData["Message"] = " ";
            
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
