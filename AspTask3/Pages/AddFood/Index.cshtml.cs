using AspTask3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace AspTask3.Pages.Food
{
    public class IndexModel : PageModel
    {

        private readonly FoodDbContext _context;

		public IndexModel(FoodDbContext context)
		{
			_context = context;
		}


        public List<Entities.Food> Foods { get; set; }


        [BindProperty]
        public Entities.Food Food { get; set; }

        public void OnGet()
        {
            Foods = _context.Foods.ToList();
        }

        public IActionResult OnPost()
        {
			_context.Foods.Add(Food);
			_context.SaveChanges();
            return RedirectToAction("Index");
		}

    }
}
