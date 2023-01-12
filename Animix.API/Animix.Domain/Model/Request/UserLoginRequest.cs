using FluentValidation;

namespace Animix.Domain.Model.Request
{
    public class UserLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginRequestValidation : AbstractValidator<UserLoginRequest>
    {
        public UserLoginRequestValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email deve ser informado!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .WithMessage("Senha deve ser informada!");
        }
    }
}
