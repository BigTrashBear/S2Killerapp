﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheChessCCG.Areas.Game.Controllers
{
    [Area("Game")]
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}