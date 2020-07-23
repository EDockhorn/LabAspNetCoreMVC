using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CursoDominandoAspNetCore.Models;
using System;
using System.Linq;

namespace CursoDominandoAspNetCore.Controllers
{
    [Route("")]
    [Route("gestao-Clientes")]
    public class HomeController : Controller
    {
        [HttpPost("")]
        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria?}")]
        
        
        public IActionResult Index(int id, string categoria)
        {
            var Movie = new Movie()
            {
                Title = "OI",
                ReleaseDate = DateTime.Now,
                Genre = null,
                Rating = "10",
                Price = "20000"
            };
            //return RedirectToAction("Privacy", Movie);
            return View();
        }

        [Route("privacidade")]
        [Route("politica-privacidade")]
        [HttpPost("")]
        public IActionResult Privacy(Movie movie)
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var erros in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(erros.ErrorMessage);
            }

            return View();
        }

        [Route("erro-Encontrado")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
