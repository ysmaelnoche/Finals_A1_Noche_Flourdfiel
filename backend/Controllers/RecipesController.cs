using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetAllRecipes()
        {
            var recipes = await _recipeService.GetAllRecipesAsync();
            return Ok(recipes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recipe>> GetRecipeById(int id)
        {
            var recipe = await _recipeService.GetRecipeByIdAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

        [HttpGet("region/{region}")]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipesByRegion(string region)
        {
            var recipes = await _recipeService.GetRecipesByRegionAsync(region);
            return Ok(recipes);
        }

        [HttpGet("regions")]
        public async Task<ActionResult<IEnumerable<string>>> GetAllRegions()
        {
            var regions = await _recipeService.GetAllRegionsAsync();
            return Ok(regions);
        }
    }
} 