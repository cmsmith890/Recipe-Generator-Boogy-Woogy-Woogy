// Services/RecipeService.cs
using RecipeGeneratorApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeGeneratorApp.Services
{
    public class RecipeService
    {
        private static readonly List<Recipe> _recipes = new()
        {
            new Recipe { Id = 1, Name = "Pasta Carbonara", Cuisine = "Italian", Ingredients = new List<string> { "Spaghetti", "Eggs", "Pecorino Romano", "Guanciale" } },
            new Recipe { Id = 2, Name = "Tacos al Pastor", Cuisine = "Mexican", Ingredients = new List<string> { "Pork shoulder", "Pineapple", "Onions", "Cilantro" } },
            new Recipe { Id = 3, Name = "Margherita Pizza", Cuisine = "Italian", Ingredients = new List<string> { "Dough", "Tomato Sauce", "Mozzarella", "Basil" } },
            new Recipe { Id = 4, Name = "Chicken Enchiladas", Cuisine = "Mexican", Ingredients = new List<string> { "Chicken", "Tortillas", "Cheese", "Salsa" } }
        };

        public Task<List<Recipe>> GetRecipesAsync(string ingredients = null, string cuisine = null)
        {
            return Task.FromResult(_recipes
                .Where(r =>
                    (string.IsNullOrEmpty(ingredients) || r.Ingredients.Any(i => i.Contains(ingredients, System.StringComparison.OrdinalIgnoreCase))) &&
                    (string.IsNullOrEmpty(cuisine) || r.Cuisine.Equals(cuisine, System.StringComparison.OrdinalIgnoreCase)))
                .ToList());
        }
    }
}