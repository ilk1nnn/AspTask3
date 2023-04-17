using AspTask3.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspTask3.Models
{
	public class FoodDbContext : DbContext
	{
		public FoodDbContext(DbContextOptions contextOptions)
			:base(contextOptions)
		{

		}


		public DbSet<Food> Foods { get; set; }


	}
}
