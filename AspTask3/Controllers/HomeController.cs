using AspTask3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask3.Controllers
{
	public class HomeController : Controller
	{
		private readonly FoodDbContext _context;

		public HomeController(FoodDbContext context)
		{
			_context = context;
		}



		public IActionResult Index()
		{
			return View(_context.Foods);
		}

	}
}
