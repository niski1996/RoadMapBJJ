using DrillRoad.Contracts.Entities.Persons;
using FluentValidation;

namespace DrillRoad.Contracts.Validators.Entities.Users;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        // RuleFor(user => user.UserName)
        //     .NotEmpty().WithMessage("Username is required.")
        //     .Length(3, 20).WithMessage("Username must be between 3 and 20 characters.");
        
        RuleFor(user => user.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
            .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
            .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
            .Matches("[0-9]").WithMessage("Password must contain at least one number.")
            .Matches("[^a-zA-Z0-9]").WithMessage("Password must contain at least one special character.");
    }
}