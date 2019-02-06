using System.Collections.Generic;
using MyKitchen.Models;

namespace MyKitchen.ViewModels
{
	public class RecipeCreateViewModel
	{
		public IEnumerable<Ingredient> Ingredients { get; set; }
		public IEnumerable<Step> Steps { get; set; }
		public Recipe Recipe { get; set; }
	}
}