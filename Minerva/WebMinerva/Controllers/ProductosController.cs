
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMinerva;
using WebMinerva.Models;

[Authorize]
public class ProductosController : Controller
{
    private readonly MinervaContext _context;

    public ProductosController(MinervaContext context)
    {
        _context = context;
    }

    // GET: PRODUCTOS
    public async Task<IActionResult> Index()
    {
        return View(await _context.Producto
            .Include(x => x.IdUnidadMedidaNavigation)
            .Where(x => x.Estado == (int)Estado.Activo)
            .OrderBy(x => x.Descripcion)
            .ToListAsync());
    }

    // GET: PRODUCTOS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var producto = await _context.Producto
            .Include(x => x.IdUnidadMedidaNavigation)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (producto == null)
        {
            return NotFound();
        }

        return View(producto);
    }

    // GET: PRODUCTOS/Create
    public IActionResult Create()
    {
        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida.Where(x => x.Estado == (int)Estado.Activo), "Id", "Descripcion");
        return View();
    }

    // POST: PRODUCTOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Producto producto)
    {
        if (!string.IsNullOrWhiteSpace(producto.Codigo) && !string.IsNullOrWhiteSpace(producto.Descripcion) &&
            producto.PrecioVenta > 0 && producto.Saldo >= 0 && producto?.IdUnidadMedida != null)
        {
            producto.UsuarioRegistro = User.Identity.Name;
            producto.FechaRegistro = DateTime.Now;
            producto.Estado = (int)Estado.Activo;
            _context.Add(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida.Where(x => x.Estado == (int)Estado.Activo), "Id", "Descripcion");
        return View(producto);
    }

    // GET: PRODUCTOS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida.Where(x => x.Estado == (int)Estado.Activo), "Id", "Descripcion");

        var producto = await _context.Producto.FindAsync(id);
        if (producto == null)
        {
            return NotFound();
        }

        return View(producto);
    }

    // POST: PRODUCTOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, Producto producto)
    {
        if (id != producto.Id)
        {
            return NotFound();
        }

        ViewData["UnidadesMedida"] = new SelectList(_context.UnidadMedida.Where(x => x.Estado == (int)Estado.Activo), "Id", "Descripcion");

        if (!string.IsNullOrWhiteSpace(producto.Codigo) && !string.IsNullOrWhiteSpace(producto.Descripcion) &&
            producto.PrecioVenta > 0 && producto.Saldo >= 0 && producto?.IdUnidadMedida != null)
        {
            try
            {
                producto.UsuarioRegistro = User.Identity.Name;
                _context.Update(producto);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(producto.Id))
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
        return View(producto);
    }

    // GET: PRODUCTOS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var producto = await _context.Producto
            .Include(x => x.IdUnidadMedidaNavigation)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (producto == null)
        {
            return NotFound();
        }

        return View(producto);
    }

    // POST: PRODUCTOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var producto = await _context.Producto.FindAsync(id);
        if (producto != null)
        {
            producto.Estado = (int)Estado.Eliminado;
            _context.Update(producto);
            //_context.Producto.Remove(producto);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ProductoExists(int? id)
    {
        return _context.Producto.Any(e => e.Id == id);
    }
}
