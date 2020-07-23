using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CursoDominandoAspNetCore.ViewComponents
{
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItensCarrinho = 45;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItensCarrinho);
        }
    }
}
