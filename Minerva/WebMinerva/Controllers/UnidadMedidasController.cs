
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMinerva.Models;

public class UnidadMedidasController : Controller
{
    private readonly MinervaContext _context;

    public UnidadMedidasController(MinervaContext context)
    {
        _context = context;
    }

    // GET: UNIDADMEDIDAS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.UnidadMedida.ToListAsync());
    }

    // GET: UNIDADMEDIDAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var unidadmedida = await _context.UnidadMedida
            .FirstOrDefaultAsync(m => m.Id == id);
        if (unidadmedida == null)
        {
            return NotFound();
        }

        return View(unidadmedida);
    }

    // GET: UNIDADMEDIDAS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: UNIDADMEDIDAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Descripcion,UsuarioRegistro,FechaRegistro,Estado,Producto")] UnidadMedida unidadmedida)
    {
        if (ModelState.IsValid)
        {
            _context.Add(unidadmedida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(unidadmedida);
    }

    // GET: UNIDADMEDIDAS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var unidadmedida = await _context.UnidadMedida.FindAsync(id);
        if (unidadmedida == null)
        {
            return NotFound();
        }
        return View(unidadmedida);
    }

    // POST: UNIDADMEDIDAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Descripcion,UsuarioRegistro,FechaRegistro,Estado,Producto")] UnidadMedida unidadmedida)
    {
        if (id != unidadmedida.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(unidadmedida);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnidadMedidaExists(unidadmedida.Id))
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
        return View(unidadmedida);
    }

    // GET: UNIDADMEDIDAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var unidadmedida = await _context.UnidadMedida
            .FirstOrDefaultAsync(m => m.Id == id);
        if (unidadmedida == null)
        {
            return NotFound();
        }

        return View(unidadmedida);
    }

    // POST: UNIDADMEDIDAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var unidadmedida = await _context.UnidadMedida.FindAsync(id);
        if (unidadmedida != null)
        {
            _context.UnidadMedida.Remove(unidadmedida);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool UnidadMedidaExists(int? id)
    {
        return _context.UnidadMedida.Any(e => e.Id == id);
    }
}
