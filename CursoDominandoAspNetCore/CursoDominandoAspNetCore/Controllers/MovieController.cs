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
        public IActionResult Adicionar(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //
            }
            return View(movie);
        }

        [HttpPost]
        public IActionResult Salvar(int ID)
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
