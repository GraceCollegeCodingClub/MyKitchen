using System.Collections.Generic;
using System.Linq;
using MyKitchen.Data;
using MyKitchen.Models;
using MyKitchen.ViewModels;

namespace MyKitchen.Services
{
	public class MySqlIngredientData : IIngredientData
	{
		private MyKitchenContext _context;
		private Ingredient _ingredient;
		private IEnumerable<Ingredient> _ingredients;

		public MySqlIngredientData(MyKitchenContext context)
		{
			_context = context;
		}

		public Ingredient GetIngredient(int id)
		{
			_ingredient = _context.Ingredients.FirstOrDefault(i => i.ingredient_id == id);

			return _ingredient;
		}

		public IEnumerable<Ingredient> GetRecipeIngredients(int recipe_id)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Ingredient> GetPantryIngredients(int user_id)
		{
			throw new System.NotImplementedException();
		}
	}
}