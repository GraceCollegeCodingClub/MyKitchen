using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	[Table("Step", Schema = "MyKitchenDb")]
	public class Step
	{
		[Key]
		public int StepId { get; set; }
		public int StepNumber { get; set; }
		public string StepInstruction { get; set; }
		public int RecipeId { get; set; }
	}
}
