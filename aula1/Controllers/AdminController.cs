using System;
using Microsoft.AspNetCore.Mvc;

namespace aula1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(){
            return Content("Olá Mundo");
        }

        [HttpGet("view")]
        public IActionResult visualizar (){
            return View();
        }
    }
}