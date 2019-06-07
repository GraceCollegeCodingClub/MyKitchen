using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyKitchen.Models;

namespace MyKitchen.ViewModels
{
	public class RecipeViewModel
	{
		public IEnumerable<Ingredient> Ingredients { get; set; }
		[Display(Name = "Ingredient")]
		public int[] IngredientsForRecipe { get; set; }
		[Display(Name = "Amount")]
		public string[] AmountsForIngredients { get; set; }
		[Display(Name = "Steps")]
		public string Steps { get; set; }
		public Recipe Recipe { get; set; }
		public int Iterator { get; set; }
	}
}