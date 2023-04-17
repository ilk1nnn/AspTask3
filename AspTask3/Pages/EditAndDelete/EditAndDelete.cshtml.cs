using AspTask3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace AspTask3.Pages.EditAndDelete
{
    public class EditAndDeleteModel : PageModel
    {

		public static int editId = 0;

		private readonly FoodDbContext _context;

		public EditAndDeleteModel(FoodDbContext context)
		{
			_context = context;
		}


        public List<Entities.Food> Foods { get; set; }


        public void OnGet()
        {
            Foods = _context.Foods.ToList();
        }


		public IActionResult OnPostEdit(int id)
		{
			editId = id;
			return RedirectToPage($"/EditAndDelete/Edit");
		}
		public IActionResult OnPostDelete(int id)
		{
			var food = _context.Foods.Find(id);
			if (food == null)
			{
				return NotFound();
			}
			_context.Foods.Remove(food);
			_context.SaveChanges();
			return RedirectToPage("Index");

		}

	}
}
