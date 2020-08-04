using CursoDominandoAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoDominandoAspNetCore.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
            
        }
    }
}
