// Models/Recipe.cs
namespace RecipeGeneratorApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        // Add other properties as needed
    }
}