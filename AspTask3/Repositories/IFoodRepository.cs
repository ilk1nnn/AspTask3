using AspTask3.Entities;
using System.Collections.Generic;

namespace AspTask3.Repositories
{
	public interface IFoodRepository
	{
		List<Food> GetFoods();
		void Add(Food food);
	}
}
