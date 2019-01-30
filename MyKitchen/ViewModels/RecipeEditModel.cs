using System.ComponentModel.DataAnnotations;

namespace MyKitchen.ViewModels
{
	public class RecipeEditModel
	{
		[Required]
		public string recipe_name { get; set; }
	}
}