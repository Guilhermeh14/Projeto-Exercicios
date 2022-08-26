using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercicios.Models;

namespace Exercicios.Controllers
{
    public class CondicionaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult CondicionalIf()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CondicionalIf(Partida p)
        {
            return View(p);
        }

        [HttpGet]
        public IActionResult CondicionalSwitch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CondicionalSwitch(Pedido pedido)
        {
            return View(pedido);
        }


    }
}