using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPartial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PartialResult()
        {
            // İlgili klasörde (COntroller bazlı) veya shared folderinde ki view'i partial olarak döner...


            // Özellikle ajax (daha sonraki konumuz) reqeustrlerinde resppnse olarak html dönülecekse partialView güzel bir yöntemdir... 
            return PartialView("_PartialName");
        }
    }
}
