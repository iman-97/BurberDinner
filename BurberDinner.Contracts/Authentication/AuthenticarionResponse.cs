namespace BurberDinner.Contracts.Authentication;

public record AuthenticarionResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);

