namespace RabbitWarrenApi.Models;

/// <summary>
/// DTO for submitting a new adoption request.
/// </summary>
public record AdoptionRequestCreateDto(
    string AdopterName,
    string ContactEmail,
    string Phone,
    string? PreferredSize,
    string? PreferredColor,
    string? PreferredAge,
    string? Priority); 