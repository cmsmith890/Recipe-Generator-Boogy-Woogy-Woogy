
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
public record Recipes
{
    public Recipes()
    {
    }

    public int Id { get; init; }
    public required string Name { get; set; }
    public required string Title { get; set; }
    public required string Cuisine { get; set; }
    public List<string> Ingredients { get; set; } = new();
    public required string Instructions { get; set; }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
