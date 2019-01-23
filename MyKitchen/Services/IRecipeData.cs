using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyKitchen.Models;

namespace MyKitchen.Services
{
	interface IRecipeData
	{
		Recipe GetRecipe(int id);
		IEnumerable<Recipe> GetRecipes(int user_id);
	}
}
