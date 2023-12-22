using FluentValidation;
using ProniaApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.Validators
{
    internal class CreateTagDtoValidator : AbstractValidator<Tag>
    {
        public CreateTagDtoValidator()
        {
            RuleFor(t => t.Name).NotEmpty().MaximumLength(50);
        }
    }
}
