using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	public class Step
	{
		public int StepId { get; set; }
		public int StepNumber { get; set; }
		public string StepInstruction { get; set; }
		public int RecipeId { get; set; }
	}
}
