using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyKitchen.Models;

namespace MyKitchen.Services
{
	interface IIngredientData
	{
		//fetch a single ingredient from an ingredient id
		Ingredient GetIngredient(int id);
		//get all the ingredients in a single recipe
		IEnumerable<Ingredient> GetRecipeIngredients(int recipe_id);
		//get all the ingredients in a user's pantry
		IEnumerable<Ingredient> GetPantryIngredients(int user_id);
	}
}
