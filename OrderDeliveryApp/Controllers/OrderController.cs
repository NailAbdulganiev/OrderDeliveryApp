using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderDeliveryApp.Data;
using OrderDeliveryApp.Models;

namespace OrderDeliveryApp.Controllers;

public class OrderController(AppDbContext context) : Controller
{
    private readonly AppDbContext _context = context;
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Order order)
    {
        if (ModelState.IsValid)
        {
            order.PickupDate = order.PickupDate.ToUniversalTime();
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(order);
    }
    
    public async Task<IActionResult> Index()
    {
        var orders = await _context.Orders.ToListAsync();
        return View(orders);
    }
    
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        
        var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
        if (order == null)
        {
            return NotFound();
        }
        
        return View(order);
    }
}