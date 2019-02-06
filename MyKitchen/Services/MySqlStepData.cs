using System.Collections.Generic;
using System.Linq;
using MyKitchen.Data;
using MyKitchen.Models;

namespace MyKitchen.Services
{
	public class MySqlStepData : IStepData
	{
		private IEnumerable<Step> _steps;
		private ApplicationDbContext _context;

		public MySqlStepData(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Step> GetSteps(int recipeId)
		{
			_steps = from s in _context.Steps
					 where s.RecipeId == recipeId
					 orderby s.StepId
					 select s;

			return _steps;
		}
	}
}