using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyKitchen.Data;
using MyKitchen.Models;

namespace MyKitchen.Services
{
	public class MySqlIngredientData : IIngredientData
	{
		private ApplicationDbContext _context;
		private Ingredient _ingredient;
		private IEnumerable<Ingredient> _ingredients;
		private IEnumerable<int> _ingredientIds;

		public MySqlIngredientData(ApplicationDbContext context)
		{
			_context = context;
		}

		public Ingredient GetIngredient(int id)
		{
			_ingredient = _context.Ingredients.FirstOrDefault(i => i.IngredientId == id);

			return _ingredient;
		}

		public IEnumerable<Ingredient> GetIngredients()
		{
			_ingredients = from r in _context.Ingredients
						   select r;

			return _ingredients;
		}

		public IEnumerable<Ingredient> GetRecipeIngredients(int RecipeId)
		{
			_ingredientIds = from r in _context.RecipeIngredients
							 where r.RecipeId == RecipeId
							 select r.RecipeId;

			_ingredients = _context.Ingredients.Where(ing => _ingredientIds.Any(i => ing.IngredientId.Equals(i)));

			return _ingredients;
		}

		public IEnumerable<Ingredient> GetPantryIngredients(int UserId)
		{
			_ingredientIds = from p in _context.Pantries
							 where p.UserId == UserId
							 select p.IngredientId;

			_ingredients = _context.Ingredients.Where(ing => _ingredientIds.Any(i => ing.IngredientId.Equals(i)));

			return _ingredients;
		}
	}
}