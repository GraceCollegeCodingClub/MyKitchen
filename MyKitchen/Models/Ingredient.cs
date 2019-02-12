using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	[Table("Ingredient", Schema = "MyKitchenDb")]
	public class Ingredient
	{
		[Key]
		public int IngredientId { get; set; }
		public string IngredientName { get; set; }
	}
}
