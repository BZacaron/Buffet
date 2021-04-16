using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade1.Models;
using Buffet.Database;

namespace Atividade1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _databaseContext;

        public HomeController(ILogger<HomeController> logger, DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            var listaClientes = _databaseContext.Cliente.ToList();



            return View();
        }

        public IActionResult Privacidade()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Recuperar()
        {
            return View();
        }

        public IActionResult Termos()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult Painel()
        {
            return View();
        }

        public IActionResult Principal()
        {
            return View();
        }

        public IActionResult TermosInterno()
        {
            return View();
        }

        public IActionResult PrivacidadeInterno()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
