using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	[Table("RecipeIngredient", Schema = "MyKitchenDb")]
	public class RecipeIngredient
	{
		[Key]
		public int RecipeIngredientId { get; set; }
		public string Amount { get; set; }
		public int RecipeId { get; set; }
		public int IngredientId { get; set; }
	}
}
