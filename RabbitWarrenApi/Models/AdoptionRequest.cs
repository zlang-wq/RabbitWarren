namespace RabbitWarrenApi.Models;

/// <summary>
/// Represents a rabbit adoption request.
/// </summary>
public record AdoptionRequest(
    Guid Id,
    string AdopterName,
    string ContactEmail,
    string Phone,
    string? PreferredSize,
    string? PreferredColor,
    string? PreferredAge,
    string? Priority,
    string Status); 