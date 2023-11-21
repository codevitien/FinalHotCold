using FinalHotCold.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalHotCold.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/orders")]
    public class OrdersController : Controller
    {
        private readonly FinalHotColdContext _context;
        public OrdersController(FinalHotColdContext context)
        {
            _context = context;
        }
        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return _context.Order != null ?
                        View(await _context.Order.ToListAsync()) :
                        Problem("Entity set 'FinalHotColdContext.Order'  is null.");
        }
    }
}
