using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetAllRecipesAsync();
        Task<Recipe> GetRecipeByIdAsync(int id);
        Task<IEnumerable<Recipe>> GetRecipesByRegionAsync(string region);
        Task<IEnumerable<string>> GetAllRegionsAsync();
    }
} 