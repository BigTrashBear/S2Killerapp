using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheChessCCG.Areas.VanPiereRoosters.Controllers
{
    [Area("VanPiereRoosters")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}