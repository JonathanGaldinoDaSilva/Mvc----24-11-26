using Microsoft.AspNetCore.Mvc;
// importa recursos do framework
using CadastroProdutos.Models;
namespace CadastroProdutos.Controllers;
// organiza as classes

public class ProdutosController : Controller
//.          nome do controller.  herança da classe Controller
{
    public IActionResult Index()
    //    IActionResult -  tipo do retorno da ação
    //     index() - metodo responsável pela pagina inicial
    {

        var produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "teclado",
                Preco = 13.0m,
                Estoque = 21
            },

            new Produto{

            
            Id = 2,
                Nome = "flauta",
                Preco = 23.43m,
                Estoque = 20
            },

            new Produto{

            
            Id = 3,
                Nome = "sax",
                Preco = 120.10m,
                Estoque = 43
            },

            new Produto{
            Id = 4,
                Nome = "violão",
                Preco = 135.80m,
                Estoque = 23
            }
        };

        return View(produtos);
        //return Content("Página de produtos");
    }
}