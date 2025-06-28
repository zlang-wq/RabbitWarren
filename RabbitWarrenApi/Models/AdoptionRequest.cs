#nullable enable

namespace RabbitWarrenApi.Models;

/// <summary>
/// Represents a rabbit adoption request.
/// </summary>
public record AdoptionRequest(
    Guid Id,
    string AdopterName,
    string ContactEmail,
    string Phone,
    PreferredSize PreferredSize,
    PreferredColor PreferredColor,
    PreferredAge PreferredAge,
    Priority Priority,
    AdoptionStatus Status); 