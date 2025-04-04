// Services/RecipeService.cs

using System.Diagnostics;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace RecipeGeneratorApp
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class Program : ProgramBase
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<Components.App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            // ... rest of your code ...

            await builder.Build().RunAsync();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private string GetDebuggerDisplay() => ToString();
    }
}
