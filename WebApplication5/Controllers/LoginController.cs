using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vanPiereApp.Logic;

namespace vanPiereApp.Controllers
{
    public class LoginController : Controller
    {
        Login login = new Login();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string username, string password)
        {
            if (login.AuthorizeUser(username, password) == true)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}