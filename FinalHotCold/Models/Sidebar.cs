using FinalHotCold.Data;
using Microsoft.AspNetCore.Mvc;


namespace FinalHotCold.Models
{
    public class Sidebar : ViewComponent
	{
        private readonly FinalHotColdContext _context;

        public Sidebar(FinalHotColdContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
