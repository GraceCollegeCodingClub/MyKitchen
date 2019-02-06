using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	[Table("Recipe", Schema = "MyKitchenDb")]
	public class Recipe
	{
		[Key]
		public int RecipeId { get; set; }
		[Display(Name = "Recipe Name")]
		public string RecipeName { get; set; }
		public string UserId { get; set; }
	}
}
