using System.Collections.Generic;
using MyKitchen.Models;

namespace MyKitchen.Services
{
	public interface IStepData
	{
		IEnumerable<Step> GetSteps(int recipeId);
	}
}