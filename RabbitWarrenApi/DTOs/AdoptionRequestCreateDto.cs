using RabbitWarrenApi.Models;

#nullable enable

namespace RabbitWarrenApi.DTOs;

/// <summary>
/// DTO for submitting a new adoption request.
/// </summary>
public record AdoptionRequestCreateDto(
    string AdopterName,
    string ContactEmail,
    string Phone,
    PreferredSize? PreferredSize,
    PreferredColor? PreferredColor,
    PreferredAge? PreferredAge,
    Priority? Priority); 