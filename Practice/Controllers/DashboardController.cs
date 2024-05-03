using Microsoft.EntityFrameworkCore; // for Include method
using System.Linq; // for ToListAsync method
using Microsoft.AspNetCore.Mvc;
using Practice.Data;
using Microsoft.AspNetCore.Authorization; // for Authorize attribute

namespace Practice.Controllers
{
    [Authorize] // Restrict access to authenticated users only
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var transactions = await _context.Transaction.Include(t => t.Category).ToListAsync();
            return View(transactions);
        }
    }
}
