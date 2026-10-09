using Catalog.API.Data;
using Catalog.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatalogController : ControllerBase
{
    private readonly CatalogContext _context;

    public CatalogController(CatalogContext context)
    {
        _context = context;
    }

    [HttpGet("items")]
    public async Task<ActionResult<IEnumerable<CatalogItem>>> GetItems()
    {
        return await _context.CatalogItems.ToListAsync();
    }

    [HttpGet("items/{id:int}")]
    public async Task<ActionResult<CatalogItem>> GetItemById(int id)
    {
        var item = await _context.CatalogItems.FindAsync(id);
        if (item == null) return NotFound();
        return item;
    }

    [HttpPost("items")]
    public async Task<ActionResult<CatalogItem>> CreateItem(CatalogItem item)
    {
        _context.CatalogItems.Add(item);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetItemById), new { id = item.Id }, item);
    }
}