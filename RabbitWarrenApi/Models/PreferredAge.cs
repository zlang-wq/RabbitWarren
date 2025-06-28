namespace RabbitWarrenApi.Models;

/// <summary>
/// Represents the preferred age options for a rabbit adoption request.
/// </summary>
public enum PreferredAge
{
    Baby,      // Under 6 months
    Young,     // 6 months to 2 years
    Adult,     // 2 to 5 years
    Senior,     // Over 5 years
    NoPreference
}