using FluentValidation;
using ProniaApi.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.Validators
{
    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(x => x.UserNameOrEmail)
                .NotEmpty().WithMessage("Email address bosh ola bilmez")
                .MaximumLength(256).WithMessage("Uzunlugu 256-dan cox ola bilmez");

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(8).WithMessage("Uzunlugu 8-den az ola bilmez")
                .MaximumLength(150).WithMessage("Uzunlugu 150-den cox ola bilmez");

        }
    }
}
