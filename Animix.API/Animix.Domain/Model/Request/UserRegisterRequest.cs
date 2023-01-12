using FluentValidation;

namespace Animix.Domain.Model.Request
{
    public class UserRegisterRequest
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserRegisterRequestValidation : AbstractValidator<UserRegisterRequest>
    {
        public UserRegisterRequestValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email deve ser informado!");

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome deve ser informado!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .WithMessage("Senha deve ser informada!");

            RuleFor(x => x.NickName)
                .NotEmpty()
                .NotNull()
                .WithMessage("O Apelido da conta precisa ser informado!");
        }
    }
}
