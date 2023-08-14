using System;
using FluentValidation;

namespace fluent_validation_1;

public class CreateEmployeeInputValidate : AbstractValidator<CreateEmployeeInput>
{
    public CreateEmployeeInputValidate()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MinimumLength(5)
            .MaximumLength(50)
            .Matches("^[A-Za-z ]+$")
                .WithMessage("'{PropertyName}' invalid format.");

        RuleFor(x => x.BirthedAt)
            .NotNull()
            .GreaterThan(DateTime.MinValue)
            .LessThan(DateTime.UtcNow);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Gender)
            .NotEmpty()
            .IsEnumName(typeof(Gender));

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .Matches("^\\+55\\d{10,11}$").WithMessage("'{PropertyName}' invalid format.");
    }
}
