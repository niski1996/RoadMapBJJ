using DrillRoad.Contracts.Entities.Persons;
using FluentValidation;

namespace DrillRoad.Contracts.Validators.Entities.Users;

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(address => address.PostalCode)
            .NotEmpty().WithMessage("Street is required.")
            .MaximumLength(100).WithMessage("Street name cannot exceed 100 characters.");

        RuleFor(address => address.City)
            .NotEmpty().WithMessage("City is required.")
            .MaximumLength(50).WithMessage("City name cannot exceed 50 characters.");

        RuleFor(address => address.PostalCode)
            .NotEmpty().WithMessage("Postal code is required.")
            .Matches("^[0-9]{2}-[0-9]{3}$").WithMessage("Postal code must be in the format 'XX-XXX'.");

        RuleFor(address => address.Country)
            .NotEmpty().WithMessage("Country is required.")
            .MaximumLength(50).WithMessage("Country name cannot exceed 50 characters.");
    }
}