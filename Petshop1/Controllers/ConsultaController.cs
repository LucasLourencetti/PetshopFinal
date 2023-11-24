using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petshop1.Models;

namespace Petshop1.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly Contexto contexto;

        public ConsultaController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult Filtrar()
        {
            return View();
        }

        public IActionResult conServ(string busca)
        {
            var serv = contexto.Servicos.Include(cli => cli.Cliente)
                                        .Include(ani => ani.Animal)
                                        .Include(tip => tip.TipoServico)
                                        .Where(o => o.Animal.nome == busca)
                                        .ToList();
            return View(serv);
        }
    }
}
