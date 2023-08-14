using System;

namespace fluent_validation_1;

public record CreateEmployeeInput
{
    public string Name { get; init; }
    public DateTime? BirthedAt { get; init; }
    public string Email { get; init; }
    public string Gender { get; init; }
    public string PhoneNumber { get; init; }
}

public enum Gender
{
    Male = 1,
    Female = 2
}
