using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	[Table("recipe", Schema = "my_kitchen_db")]
	public class Recipe
	{
		[Key]
		public int recipe_id { get; set; }
		public string recipe_name { get; set; }
		public string user_id { get; set; }
	}
}
