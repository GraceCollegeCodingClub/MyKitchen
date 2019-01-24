using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	public class RecipeIngredient
	{
		public int RecipeIngredientId { get; set; }
		public string Amount { get; set; }
		public int RecipeId { get; set; }
		public int IngredientId { get; set; }
	}
}
