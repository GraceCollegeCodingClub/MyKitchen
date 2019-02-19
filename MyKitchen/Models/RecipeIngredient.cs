using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	[Table("RecipeIngredients", Schema = "MyKitchenDb")]
	public class RecipeIngredient
	{
		[Key]
		public int RecipeIngredientsId { get; set; }
		public string Amount { get; set; }
		public int RecipeId { get; set; }
		public int IngredientId { get; set; }
	}
}
