using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyKitchen.Data;
using MyKitchen.Models;

namespace MyKitchen.Services
{
	public class MySqlRecipeData : IRecipeData
	{
		private Recipe _recipe;
		private IEnumerable<Recipe> _recipes;
		private MyKitchenContext _context;

		public MySqlRecipeData(MyKitchenContext context)
		{
			_context = context;
		}

		
		public Recipe GetRecipe(int id)
		{
			//query the database for a single recipe where recipe id is
			//equal to the id that was passed in and return it to the requestor
			_recipe = (from r in _context.Recipes
					   where r.RecipeId == id
					   select r).First();

			return _recipe;
		}

		public IEnumerable<Recipe> GetRecipes(int id)
		{
			//query the databse for all records with a user id equal to the
			//id that was passed in and return it as a list to the requestor

			_recipes = from r in _context.Recipes
					   where r.UserId == id
					   orderby r.RecipeName
					   select r;

			return _recipes;
		}

		public Recipe Add(Recipe recipe)
		{
			//add recipe to the recipe table of the database
			_context.Recipes.Add(recipe);
			_context.SaveChanges();

			return recipe;
		}
	}
}