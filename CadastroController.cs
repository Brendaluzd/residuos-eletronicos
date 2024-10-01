using Microsoft.AspNetCore.Mvc;

namespace ResiduosEletronicos.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
 

    // Processa o formulário de cadastro
    [HttpPost]
        public IActionResult Submit()
        {
            // Lógica para processar o cadastro (salvar dados no banco, etc.)
            // Adicione sua lógica de backend aqui

            // Redireciona para uma página de confirmação ou volta para o início
            return RedirectToAction("Index", "Home");
        }
    }
}
