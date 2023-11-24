using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Petshop1.Models;

namespace Petshop1.Controllers
{
    public class ServicoesController : Controller
    {
        private readonly Contexto _context;

        public ServicoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Servicoes
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Servicos.Include(s => s.Animal).Include(s => s.Cliente).Include(s => s.TipoServico);
            return View(await contexto.ToListAsync());
        }

        // GET: Servicoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Servicos == null)
            {
                return NotFound();
            }

            var servico = await _context.Servicos
                .Include(s => s.Animal)
                .Include(s => s.Cliente)
                .Include(s => s.TipoServico)
                .FirstOrDefaultAsync(m => m.idServico == id);
            if (servico == null)
            {
                return NotFound();
            }

            return View(servico);
        }

        // GET: Servicoes/Create
        public IActionResult Create()
        {
            ViewData["idAnimal"] = new SelectList(_context.Animais, "idAnimal", "nome");
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "nome");
            ViewData["idTipoServico"] = new SelectList(_context.TipoServicos, "idTipoServico", "descricao");
            return View();
        }

        // POST: Servicoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idServico,idCliente,idAnimal,idTipoServico,horario,data,valorTotal,qtde")] Servico servico)
        {
            if (ModelState.IsValid)
            {

                TipoServico TipoServico = _context.TipoServicos.Find(servico.idTipoServico);
                if (TipoServico != null)
                {
                    servico.valorTotal = TipoServico.calcular(servico.qtde);

                    _context.Add(servico);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
            }
            ViewData["idAnimal"] = new SelectList(_context.Animais, "idAnimal", "nome", servico.idAnimal);
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "nome", servico.idCliente);
            ViewData["idTipoServico"] = new SelectList(_context.TipoServicos, "idTipoServico", "descricao", servico.idTipoServico);
            return View(servico);
        }

        // GET: Servicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Servicos == null)
            {
                return NotFound();
            }

            var servico = await _context.Servicos.FindAsync(id);
            if (servico == null)
            {
                return NotFound();
            }
            ViewData["idAnimal"] = new SelectList(_context.Animais, "idAnimal", "nome", servico.idAnimal);
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "nome", servico.idCliente);
            ViewData["idTipoServico"] = new SelectList(_context.TipoServicos, "idTipoServico", "descricao", servico.idTipoServico);
            return View(servico);
        }

        // POST: Servicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idServico,idCliente,idAnimal,idTipoServico,horario,data,valorTotal,qtde")] Servico servico)
        {
            if (id != servico.idServico)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicoExists(servico.idServico))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["idAnimal"] = new SelectList(_context.Animais, "idAnimal", "nome", servico.idAnimal);
            ViewData["idCliente"] = new SelectList(_context.Clientes, "idCliente", "nome", servico.idCliente);
            ViewData["idTipoServico"] = new SelectList(_context.TipoServicos, "idTipoServico", "descricao", servico.idTipoServico);
            return View(servico);
        }

        // GET: Servicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Servicos == null)
            {
                return NotFound();
            }

            var servico = await _context.Servicos
                .Include(s => s.Animal)
                .Include(s => s.Cliente)
                .Include(s => s.TipoServico)
                .FirstOrDefaultAsync(m => m.idServico == id);
            if (servico == null)
            {
                return NotFound();
            }

            return View(servico);
        }

        // POST: Servicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Servicos == null)
            {
                return Problem("Entity set 'Contexto.Servicos'  is null.");
            }
            var servico = await _context.Servicos.FindAsync(id);
            if (servico != null)
            {
                _context.Servicos.Remove(servico);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicoExists(int id)
        {
          return _context.Servicos.Any(e => e.idServico == id);
        }
    }
}
