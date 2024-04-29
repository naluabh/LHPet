using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Cliente> listaClientes = new List<Cliente>(){

         new Cliente(1, "Samuel", "000.032.950-01", "test1@gmail.com", "Madruga"),
         new Cliente(2, "João", "111.222.333-44", "test2@gmail.com", "Silva"),
         new Cliente(3, "Maria", "555.666.777-88", "test3@gmail.com", "Santos"),
         new Cliente(4, "Ana", "999.888.777-66", "test4@gmail.com", "Oliveira"),
         new Cliente(5, "Pedro", "444.333.222-11", "test5@gmail.com", "Costa"),
        };

        List<Fornecedor> listaFornecedores = new List<Fornecedor>(){
         new Fornecedor(1, "Mario", "15.836,698/00001-57", "ctrl1@alt.dog.br"),
         new Fornecedor(2, "Luigi", "16.837,699/00002-58", "ctrl2@alt.dog.br"),
         new Fornecedor(3, "Peach", "17.838,700/00003-59", "ctrl3@alt.dog.br"),
         new Fornecedor(4, "Toad", "18.839,701/00004-60", "ctrl4@alt.dog.br"),
         new Fornecedor(5, "Bowser", "19.840,702/00005-61", "ctrl5@alt.dog.br"),
        };

        ViewBag.listaClientes = listaClientes;
        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
