using System.Diagnostics;

namespace RecipeGeneratorApp
{
    [DebuggerDisplay("{DebuggerDisplay(),nq}")]
    public class ProgramBase
    {
        public override string ToString() => "RecipeGeneratorApp Program Instance";
    }
}