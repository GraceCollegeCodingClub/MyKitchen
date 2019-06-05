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
		public IEnumerable<Step> Steps { get; set; }
		public Recipe Recipe { get; set; }
	}
}