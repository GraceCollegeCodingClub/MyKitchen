using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.ViewModels
{
	public class RecipeEditModel
	{
		[Required]
		public string recipe_name { get; set; }
	}
}
