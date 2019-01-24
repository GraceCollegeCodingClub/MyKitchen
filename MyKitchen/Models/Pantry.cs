using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	public class Pantry
	{
		public int PantryId { get; set; }
		public int CurrentAmount { get; set; }
		public int IngredientId { get; set; }
		public int UserId { get; set; }
	}
}
