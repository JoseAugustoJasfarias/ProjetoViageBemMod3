using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViajeBem.Models;

namespace ViajeBem.Controllers
{
    public class HomeController : Controller
    {
        

       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Destinos()
        {
            return View();
        }

    }
}