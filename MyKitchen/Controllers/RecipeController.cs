using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyKitchen.Models;
using MyKitchen.Services;
using MyKitchen.ViewModels;

namespace MyKitchen.Controllers
{
    public class RecipeController : Controller
    {
	    private MySqlRecipeData _recipeData;

	    public IActionResult Index(int id)
	    {
		    var model = _recipeData.GetRecipes(id);

            return View(model);
        }

	    public IActionResult Details(int id)
	    {
		    var model = _recipeData.GetRecipe(id);

		    return View(model);
	    }

		[HttpGet]
	    public IActionResult Create()
	    {
		    return View();
	    }

		[HttpPost]
		[ValidateAntiForgeryToken]
	    public IActionResult Create(RecipeEditModel model)
		{
			if (ModelState.IsValid)
			{
				var newRecipe = new Recipe();
				newRecipe.recipe_name = model.recipe_name;

				newRecipe = _recipeData.Add(newRecipe);

				return RedirectToAction(nameof(Details), new {Id = newRecipe.recipe_id});
			}
			else
			{
				return View();
			}
		}
    }
}