using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyKitchen.Models;

namespace MyKitchen.ViewModels
{
	public class RecipeCreateViewModel
	{
		public IEnumerable<Ingredient> Ingredients { get; set; }
		public int[] IngredientsForRecipe { get; set; }
		public string[] AmountsForIngredients { get; set; }
		public IEnumerable<Step> Steps { get; set; }
		public Recipe Recipe { get; set; }
	}
}