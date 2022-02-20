using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV1.Models;

namespace ATV1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Formulario(){
            return View("Formulario");
        }
        [HttpPost]
        public IActionResult Cadastro(ItemPedido itemForm){
            Dados.PedidoAtual.AdicionarPedido(itemForm);
            //return View("/Home/Model/Listagem");
           return RedirectToAction("Listagem", "Home");
        }
        public IActionResult Listagem(){
            List<ItemPedido> listagemDaMem = Dados.PedidoAtual.ListaPedido();
            return View(listagemDaMem);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
