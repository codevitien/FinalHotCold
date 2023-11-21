using FinalHotCold.Data;
using FinalHotCold.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FinalHotCold.Controllers
{
    public class HomeController : Controller
    {
       
		private readonly FinalHotColdContext _context;

		public HomeController(FinalHotColdContext context)
		{
			_context = context;
		}
		public IActionResult Index()
        {
            return View();
        }

		public IActionResult Product(int? categoryId)
		{
			if (categoryId == null)
			{
                categoryId = 1;

            }

            // Lấy danh sách sản phẩm thuộc danh mục
            var products = _context.Product
                .Where(p => p.CategoryId == categoryId).ToList();

			return View(products);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}