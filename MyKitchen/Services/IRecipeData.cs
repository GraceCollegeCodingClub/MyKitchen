using System.Collections.Generic;
using MyKitchen.Models;

namespace MyKitchen.Services
{
	public interface IRecipeData
	{
		Recipe GetRecipe(int id);
		IEnumerable<Recipe> GetRecipes(string user_id);
	}
}