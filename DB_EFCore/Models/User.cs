using DB_EFCore.Models.Enums;

namespace DB_EFCore.Models;

public record User
{
    public UserType UserType { get; set; }
    public string? Username { get; init; } = string.Empty;
    public string? Password { get; init; } = string.Empty;
}