using AspTask3.Entities;
using AspTask3.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspTask3.Repositories
{
	public class FoodRepository : IFoodRepository
	{

		private readonly FoodDbContext _context;

		public FoodRepository(FoodDbContext context)
		{
			_context = context;
		}

		public void Add(Food food)
		{
			_context.Foods.Add(food);
			_context.SaveChanges();
		}

		public List<Food> GetFoods()
		{
			return _context.Foods.ToList();
		}
	}
}
