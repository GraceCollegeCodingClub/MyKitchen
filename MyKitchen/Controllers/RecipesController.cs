using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyKitchen.Data;
using MyKitchen.Models;
using MyKitchen.Services;
using MyKitchen.ViewModels;

namespace MyKitchen.Controllers
{
	[Authorize]
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;
	    private MySqlRecipeData _recipeData;
		private UserManager<IdentityUser> _userManager;
	    private ILogger _logger;
	    private MySqlIngredientData _ingredientData;
	    private MySqlStepData _stepData;

	    public RecipesController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<RecipesController> logger)
        {
            _context = context;
	        _userManager = userManager;
	        _recipeData = new MySqlRecipeData(_context);
			_ingredientData = new MySqlIngredientData(_context);
	        //_stepData = new MySqlStepData(_context);
	        _logger = logger;
        }

		// GET: Recipes
		public async Task<IActionResult> Index()
        {
	        var user = await _userManager.GetUserAsync(HttpContext.User);

	        var model = _recipeData.GetRecipes(user.Id);

	        return View(model);
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // GET: Recipes/Create
        public IActionResult Create()
        {
	        var model = new RecipeViewModel();

	        model.Ingredients = _ingredientData.GetIngredients();

	        //model.Steps = _stepData.GetSteps();

            return View(model);
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RecipeViewModel model)
        {
			if (ModelState.IsValid)
			{
				var user = await _userManager.GetUserAsync(HttpContext.User);
				model.Recipe.UserId = user.Id;
				if (_context.Recipes.Count() != 0)
				{
					model.Recipe.RecipeId =
						_context.Recipes.OrderByDescending(recipe => recipe.RecipeId).First().RecipeId;
					model.Recipe.RecipeId++;
				}
				else
				{
					model.Recipe.RecipeId = 1;
				}

				List <RecipeIngredient> recipeIngredient = new List<RecipeIngredient>();
				for (var i = 0; i < model.IngredientsForRecipe.Count(); i++)
				{
					RecipeIngredient temp = new RecipeIngredient
					{
						RecipeId = model.Recipe.RecipeId,
						IngredientId = model.IngredientsForRecipe[i],
						Amount = model.AmountsForIngredients[i]
					};
					_context.Add(temp);
				}

				_context.Add(model.Recipe);

				await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecipeId,RecipeName,UserId")] Recipe recipe)
        {
			//recipe = 
            if (id != recipe.RecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.RecipeId))
                    {
						Console.WriteLine("Recipe does not exist");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

	    public ActionResult AddIngredient([FromBody] Ingredient ingredients)
	    {
			RecipeViewModel model = new RecipeViewModel();

		    model.Ingredients.Append(ingredients);

		    return PartialView("_IngredientPartial", model);
	    }

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.RecipeId == id);
        }
    }
}
