using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheChessCCG.Models;

namespace TheChessCCG.Areas.General.Controllers
{
    [Area("General")]
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewPage()
        {
            return View();
        }
    }
}