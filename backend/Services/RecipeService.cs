using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly List<Recipe> _recipes;

        public RecipeService()
        {
            _recipes = new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Name = "Chicken Adobo",
                    Description = "A classic Filipino dish made with chicken stewed in soy sauce, vinegar, garlic, and black peppercorns.",
                    Region = "Southeast Asia",
                    Country = "Philippines",
                    ImageUrls = new List<string>
                    {
                        "/images/adobo1.jpg",
                        "/images/adobo2.jpg",
                        "/images/adobo3.jpg"
                    },
                    PrepTime = 15,
                    CookTime = 40,
                    Ingredients = new List<string>
                    {
                        "1 kg chicken pieces (thighs and drumsticks work well)",
                        "1/2 cup soy sauce",
                        "1/2 cup cane vinegar (or white vinegar)",
                        "1 head garlic, minced",
                        "1 tsp whole black peppercorns",
                        "2 bay leaves",
                        "1 tbsp cooking oil",
                        "1 cup water (optional, for more sauce)"
                    },
                    Steps = new List<string>
                    {
                        "Combine chicken, soy sauce, vinegar, minced garlic, peppercorns, and bay leaves in a pot. Marinate for at least 30 minutes (or longer for more flavor).",
                        "Heat cooking oil in a separate pot or pan over medium heat.",
                        "Remove chicken pieces from marinade (reserve marinade) and brown them in the hot oil.",
                        "Pour the reserved marinade over the browned chicken.",
                        "Add water if desired. Bring to a boil, then reduce heat to low, cover, and simmer for 30-40 minutes, or until chicken is tender and cooked through.",
                        "Remove cover and simmer for another 5-10 minutes to reduce the sauce to your desired consistency.",
                        "Serve hot with steamed rice."
                    },
                    CulturalContext = "Adobo is considered the unofficial national dish of the Philippines and has countless variations across different regions and families.",
                    Difficulty = "Easy",
                    Tags = new List<string> { "Chicken", "Filipino", "Stew" },
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Pork Adobo",
                    Description = "A rich and savory Filipino pork dish simmered in soy sauce, vinegar, garlic, and spices.",
                    Region = "Southeast Asia",
                    Country = "Philippines",
                    ImageUrls = new List<string>
                    {
                        "/images/pork1.jpg",
                        "/images/pork2.jpg",
                        "/images/pork3.jpg"
                    },
                    PrepTime = 20,
                    CookTime = 60,
                    Ingredients = new List<string>
                    {
                        "1 kg pork belly or shoulder, cut into cubes",
                        "1/2 cup soy sauce",
                        "1/2 cup vinegar",
                        "1 head garlic, crushed",
                        "1 tsp whole black peppercorns",
                        "3 bay leaves",
                        "2 tbsp cooking oil",
                        "1 cup water"
                    },
                    Steps = new List<string>
                    {
                        "In a pot, combine pork, soy sauce, vinegar, crushed garlic, peppercorns, and bay leaves. Marinate for 30 minutes.",
                        "Heat oil in a pan, brown pork pieces.",
                        "Transfer browned pork to the pot with the marinade.",
                        "Add water. Bring to a boil, then simmer until pork is tender (about 45-60 minutes).",
                        "Remove bay leaves. Continue to simmer to reduce sauce.",
                        "Serve hot with rice."
                    },
                    CulturalContext = "Pork Adobo is as popular as Chicken Adobo, often preferred for its tender and flavorful meat.",
                    Difficulty = "Medium",
                    Tags = new List<string> { "Pork", "Filipino", "Stew" },
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Adobong Pusit",
                    Description = "Filipino squid dish stewed in soy sauce, vinegar, garlic, and its own ink for a distinct dark color and rich flavor.",
                    Region = "Southeast Asia",
                    Country = "Philippines",
                    ImageUrls = new List<string>
                    {
                        "/images/squid1.jpg",
                        "/images/squid2.jpg",
                        "/images/squid3.jpg"
                    },
                    PrepTime = 15,
                    CookTime = 30,
                    Ingredients = new List<string>
                    {
                        "500g squid, cleaned and sliced",
                        "1/4 cup soy sauce",
                        "1/4 cup vinegar",
                        "4 cloves garlic, minced",
                        "1 onion, sliced",
                        "2 green chilies (optional)",
                        "Squid ink sacs (optional)",
                        "1 tbsp cooking oil"
                    },
                    Steps = new List<string>
                    {
                        "In a bowl, combine squid, soy sauce, and vinegar. Marinate for 15 minutes.",
                        "Heat oil in a pan, sauté garlic and onions.",
                        "Add squid and marinade. If using ink sacs, add them now.",
                        "Bring to a simmer and cook for 20-30 minutes, or until squid is tender.",
                        "Add green chilies if desired. Simmer for a few more minutes.",
                        "Serve hot."
                    },
                    CulturalContext = "Adobong Pusit is a popular seafood variation, known for its unique taste and appearance when squid ink is used.",
                    Difficulty = "Easy",
                    Tags = new List<string> { "Squid", "Seafood", "Filipino" },
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new Recipe
                {
                    Id = 4,
                    Name = "Adobong Kangkong",
                    Description = "A simple and healthy Filipino vegetable dish made with water spinach stewed in soy sauce, vinegar, and garlic.",
                    Region = "Southeast Asia",
                    Country = "Philippines",
                    ImageUrls = new List<string>
                    {
                        "/images/kangkong1.jpg",
                        "/images/kangkong2.jpg",
                        "/images/kangkong3.jpg"
                    },
                    PrepTime = 10,
                    CookTime = 15,
                    Ingredients = new List<string>
                    {
                        "1 bunch kangkong (water spinach), trimmed and cut",
                        "2 tbsp soy sauce",
                        "2 tbsp vinegar",
                        "3 cloves garlic, minced",
                        "1/2 onion, sliced",
                        "1 tbsp cooking oil"
                    },
                    Steps = new List<string>
                    {
                        "Heat oil in a pan, sauté garlic and onions.",
                        "Add kangkong and stir-fry for a few minutes.",
                        "Pour in soy sauce and vinegar. Bring to a simmer.",
                        "Cook until kangkong is tender-crisp (about 5-7 minutes).",
                        "Serve immediately."
                    },
                    CulturalContext = "Adobong Kangkong is a popular and easy-to-make side dish or vegetarian option.",
                    Difficulty = "Very Easy",
                    Tags = new List<string> { "Vegetable", "Filipino", "Healthy" },
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };
        }

        public Task<IEnumerable<Recipe>> GetAllRecipesAsync()
        {
            return Task.FromResult(_recipes.AsEnumerable());
        }

        public Task<Recipe> GetRecipeByIdAsync(int id)
        {
            return Task.FromResult(_recipes.FirstOrDefault(r => r.Id == id));
        }

        public Task<IEnumerable<Recipe>> GetRecipesByRegionAsync(string region)
        {
            return Task.FromResult(_recipes.Where(r => r.Region.Equals(region, StringComparison.OrdinalIgnoreCase)));
        }

        public Task<IEnumerable<string>> GetAllRegionsAsync()
        {
            return Task.FromResult(_recipes.Select(r => r.Region).Distinct());
        }
    }
} 