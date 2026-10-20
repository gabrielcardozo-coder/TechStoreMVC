using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class categoriasController : Controller//o ":" significa herança, ou seja, a classe ProdutosController herda da classe Controller
    //herança = herda as características da classe pai, ou seja, a classe Controller
    //conceito POO = Programação Orientada a Objetos
    {
        
        // GET: ProdutosController

        
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria(1, "Informática","Computadores e componentes", true),
                new Categoria(2, "Teclado Mecânico", "Mouse, teclado e acessórios", true),
                new Categoria(5, "Monitor 24 polegadas", "Categorias fora de uso", false),
            
            };
            return View(categorias);
        }

    }
}
