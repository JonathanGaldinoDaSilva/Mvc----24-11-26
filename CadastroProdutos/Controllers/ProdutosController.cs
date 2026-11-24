using Microsoft.AspNetCore.Mvc;

namespace CadastroProdutos.Controllers;

public class ProdutosController : Controller
{
    public class IActionResult Index()
    {
        return Content("Página de produtos");
    }
}