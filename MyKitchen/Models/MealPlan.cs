using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	public class MealPlan
	{
		public int MealPlanId { get; set; }
		public int DayOfWeek { get; set; }
		public string Meal { get; set; }
		public int RecipeId { get; set; }
		public int UserID { get; set; }
	}
}
