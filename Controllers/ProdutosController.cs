using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class ProdutosController : Controller//o ":" significa herança, ou seja, a classe ProdutosController herda da classe Controller
    //herança = herda as características da classe pai, ou seja, a classe Controller
    //conceito POO = Programação Orientada a Objetos
    {
        
        // GET: ProdutosController

        
        public ActionResult Index()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto(1, "Mouse Gamer", 129.9m, 10),
                new Produto(2, "Teclado Mecânico", 250.00m, 5),
                new Produto(3, "Monitor 24 polegadas", 800.00m, 8),
                new Produto(4, "Headset Gamer", 129.9m, 10),
            };
            return View(produtos);
        }

    }
}
