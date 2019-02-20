using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	[Table("MealPlan", Schema = "MyKitchenDb")]
	public class MealPlan
	{
		[Key]
		public int MealPlanId { get; set; }
		public int DayOfWeek { get; set; }
		public string Meal { get; set; }
		public int RecipeId { get; set; }
		public int UserID { get; set; }
	}
}
