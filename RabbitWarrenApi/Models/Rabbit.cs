#nullable enable

namespace RabbitWarrenApi.Models;

/// <summary>
/// Represents a rabbit available for adoption.
/// </summary>
public record Rabbit(
    Guid Id,
    string Name,
    string Color,
    int AgeInMonths,
    string Description,
    bool IsAvailable,
    DateTimeOffset DateAdded);