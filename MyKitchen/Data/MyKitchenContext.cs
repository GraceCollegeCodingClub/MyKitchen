using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyKitchen.Models;

namespace MyKitchen.Data
{
	public class MyKitchenContext : IdentityDbContext
	{
		public MyKitchenContext(DbContextOptions<MyKitchenContext> options)
			: base(options)
		{
		}
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Recipe> Recipes { get; set; }
		public new DbSet<User> Users { get; set; }
		public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
		public DbSet<Pantry> Pantries { get; set; }
		public DbSet<MealPlan> MealPlans { get; set; }
	}
}
