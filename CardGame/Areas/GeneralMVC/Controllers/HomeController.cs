using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Authorization;


namespace CardGame.Areas.GeneralMVC.Controllers
{
    [RequireHttps]
    
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}