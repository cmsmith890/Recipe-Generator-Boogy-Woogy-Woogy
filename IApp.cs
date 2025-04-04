using Microsoft.AspNetCore.Components;

namespace App
{
    public interface IApp
    {
        bool Equals(object? obj);
        int GetHashCode();
        Task SetParametersAsync(ParameterView parameters);
        string? ToString();
    }
}