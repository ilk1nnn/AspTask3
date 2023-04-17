using AspTask3.Models;
using AspTask3.Pages.Food;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace AspTask3.Pages.EditAndDelete
{
    public class EditModel : PageModel
    {
        private readonly FoodDbContext _context;

		public EditModel(FoodDbContext context)
		{
			_context = context;
		}

        [BindProperty]
        public Entities.Food Food { get; set; }

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
			var foodFromDb = _context.Foods.Find(EditAndDeleteModel.editId);
			foodFromDb.Name = Food.Name;
			foodFromDb.Price = Food.Price;
			_context.SaveChanges();
			return RedirectToPage("Index");
		}



    }
}
