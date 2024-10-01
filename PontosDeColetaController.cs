using Microsoft.AspNetCore.Mvc;
using ResiduosEletronicos.Data;
using ResiduosEletronicos.Models;

namespace ResiduosEletronicos.Controllers
{
    public class PontosDeColetaController : Controller
    {
        private readonly AppDbContext _context;

        public PontosDeColetaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pontos = _context.PontosDeColeta.ToList();
            return View(pontos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PontoDeColeta ponto)
        {
            if (ModelState.IsValid)
            {
                _context.PontosDeColeta.Add(ponto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ponto);
        }
    }
}
