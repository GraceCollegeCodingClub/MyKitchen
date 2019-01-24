using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyKitchen.Models
{
	[Table("recipe",Schema = "my_kitchen_db")]
	public class Recipe
	{
		[Key]
		public int RecipeId { get; set; }
		public string RecipeName { get; set; }
		public int UserId { get; set; }
	}
}
