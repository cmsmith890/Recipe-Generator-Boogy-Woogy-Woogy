namespace RecipeGeneratorApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public required string Cuisine { get; set; } // Added Cuisine property
        public List<string> Ingredients { get; set; } = new List<string>();
        public string Instructions { get; set; } = string.Empty;
    }
}
